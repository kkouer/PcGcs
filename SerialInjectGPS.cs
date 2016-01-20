using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MissionPlanner.Comms;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using log4net;
using System.Collections;
using piksiNamespace;
using System.Runtime.InteropServices;
using piksiNamespace;
using piksiNamespace.Comms;

namespace MissionPlanner
{
    public partial class SerialInjectGPS : Form
    {
        private static readonly ILog log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        // serialport
        internal static ICommsSerial comPort = new MissionPlanner.Comms.SerialPort();
        // rtcm detection
        private Utilities.rtcm3 rtcm3 = new Utilities.rtcm3();
        // sbp detection
        private Utilities.sbp sbp = new Utilities.sbp();
        // background thread 
        private System.Threading.Thread t12;
        private static bool threadrun = false;
        // track rtcm msg's seen
        static Hashtable msgseen = new Hashtable();
        // track bytes seen
        static int bytes = 0;
        static int bps = 0;

        // Thread signal. 
        public static ManualResetEvent tcpClientConnected = new ManualResetEvent(false);


        public SerialInjectGPS()
        {
            InitializeComponent();

            CMB_serialport.Items.AddRange(MissionPlanner.Comms.SerialPort.GetPortNames());
            CMB_serialport.Items.Add("UDP Host");
            //CMB_serialport.Items.Add("UDP Client");
            //CMB_serialport.Items.Add("TCP Client");
            //CMB_serialport.Items.Add("NTRIP");

            if (threadrun)
            {
                BUT_connect.Text = Strings.Stop;
            }

            MissionPlanner.Utilities.Tracking.AddPage(this.GetType().ToString(), this.Text);

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void BUT_connect_Click(object sender, EventArgs e)
        {
            if (comPort.IsOpen)
            {
                threadrun = false;
                comPort.Close();
                BUT_connect.Text = Strings.Connect;
            }
            else
            {
                try
                {
                    switch (CMB_serialport.Text)
                    {
                        case "NTRIP":
                            comPort = new CommsNTRIP();
                            CMB_baudrate.SelectedIndex = 0;
                            break;
                        case "TCP Client":
                            comPort = new TcpSerial();
                            CMB_baudrate.SelectedIndex = 0;
                            break;
                        case "UDP Host":
                            comPort = new UdpSerial();
                            CMB_baudrate.SelectedIndex = 0;
                            break;
                        case "UDP Client":
                            comPort = new UdpSerialConnect();
                            CMB_baudrate.SelectedIndex = 0;
                            break;
                        default:
                            comPort = new MissionPlanner.Comms.SerialPort();
                            comPort.PortName = CMB_serialport.Text;
                            break;
                    }
                }
                catch
                {
                    CustomMessageBox.Show(Strings.InvalidPortName);
                    return;
                }
                try
                {
                    comPort.BaudRate = int.Parse(CMB_baudrate.Text);
                }
                catch
                {
                    CustomMessageBox.Show(Strings.InvalidBaudRate);
                    return;
                }
                try
                {
                    comPort.Open();
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show("Error Connecting\nif using com0com please rename the ports to COM??\n" +
                                          ex.ToString());
                    return;
                }

                t12 = new System.Threading.Thread(new System.Threading.ThreadStart(mainloop))
                {
                    IsBackground = true,
                    Name = "injectgps"
                };
                t12.Start();

                BUT_connect.Text = Strings.Stop;

                msgseen.Clear();
                bytes = 0;
            }
        }

        private void updateLabel(string label)
        {
            if (!this.IsDisposed)
            {
                this.BeginInvoke(
                    (MethodInvoker)
                        delegate
                        {
                            this.lbl_status.Text = label;
                        }
                    );
            }
        }

        private void mainloop()
        {
            DateTime lastrecv = DateTime.MinValue;
            threadrun = true;
            while (threadrun)
            {
                try
                {
                    // reconnect logic - 10 seconds with no data, or comport is closed
                    try
                    {
                        if ((DateTime.Now - lastrecv).TotalSeconds > 10 || !comPort.IsOpen)
                        {
                            log.Info("Reconnecting");
                            // close existing
                            comPort.Close();
                            // reopen
                            comPort.Open();
                            // reset timer
                            lastrecv = DateTime.Now;
                        }
                    }
                    catch
                    {
                        log.Error("Failed to reconnect");
                        // sleep for 10 seconds on error
                        System.Threading.Thread.Sleep(10000);
                    }

                    // limit to 110 byte packets
                    byte[] buffer = new byte[110];

                    while (comPort.BytesToRead > 0)
                    {
                        int read = comPort.Read(buffer, 0, Math.Min(buffer.Length, comPort.BytesToRead));

                        if (read > 0)
                            lastrecv = DateTime.Now;

                        bytes += read;
                        bps += read;

                        //MainV2.comPort.InjectGpsData(buffer, (byte) read);
                        GCSMainForm.comPort.InjectGpsData(buffer, (byte)read);


                        // check for valid rtcm packets
                        for (int a = 0; a < read; a++)
                        {
                            int seen = -1;
                            // rtcm
                            if ((seen = rtcm3.Read(buffer[a])) > 0)
                            {
                                if (!msgseen.ContainsKey(seen))
                                    msgseen[seen] = 0;
                                msgseen[seen] = (int)msgseen[seen] + 1;
                            }
                            // sbp
                            if ((seen = sbp.read(buffer[a])) > 0)
                            {
                                if (!msgseen.ContainsKey(seen))
                                    msgseen[seen] = 0;
                                msgseen[seen] = (int)msgseen[seen] + 1;
                            }
                        }
                    }

                    System.Threading.Thread.Sleep(10);
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }
            }
        }

        private void CMB_serialport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!CMB_serialport.Text.ToLower().Contains("com"))
                CMB_baudrate.Enabled = false;
            else
                CMB_baudrate.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (var item in msgseen.Keys)
                {
                    sb.Append(item + "=" + msgseen[item] + " ");
                }
            }
            catch
            {
            }

