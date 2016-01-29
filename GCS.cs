using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using log4net;
using MissionPlanner.Comms;
using MissionPlanner.Controls;
using MissionPlanner.Controls.Waypoints;
using MissionPlanner.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace MissionPlanner
{
    public partial class GCS : Form
    {
        Thread thisthread;
        Thread serialreaderthread;
        bool serialThread = false;
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public static MAVLinkInterface comPort = new MAVLinkInterface();
        Hashtable param = new Hashtable();
        public List<PointLatLngAlt> pointlist = new List<PointLatLngAlt>(); // used to calc distance
        public List<PointLatLngAlt> fullpointlist = new List<PointLatLngAlt>();
        List<int> groupmarkers = new List<int>();
        public GMapRoute homeroute = new GMapRoute("home route");
        public static GMapOverlay polygonsoverlay; // where the track is drawn
        GMapMarkerRect CurentRectMarker;
        public static GMapOverlay objectsoverlay; // where the markers a drawn

        int selectedrow;
        GMapMarker CurrentGMapMarker;
        GMapMarker currentMarker;
        GMapMarker center = new GMarkerGoogle(new PointLatLng(0.0, 0.0), GMarkerGoogleType.none);
        bool isMouseClickOffMenu;
        bool isMouseDown;
        bool isMouseDraging;
        bool splinemode;
        internal PointLatLng MouseDownEnd;
        List<List<Locationwp>> history = new List<List<Locationwp>>();

        public bool quickadd;

        PointLatLngAlt mouseposdisplay = new PointLatLngAlt(0, 0);

        public GCS()
        {
            InitializeComponent();

            //config map
            gMapControl1.CacheLocation = Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + "mapCache" + Path.DirectorySeparatorChar;
            gMapControl1.MapProvider = GMapProviders.AMap;
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 4;
            gMapControl1.Position = new PointLatLng(36, 103);

            // setup main serial reader
            serialreaderthread = new Thread(SerialReader)
            {
                IsBackground = true,
                Name = "Main Serial reader",
                //Priority = ThreadPriority.BelowNormal
                Priority = ThreadPriority.AboveNormal
            };
            serialreaderthread.Start();

            thisthread = new Thread(mainloop)
            {
                Name = "Mainloop",
                IsBackground = true,
                // Priority = ThreadPriority.BelowNormal
            };
            thisthread.Start();


            //初始化端口控件
            this.comboBoxComPort.Items.AddRange(SerialPort.GetPortNames());
            comboBoxBoundrate.SelectedIndex = 0;

            // setup guids for droneshare
            if (!MainV2.config.ContainsKey("plane_guid"))
                MainV2.config["plane_guid"] = Guid.NewGuid().ToString();

            if (!MainV2.config.ContainsKey("copter_guid"))
                MainV2.config["copter_guid"] = Guid.NewGuid().ToString();

            if (!MainV2.config.ContainsKey("rover_guid"))
                MainV2.config["rover_guid"] = Guid.NewGuid().ToString();

            RegeneratePolygon();
            updateCMDParams();

            //map events
            gMapControl1.MouseUp += MainMap_MouseUp;
            gMapControl1.MouseDown += MainMap_MouseDown;
            gMapControl1.MouseMove += MainMap_MouseMove;
            gMapControl1.OnMarkerEnter += MainMap_OnMarkerEnter;
            gMapControl1.OnMarkerClick += MainMap_OnMarkerClick;
            gMapControl1.OnMarkerLeave += MainMap_OnMarkerLeave;
            gMapControl1.RoutesEnabled = true;


            currentMarker = new GMarkerGoogle(gMapControl1.Position, GMarkerGoogleType.red);


            routesoverlay = new GMapOverlay("routes");
            gMapControl1.Overlays.Add(routesoverlay);

            polygonsoverlay = new GMapOverlay("polygons");
            gMapControl1.Overlays.Add(polygonsoverlay);

            //airportsoverlay = new GMapOverlay("airports");
            //MainMap.Overlays.Add(airportsoverlay);

            objectsoverlay = new GMapOverlay("objects");
            gMapControl1.Overlays.Add(objectsoverlay);

            drawnpolygonsoverlay = new GMapOverlay("drawnpolygons");
            gMapControl1.Overlays.Add(drawnpolygonsoverlay);

            gMapControl1.Overlays.Add(poioverlay);

            //setup drawnpolgon
            List<PointLatLng> polygonPoints2 = new List<PointLatLng>();
            drawnpolygon = new GMapPolygon(polygonPoints2, "drawnpoly");
            drawnpolygon.Stroke = new Pen(Color.Red, 2);
            drawnpolygon.Fill = Brushes.Transparent;

            updateCMDParams();
        }


        void MainMap_OnMarkerEnter(GMapMarker item)
        {
            if (!isMouseDown)
            {
                if (item is GMapMarkerRect)
                {
                    GMapMarkerRect rc = item as GMapMarkerRect;
                    rc.Pen.Color = Color.Red;
                    gMapControl1.Invalidate(false);

                    int answer;
                    if (item.Tag != null && rc.InnerMarker != null && int.TryParse(rc.InnerMarker.Tag.ToString(), out answer))
                    {
                        try
                        {
                            Commands.CurrentCell = Commands[0, answer - 1];
                            item.ToolTipText = "高度: " + Commands[Alt.Index, answer - 1].Value;
                            item.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        }
                        catch { }
                    }

                    CurentRectMarker = rc;
                }
                if (item is GMapMarkerRallyPt)
                {
                    CurrentRallyPt = item as GMapMarkerRallyPt;
                }
                if (item is GMapMarkerAirport)
                {
                    // do nothing - readonly
                    return;
                }
                if (item is GMapMarker)
                {
                    CurrentGMapMarker = item;
                }
            }
        }


        void MainMap_OnMarkerLeave(GMapMarker item)
        {
            if (!isMouseDown)
            {
                if (item is GMapMarkerRect)
                {
                    CurentRectMarker = null;
                    GMapMarkerRect rc = item as GMapMarkerRect;
                    rc.ResetColor();
                    gMapControl1.Invalidate(false);
                }
                if (item is GMapMarkerRallyPt)
                {
                    CurrentRallyPt = null;
                }
                if (item is GMapMarker)
                {
                    // when you click the context menu this triggers and causes problems
                    CurrentGMapMarker = null;
                }

            }
        }


        // click on some marker
        void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            int answer;
            try // when dragging item can sometimes be null
            {
                if (item.Tag == null)
                {
                    // home.. etc
                    return;
                }

                if (ModifierKeys == Keys.Control)
                {
                    try
                    {
                        groupmarkeradd(item);

                        //log.Info("add marker to group");
                    }
                    catch { }
                }
                if (int.TryParse(item.Tag.ToString(), out answer))
                {

                    Commands.CurrentCell = Commands[0, answer - 1];
                }
            }
            catch { }
        }

        

        void MainMap_MouseDown(object sender, MouseEventArgs e)
        {
            //在规划模式下生效
            if (isPlanMode)
            {
                if (isMouseClickOffMenu)
                    return;
                MouseDownStart = gMapControl1.FromLocalToLatLng(e.X, e.Y);


                if (e.Button == MouseButtons.Left && (groupmarkers.Count > 0 || ModifierKeys == Keys.Control))
                {
                    isMouseDown = true;
                    isMouseDraging = false;

                    if (currentMarker.IsVisible)
                        currentMarker.Position = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                }


                if (e.Button == MouseButtons.Left && ModifierKeys != Keys.Alt && ModifierKeys != Keys.Control)
                {
                    isMouseDown = true;
                    isMouseDraging = false;

                    if (currentMarker.IsVisible)
                    {
                        currentMarker.Position = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                    }
                }
            }
        }


        /// <summary>
        /// Used for current mouse position
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <param name="alt"></param>
        public void SetMouseDisplay(double lat, double lng, int alt)
        {
            mouseposdisplay.Lat = lat;
            mouseposdisplay.Lng = lng;
            mouseposdisplay.Alt = alt;

            coords1.Lat = mouseposdisplay.Lat;
            coords1.Lng = mouseposdisplay.Lng;
            coords1.Alt = srtm.getAltitude(mouseposdisplay.Lat, mouseposdisplay.Lng, gMapControl1.Zoom).alt;

            try
            {
                PointLatLng last;

                if (pointlist[pointlist.Count - 1] == null)
                    return;

                last = pointlist[pointlist.Count - 1];

                double lastdist = gMapControl1.MapProvider.Projection.GetDistance(last, currentMarker.Position);

                double lastbearing = 0;

                if (pointlist.Count > 0)
                {
                    lastbearing = gMapControl1.MapProvider.Projection.GetBearing(last, currentMarker.Position);
                }

                //lbl_prevdist.Text = rm.GetString("lbl_prevdist.Text") + ": " + FormatDistance(lastdist, true) + " AZ: " + lastbearing.ToString("0");

                // 0 is home
                if (pointlist[0] != null)
                {
                    double homedist = gMapControl1.MapProvider.Projection.GetDistance(currentMarker.Position, pointlist[0]);

                    //lbl_homedist.Text = rm.GetString("lbl_homedist.Text") + ": " + FormatDistance(homedist, true);
                }
            }
            catch { }
        }

        DateTime lastscreenupdate = DateTime.Now;
        object updateBindingSourcelock = new object();
        volatile int updateBindingSourcecount;

        GMapMarkerRallyPt CurrentRallyPt;

        void MainMap_MouseMove(object sender, MouseEventArgs e)
        {
            //在规划模式下生效
            if (isPlanMode)
            {
                PointLatLngAlt point = gMapControl1.FromLocalToLatLng(e.X, e.Y);

                if (MouseDownStart == point)
                    return;

                currentMarker.Position = point;

                if (!isMouseDown)
                {
                    SetMouseDisplay(point.Lat, point.Lng, 0);
                }
                //draging
                if (e.Button == MouseButtons.Left && isMouseDown)
                {
                    isMouseDraging = true;
                    if (CurrentRallyPt != null)
                    {
                        PointLatLng pnew = gMapControl1.FromLocalToLatLng(e.X, e.Y);

                        CurrentRallyPt.Position = pnew;
                    }
                    else if (groupmarkers.Count > 0)
                    {
                        // group drag

                        double latdif = MouseDownStart.Lat - point.Lat;
                        double lngdif = MouseDownStart.Lng - point.Lng;

                        MouseDownStart = point;

                        Hashtable seen = new Hashtable();

                        foreach (var markerid in groupmarkers)
                        {
                            if (seen.ContainsKey(markerid))
                                continue;

                            seen[markerid] = 1;
                            for (int a = 0; a < objectsoverlay.Markers.Count; a++)
                            {
                                var marker = objectsoverlay.Markers[a];

                                if (marker.Tag != null && marker.Tag.ToString() == markerid.ToString())
                                {
                                    var temp = new PointLatLng(marker.Position.Lat, marker.Position.Lng);
                                    temp.Offset(latdif, -lngdif);
                                    marker.Position = temp;
                                }
                            }
                        }
                    }
                    else if (CurentRectMarker != null) // left click pan
                    {
                        try
                        {
                            // check if this is a grid point
                            if (CurentRectMarker.InnerMarker.Tag.ToString().Contains("grid"))
                            {
                                drawnpolygon.Points[int.Parse(CurentRectMarker.InnerMarker.Tag.ToString().Replace("grid", "")) - 1] = new PointLatLng(point.Lat, point.Lng);
                                gMapControl1.UpdatePolygonLocalPosition(drawnpolygon);
                                gMapControl1.Invalidate();
                            }
                        }
                        catch { }

                        PointLatLng pnew = gMapControl1.FromLocalToLatLng(e.X, e.Y);

                        // adjust polyline point while we drag
                        try
                        {
                            if (CurrentGMapMarker != null && CurrentGMapMarker.Tag is int)
                            {

                                int? pIndex = (int?)CurentRectMarker.Tag;
                                if (pIndex.HasValue)
                                {
                                    if (pIndex < wppolygon.Points.Count)
                                    {
                                        wppolygon.Points[pIndex.Value] = pnew;
                                        lock (thisLock)
                                        {
                                            gMapControl1.UpdatePolygonLocalPosition(wppolygon);
                                        }
                                    }
                                }
                            }
                        }
                        catch { }

                        // update rect and marker pos.
                        if (currentMarker.IsVisible)
                        {
                            currentMarker.Position = pnew;
                        }
                        CurentRectMarker.Position = pnew;

                        if (CurentRectMarker.InnerMarker != null)
                        {
                            CurentRectMarker.InnerMarker.Position = pnew;
                        }
                    }
                    else if (CurrentGMapMarker != null)
                    {
                        PointLatLng pnew = gMapControl1.FromLocalToLatLng(e.X, e.Y);

                        CurrentGMapMarker.Position = pnew;
                    }
                }
            }
        }


        void groupmarkeradd(GMapMarker marker)
        {
            groupmarkers.Add(int.Parse(marker.Tag.ToString()));
            if (marker is GMapMarkerWP)
            {
                ((GMapMarkerWP)marker).selected = true;
            }
            if (marker is GMapMarkerRect)
            {
                ((GMapMarkerWP)((GMapMarkerRect)marker).InnerMarker).selected = true;
            }
        }
        bool polygongridmode;
        altmode currentaltmode = altmode.Relative;
        bool sethome;
        GMapOverlay top;
        GMapOverlay drawnpolygonsoverlay;
        /// <summary>
        /// Used to create a new WP
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <param name="alt"></param>
        public void AddWPToMap(double lat, double lng, int alt)
        {
            if (polygongridmode)
            {
                addPolygonPointToolStripMenuItem_Click(null, null);
                return;
            }

            if (sethome)
            {
                sethome = false;
                callMeDrag("H", lat, lng, alt);
                return;
            }
            // creating a WP

            selectedrow = Commands.Rows.Add();

            if (splinemode)
            {
                Commands.Rows[selectedrow].Cells[Command.Index].Value = MAVLink.MAV_CMD.SPLINE_WAYPOINT.ToString();
                ChangeColumnHeader(MAVLink.MAV_CMD.SPLINE_WAYPOINT.ToString());
            }
            else
            {
                Commands.Rows[selectedrow].Cells[Command.Index].Value = MAVLink.MAV_CMD.WAYPOINT.ToString();
                ChangeColumnHeader(MAVLink.MAV_CMD.WAYPOINT.ToString());
            }

            setfromMap(lat, lng, alt);
        }


        /// <summary>
        /// Actualy Sets the values into the datagrid and verifys height if turned on
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <param name="alt"></param>
        public void setfromMap(double lat, double lng, int alt, double p1 = 0)
        {
            if (selectedrow > Commands.RowCount)
            {
                CustomMessageBox.Show("Invalid coord, How did you do this?");
                return;
            }

            // add history
            history.Add(GetCommandList());

            // remove more than 20 revisions
            if (history.Count > 20)
            {
                history.RemoveRange(0, history.Count - 20);
            }

            DataGridViewTextBoxCell cell;
            if (Commands.Columns[Lat.Index].HeaderText.Equals(cmdParamNames["WAYPOINT"][4]/*"Lat"*/))
            {
                cell = Commands.Rows[selectedrow].Cells[Lat.Index] as DataGridViewTextBoxCell;
                cell.Value = lat.ToString("0.0000000");
                cell.DataGridView.EndEdit();
            }
            if (Commands.Columns[Lon.Index].HeaderText.Equals(cmdParamNames["WAYPOINT"][5]/*"Long"*/))
            {
                cell = Commands.Rows[selectedrow].Cells[Lon.Index] as DataGridViewTextBoxCell;
                cell.Value = lng.ToString("0.0000000");
                cell.DataGridView.EndEdit();
            }
            if (alt != -1 && Commands.Columns[Alt.Index].HeaderText.Equals(cmdParamNames["WAYPOINT"][6]/*"Alt"*/))
            {
                cell = Commands.Rows[selectedrow].Cells[Alt.Index] as DataGridViewTextBoxCell;

                {
                    double result;
                    bool pass = double.TryParse(TXT_homealt.Text, out result);

                    if (pass == false)
                    {
                        CustomMessageBox.Show("输入回家高度");
                        string homealt = "100";
                        if (DialogResult.Cancel == InputBox.Show("Home Alt", "Home Altitude", ref homealt))
                            return;
                        TXT_homealt.Text = homealt;
                    }
                    int results1;
                    if (!int.TryParse(TXT_DefaultAlt.Text, out results1))
                    {
                        CustomMessageBox.Show("Your default alt is not valid");
                        return;
                    }

                    if (results1 == 0)
                    {
                        string defalt = "100";
                        if (DialogResult.Cancel == InputBox.Show("默认高度", "默认高度", ref defalt))
                            return;
                        TXT_DefaultAlt.Text = defalt;
                    }
                }

                cell.Value = TXT_DefaultAlt.Text;

                float ans;
                if (float.TryParse(cell.Value.ToString(), out ans))
                {
                    ans = (int)ans;
                    if (alt != 0) // use passed in value;
                        cell.Value = alt.ToString();
                    if (ans == 0) // default
                        cell.Value = 50;
                    if (ans == 0 && (comPort.MAV.cs.firmware == MainV2.Firmwares.ArduCopter2))
                        cell.Value = 15;
                    writeKML();
                    cell.DataGridView.EndEdit();
                }
                else
                {
                    CustomMessageBox.Show("Invalid Home or wp Alt");
                    cell.Style.BackColor = Color.Red;
                }

            }
            // Add more for other params
            if (Commands.Columns[Param1.Index].HeaderText.Equals(cmdParamNames["WAYPOINT"][1]/*"Delay"*/))
            {
                cell = Commands.Rows[selectedrow].Cells[Param1.Index] as DataGridViewTextBoxCell;
                cell.Value = p1;
                cell.DataGridView.EndEdit();
            }

            writeKML();
            Commands.EndEdit();
        }
        

        private void ChangeColumnHeader(string command)
        {
            try
            {
                if (cmdParamNames.ContainsKey(command))
                    for (int i = 1; i <= 7; i++)
                        Commands.Columns[i].HeaderText = cmdParamNames[command][i - 1];
                else
                    for (int i = 1; i <= 7; i++)
                        Commands.Columns[i].HeaderText = "setme";
            }
            catch (Exception ex) { CustomMessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// used to adjust existing point in the datagrid including "H"
        /// </summary>
        /// <param name="pointno"></param>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <param name="alt"></param>
        public void callMeDrag(string pointno, double lat, double lng, int alt)
        {
            if (pointno == "")
            {
                return;
            }

            // dragging a WP
            if (pointno == "H")
            {
                TXT_homelat.Text = lat.ToString();
                TXT_homelng.Text = lng.ToString();
                return;
            }

            if (pointno == "Tracker Home")
            {
                comPort.MAV.cs.TrackerLocation = new PointLatLngAlt(lat, lng, alt, "");
                return;
            }

            try
            {
                selectedrow = int.Parse(pointno) - 1;
                Commands.CurrentCell = Commands[1, selectedrow];
            }
            catch
            {
                return;
            }

            setfromMap(lat, lng, alt);
        }

        private void addPolygonPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (polygongridmode == false)
            {
                CustomMessageBox.Show("开始规划模式,清除规划区域后结束规划模式.");
            }

            polygongridmode = true;

            List<PointLatLng> polygonPoints = new List<PointLatLng>();
            if (drawnpolygonsoverlay.Polygons.Count == 0)
            {
                drawnpolygon.Points.Clear();
                drawnpolygonsoverlay.Polygons.Add(drawnpolygon);
            }

            drawnpolygon.Fill = Brushes.Transparent;

            // remove full loop is exists
            if (drawnpolygon.Points.Count > 1 && drawnpolygon.Points[0] == drawnpolygon.Points[drawnpolygon.Points.Count - 1])
                drawnpolygon.Points.RemoveAt(drawnpolygon.Points.Count - 1); // unmake a full loop

            drawnpolygon.Points.Add(new PointLatLng(MouseDownStart.Lat, MouseDownStart.Lng));

            addpolygonmarkergrid(drawnpolygon.Points.Count.ToString(), MouseDownStart.Lng, MouseDownStart.Lat, 0);

            gMapControl1.UpdatePolygonLocalPosition(drawnpolygon);

            gMapControl1.Invalidate();

        }

        private void addpolygonmarkergrid(string tag, double lng, double lat, int alt)
        {
            try
            {
                PointLatLng point = new PointLatLng(lat, lng);
                GMarkerGoogle m = new GMarkerGoogle(point, GMarkerGoogleType.red);
                m.ToolTipMode = MarkerTooltipMode.Never;
                m.ToolTipText = "grid" + tag;
                m.Tag = "grid" + tag;

                //MissionPlanner.GMapMarkerRectWPRad mBorders = new MissionPlanner.GMapMarkerRectWPRad(point, (int)float.Parse(TXT_WPRad.Text), MainMap);
                GMapMarkerRect mBorders = new GMapMarkerRect(point);
                {
                    mBorders.InnerMarker = m;
                }

                drawnpolygonsoverlay.Markers.Add(m);
                drawnpolygonsoverlay.Markers.Add(mBorders);
            }
            catch (Exception ex)
            {
                log.Info(ex.ToString());
            }
        }

        void MainMap_MouseUp(object sender, MouseEventArgs e)
        {
            //在规划模式下生效
            if (isPlanMode)
            {
                if (isMouseClickOffMenu)
                {
                    isMouseClickOffMenu = false;
                    return;
                }
                MouseDownEnd = gMapControl1.FromLocalToLatLng(e.X, e.Y);

                if (e.Button == MouseButtons.Right)
                {
                    return;
                }
                if (isMouseDown)
                {
                    if (e.Button == MouseButtons.Left)
                        isMouseDown = false;

                    if (ModifierKeys == Keys.Control)
                    {
                        // group select wps
                        GMapPolygon poly = new GMapPolygon(new List<PointLatLng>(), "temp");

                        poly.Points.Add(MouseDownStart);
                        poly.Points.Add(new PointLatLng(MouseDownStart.Lat, MouseDownEnd.Lng));
                        poly.Points.Add(MouseDownEnd);
                        poly.Points.Add(new PointLatLng(MouseDownEnd.Lat, MouseDownStart.Lng));

                        foreach (var marker in objectsoverlay.Markers)
                        {
                            if (poly.IsInside(marker.Position))
                            {
                                try
                                {
                                    if (marker.Tag != null)
                                    {
                                        groupmarkeradd(marker);
                                    }
                                }
                                catch { }
                            }
                        }

                        isMouseDraging = false;
                        return;
                    }
                }
                if (!isMouseDraging)
                {
                    if (CurentRectMarker != null)
                    {

                    }
                    else
                    {
                        AddWPToMap(currentMarker.Position.Lat, currentMarker.Position.Lng, 0);
                    }
                }
                else
                {
                    if (groupmarkers.Count > 0)
                    {
                        Dictionary<string, PointLatLng> dest = new Dictionary<string, PointLatLng>();

                        foreach (var markerid in groupmarkers)
                        {
                            for (int a = 0; a < objectsoverlay.Markers.Count; a++)
                            {
                                var marker = objectsoverlay.Markers[a];

                                if (marker.Tag != null && marker.Tag.ToString() == markerid.ToString())
                                {
                                    dest[marker.Tag.ToString()] = marker.Position;
                                    break;
                                }
                            }
                        }

                        foreach (KeyValuePair<string, PointLatLng> item in dest)
                        {
                            var value = item.Value;
                            callMeDrag(item.Key, value.Lat, value.Lng, -1);
                        }

                        gMapControl1.SelectedArea = RectLatLng.Empty;
                        groupmarkers.Clear();
                        // redraw to remove selection
                        writeKML();

                        CurentRectMarker = null;
                    }
                    if (CurentRectMarker != null)
                    {
                        if (CurentRectMarker.InnerMarker.Tag.ToString().Contains("grid"))
                        {
                            try
                            {
                                drawnpolygon.Points[int.Parse(CurentRectMarker.InnerMarker.Tag.ToString().Replace("grid", "")) - 1] = new PointLatLng(MouseDownEnd.Lat, MouseDownEnd.Lng);
                                gMapControl1.UpdatePolygonLocalPosition(drawnpolygon);
                                gMapControl1.Invalidate();
                            }
                            catch { }
                        }
                        else
                        {
                            callMeDrag(CurentRectMarker.InnerMarker.Tag.ToString(), currentMarker.Position.Lat, currentMarker.Position.Lng, -1);
                        }
                        CurentRectMarker = null;
                    }
                }
            }
            isMouseDraging = false;
        }


        // polygons
        GMapPolygon wppolygon;
        internal GMapPolygon drawnpolygon;
        GMapPolygon geofencepolygon;
        public static GMapOverlay routesoverlay;// static so can update from gcs

        public static GMapOverlay poioverlay = new GMapOverlay("POI"); // poi layer
        public bool autopan { get; set; }

        DateTime mapupdate = DateTime.MinValue;

        static GMapOverlay rallypointoverlay;

        private DateTime heatbeatSend = DateTime.Now;

        private Dictionary<string, string[]> cmdParamNames = new Dictionary<string, string[]>();


        Dictionary<string, string[]> readCMDXML()
        {
            Dictionary<string, string[]> cmd = new Dictionary<string, string[]>();

            // do lang stuff here

            string file = Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + "mavcmd.xml";

            if (!File.Exists(file))
            {
                CustomMessageBox.Show("Missing mavcmd.xml file");
                return cmd;
            }

            using (XmlReader reader = XmlReader.Create(file))
            {
                reader.Read();
                reader.ReadStartElement("CMD");
                if (comPort.MAV.cs.firmware == MainV2.Firmwares.ArduPlane || comPort.MAV.cs.firmware == MainV2.Firmwares.Ateryx)
                {
                    reader.ReadToFollowing("APM");
                }
                else if (comPort.MAV.cs.firmware == MainV2.Firmwares.ArduRover)
                {
                    reader.ReadToFollowing("APRover");
                }
                else
                {
                    reader.ReadToFollowing("AC2");
                }

                XmlReader inner = reader.ReadSubtree();

                inner.Read();

                inner.MoveToElement();

                inner.Read();

                while (inner.Read())
                {
                    inner.MoveToElement();
                    if (inner.IsStartElement())
                    {
                        string cmdname = inner.Name;
                        string[] cmdarray = new string[7];
                        int b = 0;

                        XmlReader inner2 = inner.ReadSubtree();

                        inner2.Read();

                        while (inner2.Read())
                        {
                            inner2.MoveToElement();
                            if (inner2.IsStartElement())
                            {
                                cmdarray[b] = inner2.ReadString();
                                b++;
                            }
                        }

                        cmd[cmdname] = cmdarray;
                    }
                }
            }

            return cmd;
        }

        void updateCMDParams()
        {
            cmdParamNames = readCMDXML();

            List<string> cmds = new List<string>();

            foreach (string item in cmdParamNames.Keys)
            {
                cmds.Add(item);
            }

            cmds.Add("UNKNOWN");

            Command.DataSource = cmds;
        }
        static public Object thisLock = new Object();

        /// <summary>
        /// used to redraw the polygon
        /// </summary>
        void RegeneratePolygon()
        {
            List<PointLatLng> polygonPoints = new List<PointLatLng>();

            if (objectsoverlay == null)
                return;

            foreach (GMapMarker m in objectsoverlay.Markers)
            {
                if (m is GMapMarkerRect)
                {
                    if (m.Tag == null)
                    {
                        m.Tag = polygonPoints.Count;
                        polygonPoints.Add(m.Position);
                    }
                }
            }

            if (wppolygon == null)
            {
                wppolygon = new GMapPolygon(polygonPoints, "polygon test");
                polygonsoverlay.Polygons.Add(wppolygon);
            }
            else
            {
                wppolygon.Points.Clear();
                wppolygon.Points.AddRange(polygonPoints);

                wppolygon.Stroke = new Pen(Color.Yellow, 4);
                wppolygon.Stroke.DashStyle = DashStyle.Custom;
                wppolygon.Fill = Brushes.Transparent;

                if (polygonsoverlay.Polygons.Count == 0)
                {
                    polygonsoverlay.Polygons.Add(wppolygon);
                }
                else
                {
                    lock (thisLock)
                    {
                        gMapControl1.UpdatePolygonLocalPosition(wppolygon);
                    }
                }
            }
        }

        public static bool threadrun;
        void mainloop()
        {
            threadrun = true;

            while (threadrun)
            {
                if (comPort.giveComport)
                {
                    Thread.Sleep(50);
                    continue;
                }
                if (!comPort.logreadmode)
                    Thread.Sleep(50); // max is only ever 10 hz but we go a little faster to empty the serial queue
                try
                {
                    if (comPort.BaseStream.IsOpen)
                        updateBindingSource();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Main Loop exception " + ex);
                }

            }
        }

        private void updateBindingSource()
        {
            if (lastscreenupdate.AddMilliseconds(40) < DateTime.Now)
            {
                if (updateBindingSourcecount > 0)
                {
                    return;
                }

                lock (updateBindingSourcelock)
                {
                    updateBindingSourcecount++;
                }

                BeginInvoke((MethodInvoker)delegate
                {
                    try
                    {
                        comPort.MAV.cs.UpdateCurrentSettings(bindingSourceHud, false, comPort, comPort.MAV);

                        comPort.MAV.cs.UpdateCurrentSettings(bindingSourceState, false, comPort, comPort.MAV);
                        //更新回家距离
                        //UpdateDistanceStats();
                    }
                    catch { }
                    lock (updateBindingSourcelock)
                    {
                        updateBindingSourcecount--;
                    }
                });


            }
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

        private void buttonHideInfoPanel_Click(object sender, EventArgs e)
        {
            this.panelInofPanel.Visible = false;
        }

        private void buttonShowPanel_Click(object sender, EventArgs e)
        {
            this.panelInofPanel.Visible = true;
        }

        private void buttonHideCommandPanel_Click(object sender, EventArgs e)
        {
            this.panelCommand.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panelCommand.Visible = true;
        }

        private void comboBoxComPort_Click(object sender, EventArgs e)
        {
            this.comboBoxComPort.Items.Clear();
            this.comboBoxComPort.Items.AddRange(SerialPort.GetPortNames());
        }

        private void buttonArmed_Click(object sender, EventArgs e)
        {
            if (!comPort.BaseStream.IsOpen)
                return;
            // arm the MAV
            try
            {
                if (!comPort.MAV.cs.armed)
                    if (CustomMessageBox.Show("确定解锁?", "解锁?", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;

                bool ans = comPort.doARM(true);
                if (ans == false)
                    CustomMessageBox.Show(Strings.ErrorRejectedByMAV, Strings.ERROR);
            }
            catch { CustomMessageBox.Show(Strings.ErrorNoResponce, Strings.ERROR); }
        }

        private void buttonDisarmed_Click(object sender, EventArgs e)
        {
            if (comPort.BaseStream.IsOpen)
                return;
            // arm the MAV
            try
            {
                if (!comPort.MAV.cs.armed)
                    if (CustomMessageBox.Show("确定加锁?", "加锁?", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;

                bool ans = comPort.doARM(false);
                if (ans == false)
                    CustomMessageBox.Show(Strings.ErrorRejectedByMAV, Strings.ERROR);
            }
            catch { CustomMessageBox.Show(Strings.ErrorNoResponce, Strings.ERROR); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comPort.setMode("guided");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comPort.setMode("loiter");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comPort.setMode("auto");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comPort.setMode("rtl");
        }
        private void TXT_homelat_TextChanged(object sender, EventArgs e)
        {
            sethome = false;
            try
            {
                comPort.MAV.cs.HomeLocation.Lat = double.Parse(TXT_homelat.Text);
            }
            catch { }
            writeKML();
        }

        private void TXT_homelng_TextChanged(object sender, EventArgs e)
        {
            sethome = false;
            try
            {
                comPort.MAV.cs.HomeLocation.Lng = double.Parse(TXT_homelng.Text);
            }
            catch { }
            writeKML();
        }

        private void TXT_homealt_TextChanged(object sender, EventArgs e)
        {
            sethome = false;
            try
            {
                comPort.MAV.cs.HomeLocation.Alt = double.Parse(TXT_homealt.Text);
            }
            catch { }
            writeKML();
        }

        private void TXT_homelat_Enter(object sender, EventArgs e)
        {
            sethome = true;
            CustomMessageBox.Show("在地图上点选回家点. ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Show("是否开始任务 ?", "开始任务", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ((Button)sender).Enabled = false;

                    int param1 = 0;
                    int param3 = 1;

                    comPort.doCommand(MAVLink.MAV_CMD.MISSION_START, param1, 0, param3, 0, 0, 0, 0);
                }
                catch { CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR); }
                ((Button)sender).Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < Commands.Rows.Count - 0; a++)
            {
                for (int b = 0; b < Commands.ColumnCount - 0; b++)
                {
                    double answer;
                    if (b >= 1 && b <= 7)
                    {
                        if (!double.TryParse(Commands[b, a].Value.ToString(), out answer))
                        {
                            CustomMessageBox.Show("There are errors in your mission");
                            return;
                        }
                    }

                    if (TXT_altwarn.Text == "")
                        TXT_altwarn.Text = (0).ToString();

                    if (Commands.Rows[a].Cells[Command.Index].Value.ToString().Contains("UNKNOWN"))
                        continue;

                    byte cmd = (byte)(int)Enum.Parse(typeof(MAVLink.MAV_CMD), Commands.Rows[a].Cells[Command.Index].Value.ToString(), false);

                    if (cmd < (byte)MAVLink.MAV_CMD.LAST && double.Parse(Commands[Alt.Index, a].Value.ToString()) < double.Parse(TXT_altwarn.Text))
                    {
                        if (cmd != (byte)MAVLink.MAV_CMD.TAKEOFF &&
                            cmd != (byte)MAVLink.MAV_CMD.LAND &&
                            cmd != (byte)MAVLink.MAV_CMD.RETURN_TO_LAUNCH)
                        {
                            CustomMessageBox.Show("Low alt on WP#" + (a + 1) + "\nPlease reduce the alt warning, or increase the altitude");
                            return;
                        }
                    }
                }
            }

            ProgressReporterDialogue frmProgressReporter = new ProgressReporterDialogue
            {
                StartPosition = FormStartPosition.CenterScreen,
                Text = "上传航点中"
            };

            frmProgressReporter.DoWork += saveWPs;
            frmProgressReporter.UpdateProgressAndStatus(-1, "上传航点中");

            //ThemeManager.ApplyThemeTo(frmProgressReporter);

            frmProgressReporter.RunBackgroundOperationAsync();

            frmProgressReporter.Dispose();

            gMapControl1.Focus();
        }
        public enum altmode
        {
            Relative = MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT,
            Absolute = MAVLink.MAV_FRAME.GLOBAL,
            Terrain = MAVLink.MAV_FRAME.GLOBAL_TERRAIN_ALT
        }
        void saveWPs(object sender, ProgressWorkerEventArgs e, object passdata = null)
        {
            try
            {
                MAVLinkInterface port = comPort;

                if (!port.BaseStream.IsOpen)
                {
                    //throw new Exception("Please connect first!");
                    throw new Exception("请先连接无人机!");
                }

                comPort.giveComport = true;
                int a = 0;

                // define the home point
                Locationwp home = new Locationwp();
                try
                {
                    home.id = (byte)MAVLink.MAV_CMD.WAYPOINT;
                    home.lat = (double.Parse(TXT_homelat.Text));
                    home.lng = (double.Parse(TXT_homelng.Text));
                    home.alt = (float.Parse(TXT_homealt.Text) / CurrentState.multiplierdist); // use saved home
                }
                catch { throw new Exception("Your home location is invalid"); }

                // log
                //log.Info("wps values " + comPort.MAV.wps.Values.Count);
                //log.Info("cmd rows " + (Commands.Rows.Count + 1)); // + home

                // check for changes / future mod to send just changed wp's
                if (comPort.MAV.wps.Values.Count == (Commands.Rows.Count + 1))
                {
                    Hashtable wpstoupload = new Hashtable();

                    a = -1;
                    foreach (var item in comPort.MAV.wps.Values)
                    {
                        // skip home
                        if (a == -1)
                        {
                            a++;
                            continue;
                        }

                        MAVLink.mavlink_mission_item_t temp = DataViewtoLocationwp(a);

                        if (temp.command == item.command &&
                            temp.x == item.x &&
                            temp.y == item.y &&
                            temp.z == item.z &&
                            temp.param1 == item.param1 &&
                            temp.param2 == item.param2 &&
                            temp.param3 == item.param3 &&
                            temp.param4 == item.param4
                            )
                        {
                            //log.Info("wp match " + (a + 1));
                        }
                        else
                        {
                            //log.Info("wp no match" + (a + 1));
                            wpstoupload[a] = "";
                        }

                        a++;
                    }
                }

                // set wp total
                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(0, "上传航点数量");

                ushort totalwpcountforupload = (ushort)(Commands.Rows.Count + 1);

                port.setWPTotal(totalwpcountforupload); // + home

                // set home location - overwritten/ignored depending on firmware.
                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(0, "上传回家点");

                var homeans = port.setWP(home, 0, MAVLink.MAV_FRAME.GLOBAL, 0);

                if (homeans != MAVLink.MAV_MISSION_RESULT.MAV_MISSION_ACCEPTED)
                {
                    CustomMessageBox.Show(Strings.ErrorRejectedByMAV, Strings.ERROR);
                    return;
                }

                // define the default frame.
                MAVLink.MAV_FRAME frame = MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT;

                // get the command list from the datagrid
                var commandlist = GetCommandList();

                // upload from wp1, as home is alreadey sent
                a = 1;
                // process commandlist to the mav
                foreach (var temp in commandlist)
                {
                    // this code below fails
                    //a = commandlist.IndexOf(temp) + 1;

                    ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(a * 100 / Commands.Rows.Count, "上传航点 " + a);

                    // make sure we are using the correct frame for these commands
                    if (temp.id < (byte)MAVLink.MAV_CMD.LAST || temp.id == (byte)MAVLink.MAV_CMD.DO_SET_HOME)
                    {
                        var mode = currentaltmode;

                        if (mode == altmode.Terrain)
                        {
                            frame = MAVLink.MAV_FRAME.GLOBAL_TERRAIN_ALT;
                        }
                        else if (mode == altmode.Absolute)
                        {
                            frame = MAVLink.MAV_FRAME.GLOBAL;
                        }
                        else
                        {
                            frame = MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT;
                        }
                    }

                    // try send the wp
                    MAVLink.MAV_MISSION_RESULT ans = port.setWP(temp, (ushort)(a), frame, 0);

                    // we timed out while uploading wps/ command wasnt replaced/ command wasnt added
                    if (ans == MAVLink.MAV_MISSION_RESULT.MAV_MISSION_ERROR)
                    {
                        // resend for partial upload
                        port.setWPPartialUpdate((ushort)(a), totalwpcountforupload);
                        // reupload this point.
                        ans = port.setWP(temp, (ushort)(a), frame, 0);
                    }

                    if (ans == MAVLink.MAV_MISSION_RESULT.MAV_MISSION_NO_SPACE)
                    {
                        //e.ErrorMessage = "Upload failed, please reduce the number of wp's";
                        e.ErrorMessage = "上传航点失败,航点数量太多,请减少航点数量.";
                        return;
                    }
                    if (ans == MAVLink.MAV_MISSION_RESULT.MAV_MISSION_INVALID)
                    {
                        e.ErrorMessage = "Upload failed, mission was rejected byt the Mav,\n item had a bad option wp# " + a + " " + ans;
                        return;
                    }
                    if (ans == MAVLink.MAV_MISSION_RESULT.MAV_MISSION_INVALID_SEQUENCE)
                    {
                        // invalid sequence can only occur if we failed to see a response from the apm when we sent the request.
                        // therefore it did see the request and has moved on that step, and so do we.
                        a++;
                        continue;
                    }
                    if (ans != MAVLink.MAV_MISSION_RESULT.MAV_MISSION_ACCEPTED)
                    {
                        //e.ErrorMessage = "Upload wps failed " + Enum.Parse(typeof(MAVLink.MAV_CMD), temp.id.ToString()) + " " + Enum.Parse(typeof(MAVLink.MAV_MISSION_RESULT), ans.ToString());
                        e.ErrorMessage = "上传失败 " + Enum.Parse(typeof(MAVLink.MAV_CMD), temp.id.ToString()) + " " + Enum.Parse(typeof(MAVLink.MAV_MISSION_RESULT), ans.ToString());
                        return;
                    }

                    a++;
                }

                port.setWPACK();

                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(95, "Setting params");

                // m
                port.setParam("WP_RADIUS", (byte)int.Parse(TXT_WPRad.Text) / CurrentState.multiplierdist);

                // cm's
                port.setParam("WPNAV_RADIUS", (byte)int.Parse(TXT_WPRad.Text) / CurrentState.multiplierdist * 100);

                try
                {
                    port.setParam(new[] { "LOITER_RAD", "WP_LOITER_RAD" }, int.Parse(TXT_loiterrad.Text) / CurrentState.multiplierdist);
                }
                catch
                {

                }

                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(100, "完成.");
            }
            catch (Exception ex)
            {
                log.Error(ex); comPort.giveComport = false; throw;
            }

            comPort.giveComport = false;
        }


        void getWPs(object sender, ProgressWorkerEventArgs e, object passdata = null)
        {
            List<Locationwp> cmds = new List<Locationwp>();

            try
            {
                MAVLinkInterface port = comPort;

                if (!port.BaseStream.IsOpen)
                {
                    throw new Exception("Please Connect First!");
                }

                comPort.giveComport = true;

                param = port.MAV.param;

                //log.Info("Getting WP #");

                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(0, "Getting WP count");

                int cmdcount = port.getWPCount();

                for (ushort a = 0; a < cmdcount; a++)
                {
                    if (((ProgressReporterDialogue)sender).doWorkArgs.CancelRequested)
                    {
                        ((ProgressReporterDialogue)sender).doWorkArgs.CancelAcknowledged = true;
                        throw new Exception("Cancel Requested");
                    }

                    //log.Info("Getting WP" + a);
                    ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(a * 100 / cmdcount, "下载航点 " + a);
                    cmds.Add(port.getWP(a));
                }

                port.setWPACK();

                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(100, "完成");

                //log.Info("Done");
            }
            catch { throw; }

            WPtoScreen(cmds);
        }
        public void WPtoScreen(List<Locationwp> cmds, bool withrally = true)
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        log.Info("Process " + cmds.Count);
                        processToScreen(cmds);
                    }
                    catch (Exception exx) { log.Info(exx.ToString()); }

                    comPort.giveComport = false;

                    writeKML();

                });
            }
            catch (Exception exx) { log.Info(exx.ToString()); }
        }

        /// <summary>
        /// used to add a marker to the map display
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="lng"></param>
        /// <param name="lat"></param>
        /// <param name="alt"></param>
        private void addpolygonmarker(string tag, double lng, double lat, int alt, Color? color)
        {
            try
            {
                PointLatLng point = new PointLatLng(lat, lng);
                GMapMarkerWP m = new GMapMarkerWP(point, tag);
                m.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                m.ToolTipText = "高度: " + alt.ToString("0");
                m.Tag = tag;

                try
                {
                    // preselect groupmarker
                    if (groupmarkers.Count > 0)
                        if (groupmarkers.Contains(int.Parse(tag)))
                            m.selected = true;
                }
                catch { }

                //MissionPlanner.GMapMarkerRectWPRad mBorders = new MissionPlanner.GMapMarkerRectWPRad(point, (int)float.Parse(TXT_WPRad.Text), MainMap);
                GMapMarkerRect mBorders = new GMapMarkerRect(point);
                {
                    mBorders.InnerMarker = m;
                    mBorders.Tag = tag;
                    mBorders.wprad = (int)(float.Parse(TXT_WPRad.Text) / CurrentState.multiplierdist);
                    if (color.HasValue)
                    {
                        mBorders.Color = color.Value;
                    }
                }

                objectsoverlay.Markers.Add(m);
                objectsoverlay.Markers.Add(mBorders);
            }
            catch (Exception) { }
        }

        void updateRowNumbers()
        {
            // number rows 
            Thread t1 = new Thread(delegate()
            {
                // thread for updateing row numbers
                for (int a = 0; a < Commands.Rows.Count - 0; a++)
                {
                    // this.BeginInvoke((MethodInvoker)delegate
                    {
                        try
                        {
                            if (Commands.Rows[a].HeaderCell.Value == null)
                            {
                                Commands.Rows[a].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                                Commands.Rows[a].HeaderCell.Value = (a + 1).ToString();
                            }
                            // skip rows with the correct number
                            string rowno = Commands.Rows[a].HeaderCell.Value.ToString();
                            if (!rowno.Equals((a + 1).ToString()))
                            {
                                // this code is where the delay is when deleting.
                                Commands.Rows[a].HeaderCell.Value = (a + 1).ToString();
                            }
                        }
                        catch (Exception) { }
                    }//);
                }
            });
            t1.Name = "Row number updater";
            t1.IsBackground = true;
            t1.Start();
        }

        /// <summary>
        /// used to control buttons in the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Commands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (e.ColumnIndex == Delete.Index && (e.RowIndex + 0) < Commands.RowCount) // delete
                {
                    quickadd = true;
                    Commands.Rows.RemoveAt(e.RowIndex);
                    quickadd = false;
                    writeKML();
                }
                if (e.ColumnIndex == Up.Index && e.RowIndex != 0) // up
                {
                    DataGridViewRow myrow = Commands.CurrentRow;
                    Commands.Rows.Remove(myrow);
                    Commands.Rows.Insert(e.RowIndex - 1, myrow);
                    writeKML();
                }
                if (e.ColumnIndex == Down.Index && e.RowIndex < Commands.RowCount - 1) // down
                {
                    DataGridViewRow myrow = Commands.CurrentRow;
                    Commands.Rows.Remove(myrow);
                    Commands.Rows.Insert(e.RowIndex + 1, myrow);
                    writeKML();
                }
                setgradanddistandaz();
            }
            catch (Exception)
            {
                CustomMessageBox.Show("Row error");
            }
        }

        /// <summary>
        /// used to write a KML, update the Map view polygon, and update the row headers
        /// </summary>
        public void writeKML()
        {
            // quickadd is for when loading wps from eeprom or file, to prevent slow, loading times
            if (quickadd)
                return;

            // this is to share the current mission with the data tab
            pointlist = new List<PointLatLngAlt>();

            fullpointlist.Clear();

            Debug.WriteLine(DateTime.Now);
            try
            {
                if (objectsoverlay != null) // hasnt been created yet
                {
                    objectsoverlay.Markers.Clear();
                }

                // process and add home to the list
                string home;
                if (TXT_homealt.Text != "" && TXT_homelat.Text != "" && TXT_homelng.Text != "")
                {
                    home = string.Format("{0},{1},{2}\r\n", TXT_homelng.Text, TXT_homelat.Text, TXT_DefaultAlt.Text);
                    if (objectsoverlay != null) // during startup
                    {
                        pointlist.Add(new PointLatLngAlt(double.Parse(TXT_homelat.Text), double.Parse(TXT_homelng.Text), (int)double.Parse(TXT_homealt.Text), "H"));
                        fullpointlist.Add(pointlist[pointlist.Count - 1]);
                        addpolygonmarker("H", double.Parse(TXT_homelng.Text), double.Parse(TXT_homelat.Text), 0, null);
                    }
                }
                else
                {
                    home = "";
                    pointlist.Add(null);
                    fullpointlist.Add(pointlist[pointlist.Count - 1]);
                }

                // setup for centerpoint calc etc.
                double avglat = 0;
                double avglong = 0;
                double maxlat = -180;
                double maxlong = -180;
                double minlat = 180;
                double minlong = 180;
                double homealt = 0;
                try
                {
                    if (!String.IsNullOrEmpty(TXT_homealt.Text))
                        homealt = (int)double.Parse(TXT_homealt.Text);
                }
                catch { }
                //if ((altmode)CMB_altmode.SelectedValue == altmode.Absolute)
                //{
                //    homealt = 0; // for absolute we dont need to add homealt
                //}

                int usable = 0;

                updateRowNumbers();

                long temp = Stopwatch.GetTimestamp();

                string lookat = "";
                for (int a = 0; a < Commands.Rows.Count - 0; a++)
                {
                    try
                    {
                        if (Commands.Rows[a].Cells[Command.Index].Value.ToString().Contains("UNKNOWN"))
                            continue;

                        int command = (byte)(int)Enum.Parse(typeof(MAVLink.MAV_CMD), Commands.Rows[a].Cells[Command.Index].Value.ToString(), false);
                        if (command < (byte)MAVLink.MAV_CMD.LAST &&
                            command != (byte)MAVLink.MAV_CMD.TAKEOFF &&
                            command != (byte)MAVLink.MAV_CMD.RETURN_TO_LAUNCH &&
                            command != (byte)MAVLink.MAV_CMD.CONTINUE_AND_CHANGE_ALT &&
                            command != (byte)MAVLink.MAV_CMD.GUIDED_ENABLE
                            || command == (byte)MAVLink.MAV_CMD.DO_SET_ROI)
                        {
                            string cell2 = Commands.Rows[a].Cells[Alt.Index].Value.ToString(); // alt
                            string cell3 = Commands.Rows[a].Cells[Lat.Index].Value.ToString(); // lat
                            string cell4 = Commands.Rows[a].Cells[Lon.Index].Value.ToString(); // lng

                            // land can be 0,0 or a lat,lng
                            if (command == (byte)MAVLink.MAV_CMD.LAND && cell3 == "0" && cell4 == "0")
                                continue;

                            if (cell4 == "?" || cell3 == "?")
                                continue;

                            if (command == (byte)MAVLink.MAV_CMD.DO_SET_ROI)
                            {
                                pointlist.Add(new PointLatLngAlt(double.Parse(cell3), double.Parse(cell4), (int)double.Parse(cell2) + homealt, "ROI" + (a + 1)) { color = Color.Red });
                                // do set roi is not a nav command. so we dont route through it
                                //fullpointlist.Add(pointlist[pointlist.Count - 1]);
                                GMarkerGoogle m = new GMarkerGoogle(new PointLatLng(double.Parse(cell3), double.Parse(cell4)), GMarkerGoogleType.red);
                                m.ToolTipMode = MarkerTooltipMode.Always;
                                m.ToolTipText = (a + 1).ToString();
                                m.Tag = (a + 1).ToString();

                                GMapMarkerRect mBorders = new GMapMarkerRect(m.Position);
                                {
                                    mBorders.InnerMarker = m;
                                    mBorders.Tag = "Dont draw line";
                                }

                                // check for clear roi, and hide it
                                if (m.Position.Lat != 0 && m.Position.Lng != 0)
                                {
                                    // order matters
                                    objectsoverlay.Markers.Add(m);
                                    objectsoverlay.Markers.Add(mBorders);
                                }
                            }
                            else if (command == (byte)MAVLink.MAV_CMD.LOITER_TIME || command == (byte)MAVLink.MAV_CMD.LOITER_TURNS || command == (byte)MAVLink.MAV_CMD.LOITER_UNLIM)
                            {
                                pointlist.Add(new PointLatLngAlt(double.Parse(cell3), double.Parse(cell4), (int)double.Parse(cell2) + homealt, (a + 1).ToString()) { color = Color.LightBlue });
                                fullpointlist.Add(pointlist[pointlist.Count - 1]);
                                addpolygonmarker((a + 1).ToString(), double.Parse(cell4), double.Parse(cell3), (int)double.Parse(cell2), Color.LightBlue);
                            }
                            else if (command == (byte)MAVLink.MAV_CMD.SPLINE_WAYPOINT)
                            {
                                pointlist.Add(new PointLatLngAlt(double.Parse(cell3), double.Parse(cell4), (int)double.Parse(cell2) + homealt, (a + 1).ToString()) { Tag2 = "spline" });
                                fullpointlist.Add(pointlist[pointlist.Count - 1]);
                                addpolygonmarker((a + 1).ToString(), double.Parse(cell4), double.Parse(cell3), (int)double.Parse(cell2), Color.Green);
                            }
                            else
                            {
                                pointlist.Add(new PointLatLngAlt(double.Parse(cell3), double.Parse(cell4), (int)double.Parse(cell2) + homealt, (a + 1).ToString()));
                                fullpointlist.Add(pointlist[pointlist.Count - 1]);
                                addpolygonmarker((a + 1).ToString(), double.Parse(cell4), double.Parse(cell3), (int)double.Parse(cell2), null);
                            }

                            avglong += double.Parse(Commands.Rows[a].Cells[Lon.Index].Value.ToString());
                            avglat += double.Parse(Commands.Rows[a].Cells[Lat.Index].Value.ToString());
                            usable++;

                            maxlong = Math.Max(double.Parse(Commands.Rows[a].Cells[Lon.Index].Value.ToString()), maxlong);
                            maxlat = Math.Max(double.Parse(Commands.Rows[a].Cells[Lat.Index].Value.ToString()), maxlat);
                            minlong = Math.Min(double.Parse(Commands.Rows[a].Cells[Lon.Index].Value.ToString()), minlong);
                            minlat = Math.Min(double.Parse(Commands.Rows[a].Cells[Lat.Index].Value.ToString()), minlat);

                            Debug.WriteLine(temp - Stopwatch.GetTimestamp());
                        }
                        else if (command == (byte)MAVLink.MAV_CMD.DO_JUMP) // fix do jumps into the future
                        {
                            pointlist.Add(null);

                            int wpno = int.Parse(Commands.Rows[a].Cells[Param1.Index].Value.ToString());
                            int repeat = int.Parse(Commands.Rows[a].Cells[Param2.Index].Value.ToString());

                            List<PointLatLngAlt> list = new List<PointLatLngAlt>();

                            // cycle through reps
                            for (int repno = repeat; repno > 0; repno--)
                            {
                                // cycle through wps
                                for (int no = wpno; no <= a; no++)
                                {
                                    if (pointlist[no] != null)
                                        list.Add(pointlist[no]);
                                }
                            }

                            fullpointlist.AddRange(list);
                        }
                        else
                        {
                            pointlist.Add(null);
                        }
                    }
                    catch (Exception e)
                    {
                        log.Info("writekml - bad wp data " + e);
                    }
                }

                if (usable > 0)
                {
                    avglat = avglat / usable;
                    avglong = avglong / usable;
                    double latdiff = maxlat - minlat;
                    double longdiff = maxlong - minlong;
                    float range = 4000;

                    Locationwp loc1 = new Locationwp();
                    loc1.lat = (minlat);
                    loc1.lng = (minlong);
                    Locationwp loc2 = new Locationwp();
                    loc2.lat = (maxlat);
                    loc2.lng = (maxlong);

                    //double distance = getDistance(loc1, loc2);  // same code as ardupilot
                    double distance = 2000;

                    if (usable > 1)
                    {
                        range = (float)(distance * 2);
                    }
                    else
                    {
                        range = 4000;
                    }

                    if (avglong != 0 && usable < 3)
                    {
                        // no autozoom
                        lookat = "<LookAt>     <longitude>" + (minlong + longdiff / 2).ToString(new CultureInfo("en-US")) + "</longitude>     <latitude>" + (minlat + latdiff / 2).ToString(new CultureInfo("en-US")) + "</latitude> <range>" + range + "</range> </LookAt>";
                        //MainMap.ZoomAndCenterMarkers("objects");
                        //MainMap.Zoom -= 1;
                        //MainMap_OnMapZoomChanged();
                    }
                }
                else if (home.Length > 5 && usable == 0)
                {
                    lookat = "<LookAt>     <longitude>" + TXT_homelng.Text.ToString(new CultureInfo("en-US")) + "</longitude>     <latitude>" + TXT_homelat.Text.ToString(new CultureInfo("en-US")) + "</latitude> <range>4000</range> </LookAt>";

                    RectLatLng? rect = gMapControl1.GetRectOfAllMarkers("objects");
                    if (rect.HasValue)
                    {
                        gMapControl1.Position = rect.Value.LocationMiddle;
                    }

                    //MainMap.Zoom = 17;

                    //MainMap_OnMapZoomChanged();
                }

                //RegeneratePolygon();

                RegenerateWPRoute(fullpointlist);

                if (fullpointlist.Count > 0)
                {
                    double homedist = 0;

                    if (home.Length > 5)
                    {
                        homedist = gMapControl1.MapProvider.Projection.GetDistance(fullpointlist[fullpointlist.Count - 1], fullpointlist[0]);
                    }

                    double dist = 0;

                    for (int a = 1; a < fullpointlist.Count; a++)
                    {
                        if (fullpointlist[a - 1] == null)
                            continue;

                        if (fullpointlist[a] == null)
                            continue;

                        dist += gMapControl1.MapProvider.Projection.GetDistance(fullpointlist[a - 1], fullpointlist[a]);
                    }

                    //lbl_distance.Text = rm.GetString("lbl_distance.Text") + ": " + FormatDistance(dist + homedist, false);
                }

                setgradanddistandaz();
            }
            catch (Exception ex)
            {
                log.Info(ex.ToString());
            }

            Debug.WriteLine(DateTime.Now);
        }


        private void Commands_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < Commands.ColumnCount; i++)
            {
                DataGridViewCell tcell = Commands.Rows[e.RowIndex].Cells[i];
                if (tcell.GetType() == typeof(DataGridViewTextBoxCell))
                {
                    if (tcell.Value == null)
                        tcell.Value = "0";
                }
            }

            DataGridViewComboBoxCell cell = Commands.Rows[e.RowIndex].Cells[Command.Index] as DataGridViewComboBoxCell;
            if (cell.Value == null)
            {
                cell.Value = "WAYPOINT";
                cell.DropDownWidth = 200;
                Commands.Rows[e.RowIndex].Cells[Delete.Index].Value = "X";
                if (!quickadd)
                {
                    Commands_RowEnter(sender, new DataGridViewCellEventArgs(0, e.RowIndex - 0)); // do header labels
                    Commands_RowValidating(sender, new DataGridViewCellCancelEventArgs(0, e.RowIndex)); // do default values
                }
            }

            if (quickadd)
                return;

            try
            {
                Commands.CurrentCell = Commands.Rows[e.RowIndex].Cells[0];

                if (Commands.Rows.Count > 1)
                {

                    if (Commands.Rows[e.RowIndex - 1].Cells[Command.Index].Value.ToString() == "WAYPOINT")
                    {
                        Commands.Rows[e.RowIndex].Selected = true; // highlight row
                    }
                    else
                    {
                        Commands.CurrentCell = Commands[1, e.RowIndex - 1];
                        //Commands_RowEnter(sender, new DataGridViewCellEventArgs(0, e.RowIndex-1));
                    }
                }
            }
            catch (Exception) { }
        }

        private void Commands_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            selectedrow = e.RowIndex;
            Commands_RowEnter(sender, new DataGridViewCellEventArgs(0, e.RowIndex - 0)); // do header labels - encure we dont 0 out valid colums
            int cols = Commands.Columns.Count;
            for (int a = 1; a < cols; a++)
            {
                DataGridViewTextBoxCell cell;
                cell = Commands.Rows[selectedrow].Cells[a] as DataGridViewTextBoxCell;

                if (Commands.Columns[a].HeaderText.Equals("") && cell != null && cell.Value == null)
                {
                    cell.Value = "0";
                }
                else
                {
                    if (cell != null && (cell.Value == null || cell.Value.ToString() == ""))
                    {
                        cell.Value = "?";
                    }
                }
            }
        }

        /// <summary>
        /// Used to update column headers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Commands_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (quickadd)
                return;
            try
            {
                selectedrow = e.RowIndex;
                string option = Commands[Command.Index, selectedrow].EditedFormattedValue.ToString();
                string cmd;
                try
                {
                    cmd = Commands[Command.Index, selectedrow].Value.ToString();
                }
                catch { cmd = option; }
                //Console.WriteLine("editformat " + option + " value " + cmd);
                ChangeColumnHeader(cmd);

                setgradanddistandaz();

                if (cmd == "WAYPOINT")
                {

                }

                //  writeKML();
            }
            catch (Exception ex) { CustomMessageBox.Show(ex.ToString()); }
        }

        void setgradanddistandaz()
        {
            int a = 0;
            PointLatLngAlt last = comPort.MAV.cs.HomeLocation;
            foreach (var lla in pointlist)
            {
                if (lla == null)
                    continue;
                try
                {
                    if (lla.Tag != null && lla.Tag != "H" && !lla.Tag.Contains("ROI"))
                    {
                        Commands.Rows[int.Parse(lla.Tag) - 1].Cells[Grad.Index].Value = (((lla.Alt - last.Alt) / (lla.GetDistance(last) * CurrentState.multiplierdist)) * 100).ToString("0.0");

                        Commands.Rows[int.Parse(lla.Tag) - 1].Cells[Dist.Index].Value = (lla.GetDistance(last) * CurrentState.multiplierdist).ToString("0.0");

                        Commands.Rows[int.Parse(lla.Tag) - 1].Cells[AZ.Index].Value = ((lla.GetBearing(last) + 180) % 360).ToString("0");
                    }
                }
                catch { }
                a++;
                last = lla;
            }
        }
        private void RegenerateWPRoute(List<PointLatLngAlt> fullpointlist)
        {


            route.Clear();
            homeroute.Clear();

            polygonsoverlay.Routes.Clear();

            PointLatLngAlt lastpnt = fullpointlist[0];
            PointLatLngAlt lastpnt2 = fullpointlist[0];
            PointLatLngAlt lastnonspline = fullpointlist[0];
            List<PointLatLngAlt> splinepnts = new List<PointLatLngAlt>();
            List<PointLatLngAlt> wproute = new List<PointLatLngAlt>();

            // add home - this causeszx the spline to always have a straight finish
            fullpointlist.Add(fullpointlist[0]);

            for (int a = 0; a < fullpointlist.Count; a++)
            {
                if (fullpointlist[a] == null)
                    continue;

                if (fullpointlist[a].Tag2 == "spline")
                {
                    if (splinepnts.Count == 0)
                        splinepnts.Add(lastpnt);

                    splinepnts.Add(fullpointlist[a]);
                }
                else
                {
                    if (splinepnts.Count > 0)
                    {
                        List<PointLatLng> list = new List<PointLatLng>();

                        splinepnts.Add(fullpointlist[a]);

                        Spline2 sp = new Spline2();

                        //sp._flags.segment_type = MissionPlanner.Controls.Waypoints.Spline2.SegmentType.SEGMENT_STRAIGHT;
                        //sp._flags.reached_destination = true;
                        //sp._origin = sp.pv_location_to_vector(lastpnt);
                        //sp._destination = sp.pv_location_to_vector(fullpointlist[0]);

                        // sp._spline_origin_vel = sp.pv_location_to_vector(lastpnt) - sp.pv_location_to_vector(lastnonspline);

                        sp.set_wp_origin_and_destination(sp.pv_location_to_vector(lastpnt2), sp.pv_location_to_vector(lastpnt));

                        sp._flags.reached_destination = true;

                        for (int no = 1; no < (splinepnts.Count - 1); no++)
                        {
                            Spline2.spline_segment_end_type segtype = Spline2.spline_segment_end_type.SEGMENT_END_STRAIGHT;

                            if (no < (splinepnts.Count - 2))
                            {
                                segtype = Spline2.spline_segment_end_type.SEGMENT_END_SPLINE;
                            }

                            sp.set_spline_destination(sp.pv_location_to_vector(splinepnts[no]), false, segtype, sp.pv_location_to_vector(splinepnts[no + 1]));

                            //sp.update_spline();

                            while (sp._flags.reached_destination == false)
                            {
                                float t = 1f;
                                //sp.update_spline();
                                sp.advance_spline_target_along_track(t);
                                // Console.WriteLine(sp.pv_vector_to_location(sp.target_pos).ToString());
                                list.Add(sp.pv_vector_to_location(sp.target_pos));
                            }

                            list.Add(splinepnts[no]);

                        }

                        list.ForEach(x =>
                        {
                            wproute.Add(x);
                        });


                        splinepnts.Clear();

                        /*
                        MissionPlanner.Controls.Waypoints.Spline sp = new Controls.Waypoints.Spline();
                        
                        var spline = sp.doit(splinepnts, 20, lastlastpnt.GetBearing(splinepnts[0]),false);

                  
                         */

                        lastnonspline = fullpointlist[a];
                    }

                    wproute.Add(fullpointlist[a]);

                    lastpnt2 = lastpnt;
                    lastpnt = fullpointlist[a];
                }
            }
            /*

           List<PointLatLng> list = new List<PointLatLng>();
           fullpointlist.ForEach(x => { list.Add(x); });
           route.Points.AddRange(list);
           */
            // route is full need to get 1, 2 and last point as "HOME" route

            int count = wproute.Count;
            int counter = 0;
            PointLatLngAlt homepoint = new PointLatLngAlt();
            PointLatLngAlt firstpoint = new PointLatLngAlt();
            PointLatLngAlt lastpoint = new PointLatLngAlt();

            if (count > 2)
            {
                // homeroute = last, home, first
                wproute.ForEach(x =>
                {
                    counter++;
                    if (counter == 1) { homepoint = x; return; }
                    if (counter == 2) { firstpoint = x; }
                    if (counter == count - 1) { lastpoint = x; }
                    if (counter == count) { homeroute.Points.Add(lastpoint); homeroute.Points.Add(homepoint); homeroute.Points.Add(firstpoint); return; }
                    route.Points.Add(x);
                });

                homeroute.Stroke = new Pen(Color.Yellow, 2);
                // if we have a large distance between home and the first/last point, it hangs on the draw of a the dashed line.
                if (homepoint.GetDistance(lastpoint) < 5000 && homepoint.GetDistance(firstpoint) < 5000)
                    homeroute.Stroke.DashStyle = DashStyle.Dash;

                polygonsoverlay.Routes.Add(homeroute);

                route.Stroke = new Pen(Color.Yellow, 4);
                route.Stroke.DashStyle = DashStyle.Custom;
                polygonsoverlay.Routes.Add(route);
            }
        }

        public GMapRoute route = new GMapRoute("wp route");
        void processToScreen(List<Locationwp> cmds, bool append = false)
        {
            quickadd = true;


            // mono fix
            Commands.CurrentCell = null;

            while (Commands.Rows.Count > 0 && !append)
                Commands.Rows.Clear();

            if (cmds.Count == 0)
            {
                quickadd = false;
                return;
            }

            int i = Commands.Rows.Count - 1;
            foreach (Locationwp temp in cmds)
            {
                i++;
                //Console.WriteLine("FP processToScreen " + i);
                if (temp.id == 0 && i != 0) // 0 and not home
                    break;
                if (temp.id == 255 && i != 0) // bad record - never loaded any WP's - but have started the board up.
                    break;
                if (i + 1 >= Commands.Rows.Count)
                {
                    selectedrow = Commands.Rows.Add();
                }
                //if (i == 0 && temp.alt == 0) // skip 0 home
                //  continue;
                DataGridViewTextBoxCell cell;
                DataGridViewComboBoxCell cellcmd;
                cellcmd = Commands.Rows[i].Cells[Command.Index] as DataGridViewComboBoxCell;
                cellcmd.Value = "UNKNOWN";
                cellcmd.Tag = temp.id;

                foreach (object value in Enum.GetValues(typeof(MAVLink.MAV_CMD)))
                {
                    if ((int)value == temp.id)
                    {
                        cellcmd.Value = value.ToString();
                        break;
                    }
                }

                // from ap_common.h
                if (temp.id < (byte)MAVLink.MAV_CMD.LAST || temp.id == (byte)MAVLink.MAV_CMD.DO_SET_HOME)
                {
                    //// check ralatice and terrain flags
                    //if ((temp.options & 0x9) == 0 && i != 0)
                    //{
                    //    CMB_altmode.SelectedValue = (int)altmode.Absolute;
                    //}// check terrain flag
                    //else if ((temp.options & 0x8) != 0 && i != 0)
                    //{
                    //    CMB_altmode.SelectedValue = (int)altmode.Terrain;
                    //}// check relative flag
                    //else if ((temp.options & 0x1) != 0 && i != 0)
                    //{
                    //    CMB_altmode.SelectedValue = (int)altmode.Relative;
                    //}
                }

                cell = Commands.Rows[i].Cells[Alt.Index] as DataGridViewTextBoxCell;
                cell.Value = Math.Round((temp.alt * CurrentState.multiplierdist), 0);
                cell = Commands.Rows[i].Cells[Lat.Index] as DataGridViewTextBoxCell;
                cell.Value = temp.lat;
                cell = Commands.Rows[i].Cells[Lon.Index] as DataGridViewTextBoxCell;
                cell.Value = temp.lng;

                cell = Commands.Rows[i].Cells[Param1.Index] as DataGridViewTextBoxCell;
                cell.Value = temp.p1;
                cell = Commands.Rows[i].Cells[Param2.Index] as DataGridViewTextBoxCell;
                cell.Value = temp.p2;
                cell = Commands.Rows[i].Cells[Param3.Index] as DataGridViewTextBoxCell;
                cell.Value = temp.p3;
                cell = Commands.Rows[i].Cells[Param4.Index] as DataGridViewTextBoxCell;
                cell.Value = temp.p4;
            }

            setWPParams();

            try
            {

                DataGridViewTextBoxCell cellhome;
                cellhome = Commands.Rows[0].Cells[Lat.Index] as DataGridViewTextBoxCell;
                if (cellhome.Value != null)
                {
                    if (cellhome.Value.ToString() != TXT_homelat.Text && cellhome.Value.ToString() != "0")
                    {
                        DialogResult dr = CustomMessageBox.Show("Reset Home to loaded coords", "Reset Home Coords", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            TXT_homelat.Text = (double.Parse(cellhome.Value.ToString())).ToString();
                            cellhome = Commands.Rows[0].Cells[Lon.Index] as DataGridViewTextBoxCell;
                            TXT_homelng.Text = (double.Parse(cellhome.Value.ToString())).ToString();
                            cellhome = Commands.Rows[0].Cells[Alt.Index] as DataGridViewTextBoxCell;
                            TXT_homealt.Text = (double.Parse(cellhome.Value.ToString()) * CurrentState.multiplierdist).ToString();
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.ToString()); } // if there is no valid home

            if (Commands.RowCount > 0)
            {
                log.Info("remove home from list");
                Commands.Rows.Remove(Commands.Rows[0]); // remove home row
            }

            quickadd = false;

            writeKML();

            gMapControl1.ZoomAndCenterMarkers("objects");

            //MainMap_OnMapZoomChanged();
        }
        void setWPParams()
        {
            try
            {
                log.Info("Loading wp params");

                Hashtable param = new Hashtable(comPort.MAV.param);

                if (param["WP_RADIUS"] != null)
                {
                    TXT_WPRad.Text = ((int)((float)param["WP_RADIUS"] * CurrentState.multiplierdist)).ToString();
                }
                if (param["WPNAV_RADIUS"] != null)
                {
                    TXT_WPRad.Text = ((int)((float)param["WPNAV_RADIUS"] * CurrentState.multiplierdist / 100)).ToString();
                }

                log.Info("param WP_RADIUS " + TXT_WPRad.Text);

                try
                {
                    TXT_loiterrad.Enabled = false;
                    if (param["LOITER_RADIUS"] != null)
                    {
                        TXT_loiterrad.Text = ((int)((float)param["LOITER_RADIUS"] * CurrentState.multiplierdist)).ToString();
                        TXT_loiterrad.Enabled = true;
                    }
                    else if (param["WP_LOITER_RAD"] != null)
                    {
                        TXT_loiterrad.Text = ((int)((float)param["WP_LOITER_RAD"] * CurrentState.multiplierdist)).ToString();
                        TXT_loiterrad.Enabled = true;
                    }

                    log.Info("param LOITER_RADIUS " + TXT_loiterrad.Text);
                }
                catch
                {

                }
            }
            catch (Exception ex) { log.Error(ex); }
        }
        List<Locationwp> GetCommandList()
        {
            List<Locationwp> commands = new List<Locationwp>();

            for (int a = 0; a < Commands.Rows.Count - 0; a++)
            {
                var temp = DataViewtoLocationwp(a);

                commands.Add(temp);
            }

            return commands;
        }
        Locationwp DataViewtoLocationwp(int a)
        {
            Locationwp temp = new Locationwp();
            if (Commands.Rows[a].Cells[Command.Index].Value.ToString().Contains("UNKNOWN"))
            {
                temp.id = (byte)Commands.Rows[a].Cells[Command.Index].Tag;
            }
            else
            {
                temp.id = (byte)(int)Enum.Parse(typeof(MAVLink.MAV_CMD), Commands.Rows[a].Cells[Command.Index].Value.ToString(), false);
            }
            temp.p1 = float.Parse(Commands.Rows[a].Cells[Param1.Index].Value.ToString());

            temp.alt = (float)(double.Parse(Commands.Rows[a].Cells[Alt.Index].Value.ToString()) / CurrentState.multiplierdist);
            temp.lat = (double.Parse(Commands.Rows[a].Cells[Lat.Index].Value.ToString()));
            temp.lng = (double.Parse(Commands.Rows[a].Cells[Lon.Index].Value.ToString()));

            temp.p2 = (float)(double.Parse(Commands.Rows[a].Cells[Param2.Index].Value.ToString()));
            temp.p3 = (float)(double.Parse(Commands.Rows[a].Cells[Param3.Index].Value.ToString()));
            temp.p4 = (float)(double.Parse(Commands.Rows[a].Cells[Param4.Index].Value.ToString()));

            return temp;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Commands.Rows.Count > 0)
            {
                if (CustomMessageBox.Show("将覆盖本地航点,是否继续?", "确定", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }
            }

            ProgressReporterDialogue frmProgressReporter = new ProgressReporterDialogue
            {
                StartPosition = FormStartPosition.CenterScreen,
                Text = "下载航点"
            };

            frmProgressReporter.DoWork += getWPs;
            frmProgressReporter.UpdateProgressAndStatus(-1, "下载航点");


            frmProgressReporter.RunBackgroundOperationAsync();

            frmProgressReporter.Dispose();
        }

        private void label4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comPort.MAV.cs.lat != 0)
            {
                TXT_homealt.Text = comPort.MAV.cs.altasl.ToString("0");
                TXT_homelat.Text = comPort.MAV.cs.lat.ToString();
                TXT_homelng.Text = comPort.MAV.cs.lng.ToString();
            }
            else
            {
                CustomMessageBox.Show("在户外, 连接并等待GPS定位. 点击选择回家位置.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.panelWPPanel.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.panelWPPanel.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            isPlanMode = !isPlanMode;
            if (isPlanMode)
                button13.Enabled = true;
            else
                button13.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (polygongridmode == false)
            {
                CustomMessageBox.Show("开始规划模式,清除规划区域后结束规划模式.");
            }

            polygongridmode = true;

            List<PointLatLng> polygonPoints = new List<PointLatLng>();
            if (drawnpolygonsoverlay.Polygons.Count == 0)
            {
                drawnpolygon.Points.Clear();
                drawnpolygonsoverlay.Polygons.Add(drawnpolygon);
            }

            drawnpolygon.Fill = Brushes.Transparent;

            // remove full loop is exists
            if (drawnpolygon.Points.Count > 1 && drawnpolygon.Points[0] == drawnpolygon.Points[drawnpolygon.Points.Count - 1])
                drawnpolygon.Points.RemoveAt(drawnpolygon.Points.Count - 1); // unmake a full loop

            drawnpolygon.Points.Add(new PointLatLng(MouseDownStart.Lat, MouseDownStart.Lng));

            addpolygonmarkergrid(drawnpolygon.Points.Count.ToString(), MouseDownStart.Lng, MouseDownStart.Lat, 0);

            gMapControl1.UpdatePolygonLocalPosition(drawnpolygon);

            gMapControl1.Invalidate();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            polygongridmode = false;
            if (drawnpolygon == null)
                return;
            drawnpolygon.Points.Clear();
            drawnpolygonsoverlay.Markers.Clear();

            writeKML();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (drawnpolygon.Points != null && drawnpolygon.Points.Count > 2)
            {
                GridUI gui = new GridUI(drawnpolygon.Points, this);
                gui.ShowDialog();
            }
            else
            {
                CustomMessageBox.Show("请先添加航线范围.");
            }
        }

        public PointLatLng HomeLocation
        {
            get
            {
                if (comPort.MAV.cs.HomeLocation.Lat != null && comPort.MAV.cs.HomeLocation.Lat > 0)
                {
                    return new PointLatLng(comPort.MAV.cs.HomeLocation.Lat, comPort.MAV.cs.HomeLocation.Lng);
                }
                else
                    return new PointLatLng(double.Parse(TXT_homelat.Text), double.Parse(TXT_homelng.Text));
            }
        }


        public void AddCommand(MAVLink.MAV_CMD cmd, double p1, double p2, double p3, double p4, double x, double y, double z)
        {
            selectedrow = Commands.Rows.Add();

            Commands.Rows[selectedrow].Cells[Command.Index].Value = cmd.ToString();
            ChangeColumnHeader(cmd.ToString());

            // switch wp to spline if spline checked
            if (splinemode && cmd == MAVLink.MAV_CMD.WAYPOINT)
            {
                Commands.Rows[selectedrow].Cells[Command.Index].Value = MAVLink.MAV_CMD.SPLINE_WAYPOINT.ToString();
                ChangeColumnHeader(MAVLink.MAV_CMD.SPLINE_WAYPOINT.ToString());
            }

            if (cmd == MAVLink.MAV_CMD.WAYPOINT)
            {
                setfromMap(y, x, (int)z, Math.Round(p1, 1));
            }
            else
            {
                Commands.Rows[selectedrow].Cells[Param1.Index].Value = p1;
                Commands.Rows[selectedrow].Cells[Param2.Index].Value = p2;
                Commands.Rows[selectedrow].Cells[Param3.Index].Value = p3;
                Commands.Rows[selectedrow].Cells[Param4.Index].Value = p4;
                Commands.Rows[selectedrow].Cells[Lat.Index].Value = y;
                Commands.Rows[selectedrow].Cells[Lon.Index].Value = x;
                Commands.Rows[selectedrow].Cells[Alt.Index].Value = z;
            }

            writeKML();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comPort.doCommand(MAVLink.MAV_CMD.DO_DIGICAM_CONTROL, 0, 0, 0, 0, 1, 0, 0);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (comPort != null && comPort.BaseStream.IsOpen)
            {
                if (comPort.MAV.cs.lat != null && comPort.MAV.cs.lat > 0)
                {
                    gMapControl1.Position = new PointLatLng(comPort.MAV.cs.lat, comPort.MAV.cs.lng);
                    gMapControl1.Zoom = 18;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // define the home point
            Locationwp home = new Locationwp();
            try
            {
                home.id = (byte)MAVLink.MAV_CMD.WAYPOINT;
                home.lat = (double.Parse(TXT_homelat.Text));
                home.lng = (double.Parse(TXT_homelng.Text));
                home.alt = (float.Parse(TXT_homealt.Text) / CurrentState.multiplierdist); // use saved home
            }
            catch { throw new Exception("Your home location is invalid"); }

            gMapControl1.Position = new PointLatLng(home.lat, home.lng);
            gMapControl1.Zoom = 18;
        }


    }
}
