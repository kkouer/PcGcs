using GMap.NET.MapProviders;
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
                    catch (Exception ex) { }
                }
                catch { };

            }
        }
    }
}