            updateLabel("bytes " + bytes + " bps " + bps + "\n" + sb.ToString());
            bps = 0;
        }

        private void SerialInjectGPS_Load(object sender, EventArgs e)
        {
            timer1.Start();
            comboBox1.SelectedIndex = 0;
        }

        private void SerialInjectGPS_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }


        //SPB转换相关方法
        static RTCM3 rtcm = new RTCM3();
        static piksi piksi = new piksi();

        static IStreamExtra inputstream;

        //static IStreamExtra deststream;

        private static System.Net.Sockets.TcpClient rawpiksiclient;

        Thread t;
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            t = new Thread(TransformData);
            t.Start();
            btnTransfer.Enabled = false;
        }

        void TransformData()
        {
            try
            {
                inputstream = new piksiNamespace.Comms.SerialPort(CMB_serialport.Text, Convert.ToInt32(CMB_baudrate.Text));
            }
            catch { }
            //RTCM输入源
            if(comboBox1.SelectedIndex == 0)
            {
                try
                {
                    inputstream.Open();
                }
                catch { }
                

                rtcm.ObsMessage += rtcm_ObsMessage;
                //rtcm.BasePosMessage += rtcm_BasePosMessage;
                while (true)
                {
                    while (inputstream.dataToRead)
                    {
                        rtcm.Read((byte)inputstream.ReadByte());
                    }


                    System.Threading.Thread.Sleep(5);
                }

            }
            //SBP转RTCM
            if(comboBox1.SelectedIndex == 1)
            {
                try
                {
                    //打开输入源
                    //if (!inputstream.IsOpen)
                        inputstream.Open();

                        piksi.ObsMessage += pkrtcm_ObsMessage;
                        piksi.EphMessage += pkrtcm_EphMessage;

                        while (true)
                        {
                            while (inputstream.dataToRead)
                            {
                                piksi.read((byte)inputstream.ReadByte());
                            }

                            System.Threading.Thread.Sleep(5);
                        }
                }
                catch { }
            }
        }

        private void pkrtcm_EphMessage(object sender, EventArgs e)
        {
            //RTCM1019 
            piksi.piksimsg msg = (piksi.piksimsg)sender;

            var eph = msg.payloads.ByteArrayToStructure<piksi.ephemeris_t>(0);

            if (eph.valid > 0)
            {
                var ephrtcm = new RTCM3.type1019();

                ephrtcm.A = eph.sqrta;
                ephrtcm.af0 = eph.af0;
                ephrtcm.af1 = eph.af1;
                ephrtcm.af2 = eph.af2;
                ephrtcm.cic = eph.cic;
                ephrtcm.cis = eph.cis;
                ephrtcm.cus = eph.cus;
                ephrtcm.cuc = eph.cuc;
                ephrtcm.crc = eph.crc;
                ephrtcm.crs = eph.crs;
                ephrtcm.deln = eph.dn;
                ephrtcm.e = eph.ecc;
                ephrtcm.i0 = eph.inc;
                ephrtcm.idot = eph.inc_dot;
                ephrtcm.M0 = eph.m0;
                ephrtcm.omg = eph.w;
                ephrtcm.OMG0 = eph.omega0;
                ephrtcm.OMGd = eph.omegadot;
                ephrtcm.prn = eph.sid + 1;
                ephrtcm.sqrtA = eph.sqrta;
                ephrtcm.tgd = eph.tgd;
                ephrtcm.toc = eph.toc.tow;
                ephrtcm.toes = eph.toe.tow;
                ephrtcm.week = eph.toe.wn;
                ephrtcm.code = 1;
                ephrtcm.iode = eph.iode;
                ephrtcm.iodc = eph.iodc;

                byte[] rtcmpacket = rtcm.gen_eph(ephrtcm);

                try
                {
                    //if (deststream != null)
                    //    deststream.Write(rtcmpacket, 0, rtcmpacket.Length);
                    GCSMainForm.comPort.InjectGpsData(rtcmpacket, (byte)rtcmpacket.Length);
                }
                catch { }
            }
        }

        const double CLIGHT = 299792458.0;   /* speed of light (m/s) */
        static double wl = CLIGHT / 1.57542E9;

        private static int[] lockcount = new int[33];

        static double lastpr = 0;
        static double lastcp = 0;
        private static double lastgeodist = 0;
        private static double lastgeodist2 = 0;
        private static double lastclockbias = 0;

        private void pkrtcm_ObsMessage(object sender, EventArgs e)
        {
            piksi.piksimsg msg = (piksi.piksimsg)sender;

            var hdr = msg.payloads.ByteArrayToStructure<piksi.msg_obs_header_t>(0);

            // relay packet
            if (msg.sender == 0)
                return;

            // total is number of packets
            int total = hdr.seq >> piksi.MSG_OBS_HEADER_SEQ_SHIFT;
            // this is packet count number
            int count = hdr.seq & piksi.MSG_OBS_HEADER_SEQ_MASK;

            int lenhdr = Marshal.SizeOf(hdr);

            int lenobs = Marshal.SizeOf(new piksi.packed_obs_content_t());

            int obscount = (msg.length - lenhdr) / lenobs;

            int linebase = (count > 0) ? 8 : 0;

            RTCM3.type1002 t1002 = new RTCM3.type1002();

            for (int a = 0; a < obscount; a++)
            {
                var ob = msg.payloads.ByteArrayToStructure<piksi.packed_obs_content_t>(lenhdr + a * lenobs);

                double[] sat_pos = new double[3];
                double[] sat_vel = new double[3];
                double clock_err = 0, clock_err_rate = 0;

                piksi.gps_time_t tt = new piksi.gps_time_t() { tow = hdr.t.tow / 1000.0, wn = hdr.t.wn };

                piksi.eph[ob.sid + 1].calc_sat_pos(sat_pos, sat_vel, ref clock_err, ref clock_err_rate, tt);

                double[] e1 = new double[3];
                double geodist = global::piksiNamespace.piksi.geodistnosagnac(new double[] { sat_pos[0], sat_pos[1], sat_pos[2] }, new double[] { piksi.lastpos[0], piksi.lastpos[1], piksi.lastpos[2] }, ref e1);

                double geodist2 = global::piksiNamespace.piksi.geodist(new double[] { sat_pos[0], sat_pos[1], sat_pos[2] }, new double[] { piksi.lastpos[0], piksi.lastpos[1], piksi.lastpos[2] }, ref e1);

                if (a == 2 && Graph.instance != null && !Graph.instance.IsDisposed)
                {
                    Graph.instance.Invoke((Action)delegate()
                    {
                        try
                        {
                            Graph.instance.zedGraphControl1.GraphPane.Title.Text =
                                (ob.sid + 1).ToString();
                        }
                        catch
                        {
                        }
                    });

                    double wl = CLIGHT / 1.57542E9;

                    double newpr = (ob.P / piksi.MSG_OBS_P_MULTIPLIER) + piksi.lastpos[3];
                    double newcp = -(ob.L.i + (ob.L.f / 256.0)) * wl;// +(piksi.clockdrift.linearRegression(0));

                    Graph.instance.AddData(1, tt.tow, lastpr - newpr);
                    Graph.instance.AddData(2, tt.tow, lastcp - newcp);
                    Graph.instance.AddData(3, tt.tow, lastgeodist - geodist);

                    //Graph.instance.AddData(5, tt.tow, -(lastclockbias - piksi.lastpos[3]));

                    lastpr = newpr;
                    lastcp = newcp;
                    lastgeodist = geodist;
                    lastgeodist2 = geodist2;
                    lastclockbias = piksi.lastpos[3];
                }

                if (a == 1 && Graph.instance != null)
                {
                    //Graph.instance.AddData(3, ob.P / piksi.MSG_OBS_P_MULTIPLIER);
                    //Graph.instance.AddData(4, -(ob.L.Li + (ob.L.Lf / 256.0)));
                }

                if (a == 2 && Graph.instance != null)
                {
                    //Graph.instance.AddData(5, ob.P / piksi.MSG_OBS_P_MULTIPLIER);
                    //Graph.instance.AddData(6, -(ob.L.Li + (ob.L.Lf / 256.0)));
                }

                RTCM3.ob rtcmob = new RTCM3.ob();

                rtcmob.prn = (byte)(ob.sid + 1);
                rtcmob.snr = (byte)(ob.cn0 / piksi.MSG_OBS_SNR_MULTIPLIER);
                rtcmob.pr = (ob.P / piksi.MSG_OBS_P_MULTIPLIER) + piksi.lastpos[3];
                rtcmob.cp = -(ob.L.i + (ob.L.f / 256.0));
                rtcmob.week = hdr.t.wn;
                rtcmob.tow = hdr.t.tow;

                if (lockcount[rtcmob.prn] == ob.@lock)
                {
                    rtcmob.raw.lock1 = 127;
                }

                lockcount[rtcmob.prn] = ob.@lock;

                t1002.obs.Add(rtcmob);
            }

            byte[] rtcmpacket = rtcm.gen_rtcm(t1002);

            try
            {
                //if (deststream != null)
                //    deststream.Write(rtcmpacket, 0, rtcmpacket.Length);
                GCSMainForm.comPort.InjectGpsData(rtcmpacket, (byte)rtcmpacket.Length);

            }
            catch { }
        }



        static double RE_WGS84 = 6378137.0;          /* earth semimajor axis (WGS84) (m) */

        static double FE_WGS84 = (1.0 / 298.257223563); /* earth flattening (WGS84) */

        const double PI = Math.PI; /* pi */

        const double D2R = (PI / 180.0);   /* deg to rad */
        const double R2D = (180.0 / PI);   /* rad to deg */

        static double dot(double[] a, double[] b, int n)
        {
            double c = 0.0;

            while (--n >= 0) c += a[n] * b[n];
            return c;
        }
        static double fabs(double input)
        {
            return Math.Abs(input);
        }

        static double atan(double input)
        {
            return Math.Atan(input);
        }
        static double atan2(double input, double input2)
        {
            return Math.Atan2(input, input2);
        }

        static double sqrt(double input)
        {
            return Math.Sqrt(input);
        }


        static void ecef2pos(double[] r, ref double[] pos)
        {
            double e2 = FE_WGS84 * (2.0 - FE_WGS84), r2 = dot(r, r, 2), z, zk, v = RE_WGS84, sinp;

            for (z = r[2], zk = 0.0; fabs(z - zk) >= 1E-4; )
            {
                zk = z;
                sinp = z / sqrt(r2 + z * z);
                v = RE_WGS84 / sqrt(1.0 - e2 * sinp * sinp);
                z = r[2] + v * e2 * sinp;
            }
            pos[0] = r2 > 1E-12 ? atan(z / sqrt(r2)) : (r[2] > 0.0 ? PI / 2.0 : -PI / 2.0);
            pos[1] = r2 > 1E-12 ? atan2(r[1], r[0]) : 0.0;
            pos[2] = sqrt(r2 + z * z) - v;
        }

        
        void rtcm_BasePosMessage(object sender, EventArgs e)
        {
            var msg1 = sender as RTCM3.type1005;
            var msg2 = sender as RTCM3.type1006;

            if (msg1 != null)
            {
                piksi.msg_base_pos_t bpos = new piksi.msg_base_pos_t();

                // in radians
                double[] llhr = new double[3];

                ecef2pos(new double[] { msg1.rr0 * 0.0001, msg1.rr1 * 0.0001, msg1.rr2 * 0.0001 }, ref llhr);

                bpos.pos_lat = llhr[0] * R2D;
                bpos.pos_lon = llhr[1] * R2D;
                bpos.pos_alt = llhr[2];

                byte[] packet = piksi.GeneratePacket(bpos, piksi.MSG.MSG_BASE_POS);

                //deststream.Write(packet, 0, packet.Length);
                //GCSMainForm.comPort.InjectGpsData(packet, (byte)packet.Length);
            }
            if (msg2 != null)
            {
                piksi.msg_base_pos_t bpos = new piksi.msg_base_pos_t();

                // in radians
                double[] llhr = new double[3];

                ecef2pos(new double[] { msg2.rr0 * 0.0001, msg2.rr1 * 0.0001, msg2.rr2 * 0.0001 }, ref llhr);

                bpos.pos_lat = llhr[0] * R2D;
                bpos.pos_lon = llhr[1] * R2D;
                bpos.pos_alt = llhr[2];

                byte[] packet = piksi.GeneratePacket(bpos, piksi.MSG.MSG_BASE_POS);

                //deststream.Write(packet, 0, packet.Length);

                //GCSMainForm.comPort.InjectGpsData(packet, (byte)packet.Length);
            }
        }


        //发给移动站数据
        void rtcm_ObsMessage(object sender, EventArgs e)
        {
            List<RTCM3.ob> msg = (List<RTCM3.ob>)sender;

            if (msg.Count == 0)
                return;

            byte total = 1;
            byte count = 0;

            piksi.observation_header_t head = new piksi.observation_header_t();
            head.t.wn = (ushort)(msg[0].week);
            head.t.tow = (uint)((msg[0].tow * piksi.MSG_OBS_TOW_MULTIPLIER));


            double soln_freq = 10;
            double obs_output_divisor = 2;

            double epoch_count = (head.t.tow / piksi.MSG_OBS_TOW_MULTIPLIER) * (soln_freq / obs_output_divisor);

            double checkleft = Math.Abs(epoch_count - Math.Round(epoch_count));

            Console.WriteLine(head.t.tow + " " + checkleft.ToString("0.000") + " " + epoch_count.ToString("0.000") + " " + Math.Round(epoch_count) + " > " + 1e-3);


            // rounding - should not need this, but testing against a ublox requires some "lieing"
            //head.t.tow = (uint)(Math.Round((decimal)(head.t.tow / 1000.0)) * (decimal)1000.0);

            List<piksi.packed_obs_content_t> obs = new List<piksi.packed_obs_content_t>();

            foreach (var item in msg)
            {
                item.cp *= -1;

                piksi.packed_obs_content_t ob = new piksi.packed_obs_content_t();
                ob.sid = (byte)(item.prn - 1);
                ob.P = (uint)(item.pr * piksi.MSG_OBS_P_MULTIPLIER);
                ob.L.i = (int)item.cp;
                ob.L.f = (byte)((item.cp - ob.L.i) * 256.0);
                ob.cn0 = (byte)(item.snr * piksi.MSG_OBS_SNR_MULTIPLIER);

                obs.Add(ob);
            }

            head.n_obs = (byte)((total << piksi.MSG_OBS_HEADER_SEQ_SHIFT) | (count & piksi.MSG_OBS_HEADER_SEQ_MASK));

            //create piksi packet

            piksi.piksimsg msgpreamble = new piksi.piksimsg();

            int lenpre = Marshal.SizeOf(msgpreamble) - 1; // 8
            int lenhdr = Marshal.SizeOf(head);
            int lenobs = Marshal.SizeOf(new piksi.packed_obs_content_t());

            byte[] allbytes = new byte[lenpre + lenhdr + lenobs * obs.Count];

            msgpreamble.crc = 0x1234;
            msgpreamble.preamble = 0x55;
            msgpreamble.msg_type = (ushort)piksi.MSG.SBP_MSG_OBS;
            msgpreamble.sender = 1;
            msgpreamble.length = (byte)(obs.Count * lenobs + lenhdr);
            msgpreamble.payloads = new byte[msgpreamble.length];

            int payloadcount = (lenpre - 2) + lenhdr; // exclude checksum

            foreach (var ob in obs)
            {
                byte[] obbytes = StaticUtils.StructureToByteArray(ob);
                Array.Copy(obbytes, 0, allbytes, payloadcount, obbytes.Length);
                payloadcount += lenobs;
            }

            byte[] preamblebytes = StaticUtils.StructureToByteArray(msgpreamble);

            Array.Copy(preamblebytes, 0, allbytes, 0, preamblebytes.Length - 2);

            byte[] headbytes = StaticUtils.StructureToByteArray(head);

            Array.Copy(headbytes, 0, allbytes, lenpre - 2, headbytes.Length);

            Crc16Ccitt crc = new Crc16Ccitt(InitialCrcValue.Zeros);
            ushort crcpacket = 0;
            for (int i = 1; i < (allbytes.Length - 2); i++)
            {
                crcpacket = crc.Accumulate(allbytes[i], crcpacket);
            }

            allbytes[allbytes.Length - 2] = (byte)(crcpacket & 0xff);
            allbytes[allbytes.Length - 1] = (byte)((crcpacket >> 8) & 0xff);


            //Console.WriteLine();

            //deststream.Write(allbytes, 0, allbytes.Length);

            GCSMainForm.comPort.InjectGpsData(allbytes, (byte)Math.Min(allbytes.Length, 110));// (byte)allbytes.Length);
        }

        private void SerialInjectGPS_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (t != null && t.IsAlive)
                    t.Abort();
                if (inputstream != null)
                    inputstream.Close();
            }
            catch
            {

            }
        }

    }
}