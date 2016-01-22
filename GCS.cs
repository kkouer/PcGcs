using GMap.NET;
using GMap.NET.MapProviders;
using MissionPlanner.Comms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class GCS : Form
    {
        Thread serialreaderthread;
        bool serialThread = false;
        public static MAVLinkInterface comPort = new MAVLinkInterface();
        public GCS()
        {
            InitializeComponent();

            //config map
            gMapControl1.CacheLocation = Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + "mapCache" + Path.DirectorySeparatorChar;
            gMapControl1.MapProvider = GMapProviders.AMap;
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 3;


            // setup main serial reader
            serialreaderthread = new Thread(SerialReader)
            {
                IsBackground = true,
                Name = "Main Serial reader",
                //Priority = ThreadPriority.BelowNormal
                Priority = ThreadPriority.AboveNormal
            };
            serialreaderthread.Start();


            //初始化端口空间
            this.comboBoxComPort.Items.AddRange(SerialPort.GetPortNames());
            comboBoxComPort.SelectedIndex = 0;
        }


        private void SerialReader()
        {
            if (serialThread == true)
                return;
            serialThread = true;
            while (serialThread)
            {
                try
                {
                    Thread.Sleep(1); // was 5

                    // if not connected or busy, sleep and loop
                    if (!comPort.BaseStream.IsOpen || comPort.giveComport == true)
                    {
                        if (!comPort.BaseStream.IsOpen)
                        {
                            // check if other ports are still open
                            if (comPort.BaseStream.IsOpen)
                            {
                                Console.WriteLine("Main comport shut, swapping to other mav");
                                break;
                            }
                        }

                        System.Threading.Thread.Sleep(100);
                    }


                    if (comPort.BaseStream.IsOpen && comPort.BaseStream.BytesToRead > 0)
                        comPort.readPacket();

                    // update currentstate of sysids on the port
                    try
                    {
                        comPort.MAV.cs.UpdateCurrentSettings(null, false, comPort, comPort.MAV);
                    }
                    catch { }
                }
                catch { };

            }
        }

        bool isPlanMode = false;

        internal PointLatLng MouseDownStart;

        private void gMapControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isPlanMode)
                MouseDownStart = gMapControl1.FromLocalToLatLng(e.X, e.Y);
        }

        private void gMapControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !isPlanMode)
            {
                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);

                double latdif = MouseDownStart.Lat - point.Lat;
                double lngdif = MouseDownStart.Lng - point.Lng;

                try
                {
                    gMapControl1.Position = new PointLatLng(gMapControl1.Position.Lat + latdif, gMapControl1.Position.Lng + lngdif);
                }
                catch { }
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            comPort.giveComport = false;
            string comPortName = "COM4";
            if (this.comboBoxComPort.Text != "")
                comPortName = this.comboBoxComPort.Text;
            string bandrate = "115200";
            if (this.comboBoxBoundrate.Text != "")
                bandrate = comboBoxBoundrate.Text;

            if (comPort.BaseStream.IsOpen && comPort.MAV.cs.groundspeed > 4)
            {
                if (DialogResult.No == CustomMessageBox.Show(Strings.Stillmoving, Strings.Disconnect, MessageBoxButtons.YesNo))
                {
                    return;
                }
            }

            if (comPort.BaseStream.IsOpen)
            {
                doDisconnect(comPort);
            }
            else
            {
                doConnect(comPort, comPortName, bandrate);
            }
        }

        public void doConnect(MAVLinkInterface comPort, string port, string baud)
        {
            bool skipconnectcheck = true;
            comPort.BaseStream = new MissionPlanner.Comms.SerialPort();

            comPort.BaseStream.PortName = port;
            try
            {
                comPort.BaseStream.BaudRate = int.Parse(baud);
            }
            catch { };
            comPort.Open(false, skipconnectcheck);

            // create a copy
            int[] list = comPort.sysidseen.ToArray();

            comPort.GetParam("MIS_TOTAL");
        }
        public void doDisconnect(MAVLinkInterface comPort)
        {
            try
            {
                comPort.BaseStream.DtrEnable = false;
                comPort.Close();
            }
            catch
            {
            }
        }

    }
}
