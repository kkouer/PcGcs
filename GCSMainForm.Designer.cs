namespace MissionPlanner
{
    partial class GCSMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCSMainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteWP = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertWP = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.measureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelMap = new System.Windows.Forms.Panel();
            this.metroDMButton19 = new DMSkin.MetroDMButton();
            this.metroDMButton14 = new DMSkin.MetroDMButton();
            this.metroDMButton6 = new DMSkin.MetroDMButton();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.dmTabControl1 = new DMSkin.Controls.DMTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3Command = new BSE.Windows.Forms.Panel();
            this.metroDMButton13 = new DMSkin.MetroDMButton();
            this.dmButton2 = new DMSkin.Controls.DMButton();
            this.metroDMButton5 = new DMSkin.MetroDMButton();
            this.dmButton4 = new DMSkin.Controls.DMButton();
            this.metroDMButton4 = new DMSkin.MetroDMButton();
            this.dmButton3 = new DMSkin.Controls.DMButton();
            this.metroDMButton3 = new DMSkin.MetroDMButton();
            this.dmButton1 = new DMSkin.Controls.DMButton();
            this.myButtonRTL = new DMSkin.Controls.DMButton();
            this.myButtonAuto = new DMSkin.Controls.DMButton();
            this.panelAttitude = new BSE.Windows.Forms.Panel();
            this.hud1 = new MissionPlanner.Controls.HUD();
            this.panelStates = new BSE.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Commands = new System.Windows.Forms.DataGridView();
            this.Command = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Param1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Up = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new DMSkin.Metro.Controls.MetroPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_WPRad = new System.Windows.Forms.Label();
            this.TXT_loiterrad = new System.Windows.Forms.TextBox();
            this.TXT_DefaultAlt = new System.Windows.Forms.TextBox();
            this.CHK_splinedefault = new System.Windows.Forms.CheckBox();
            this.LBL_defalutalt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_WPRad = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_altwarn = new System.Windows.Forms.TextBox();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TXT_homealt = new System.Windows.Forms.TextBox();
            this.TXT_homelng = new System.Windows.Forms.TextBox();
            this.TXT_homelat = new System.Windows.Forms.TextBox();
            this.metroPanel2 = new DMSkin.Metro.Controls.MetroPanel();
            this.metroDMButton2 = new DMSkin.MetroDMButton();
            this.metroDMButton1 = new DMSkin.MetroDMButton();
            this.metroDMButton9 = new DMSkin.MetroDMButton();
            this.metroDMButton8 = new DMSkin.MetroDMButton();
            this.metroDMButton7 = new DMSkin.MetroDMButton();
            this.dmButtonGridUI = new DMSkin.Controls.DMButton();
            this.dmButtonClreaGird = new DMSkin.Controls.DMButton();
            this.dmButtonCreatGrid = new DMSkin.Controls.DMButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel5 = new BSE.Windows.Forms.Panel();
            this.metroDMButton18 = new DMSkin.MetroDMButton();
            this.metroDMButton17 = new DMSkin.MetroDMButton();
            this.metroDMButton16 = new DMSkin.MetroDMButton();
            this.dmButton13 = new DMSkin.Controls.DMButton();
            this.dmButton14 = new DMSkin.Controls.DMButton();
            this.dmButton15 = new DMSkin.Controls.DMButton();
            this.panel4 = new BSE.Windows.Forms.Panel();
            this.metroDMButton15 = new DMSkin.MetroDMButton();
            this.dmButton10 = new DMSkin.Controls.DMButton();
            this.dmButton11 = new DMSkin.Controls.DMButton();
            this.dmButton12 = new DMSkin.Controls.DMButton();
            this.panel3 = new BSE.Windows.Forms.Panel();
            this.metroDMButton11 = new DMSkin.MetroDMButton();
            this.metroDMButton10 = new DMSkin.MetroDMButton();
            this.dmButton8 = new DMSkin.Controls.DMButton();
            this.dmButton7 = new DMSkin.Controls.DMButton();
            this.dmButtonChangeWP = new DMSkin.Controls.DMButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTile1 = new DMSkin.Metro.Controls.MetroTile();
            this.dmButtonMinLightFormMin = new DMSkin.Controls.DMButtonMinLight();
            this.dmButtonCloseLightFormClose = new DMSkin.Controls.DMButtonCloseLight();
            this.timerTileDoubleClick = new System.Windows.Forms.Timer(this.components);
            this.metroToolTip1 = new DMSkin.Metro.Components.MetroToolTip();
            this.dmButtonZoomOut = new DMSkin.Controls.DMButton();
            this.dmButtonZoomIn = new DMSkin.Controls.DMButton();
            this.dmButton5 = new DMSkin.Controls.DMButton();
            this.dmButton6 = new DMSkin.Controls.DMButton();
            this.CMB_setwp = new DMSkin.Metro.Controls.MetroComboBox();
            this.metroComboBoxMapType = new DMSkin.Metro.Controls.MetroComboBox();
            this.dmLabel5 = new DMSkin.Controls.DMLabel();
            this.dmButton9 = new DMSkin.Controls.DMButton();
            this.metroComboBoxSPort = new DMSkin.Metro.Controls.MetroComboBox();
            this.panelControl = new BSE.Windows.Forms.Panel();
            this.metroDMButton12 = new DMSkin.MetroDMButton();
            this.dmLabel3 = new DMSkin.Controls.DMLabel();
            this.dmLabel2 = new DMSkin.Controls.DMLabel();
            this.labelHomeDisToPlane = new System.Windows.Forms.Label();
            this.dmLabel1 = new DMSkin.Controls.DMLabel();
            this.BUT_Connect = new DMSkin.Controls.DMButton();
            this.metroComboBox1 = new DMSkin.Metro.Controls.MetroComboBox();
            this.bindingSourceHud = new System.Windows.Forms.BindingSource(this.components);
            this.extQuickView1 = new MissionPlanner.GCSViews.ExtQuickView();
            this.bindingSourceState = new System.Windows.Forms.BindingSource(this.components);
            this.extQuickView2 = new MissionPlanner.GCSViews.ExtQuickView();
            this.extQuickView5 = new MissionPlanner.GCSViews.ExtQuickView();
            this.extQuickView4 = new MissionPlanner.GCSViews.ExtQuickView();
            this.extQuickView3 = new MissionPlanner.GCSViews.ExtQuickView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.dmTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3Command.SuspendLayout();
            this.panelAttitude.SuspendLayout();
            this.panelStates.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.metroTile1.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceState)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteWP,
            this.InsertWP,
            this.clearMissionToolStripMenuItem,
            this.setROIToolStripMenuItem,
            this.toolStripSeparator1,
            this.measureToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 120);
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // DeleteWP
            // 
            this.DeleteWP.Name = "DeleteWP";
            this.DeleteWP.Size = new System.Drawing.Size(136, 22);
            this.DeleteWP.Text = "删除航点";
            this.DeleteWP.Click += new System.EventHandler(this.DeleteWP_Click);
            // 
            // InsertWP
            // 
            this.InsertWP.Name = "InsertWP";
            this.InsertWP.Size = new System.Drawing.Size(136, 22);
            this.InsertWP.Text = "插入航点";
            // 
            // clearMissionToolStripMenuItem
            // 
            this.clearMissionToolStripMenuItem.Name = "clearMissionToolStripMenuItem";
            this.clearMissionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.clearMissionToolStripMenuItem.Text = "清除任务";
            this.clearMissionToolStripMenuItem.Click += new System.EventHandler(this.clearMissionToolStripMenuItem_Click);
            // 
            // setROIToolStripMenuItem
            // 
            this.setROIToolStripMenuItem.Name = "setROIToolStripMenuItem";
            this.setROIToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.setROIToolStripMenuItem.Text = "设置观察点";
            this.setROIToolStripMenuItem.Click += new System.EventHandler(this.setROIToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // measureToolStripMenuItem
            // 
            this.measureToolStripMenuItem.Name = "measureToolStripMenuItem";
            this.measureToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.measureToolStripMenuItem.Text = "量尺工具";
            this.measureToolStripMenuItem.Click += new System.EventHandler(this.measureToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 72);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitter1);
            this.splitContainer2.Panel1.Controls.Add(this.panelMap);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dmTabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1216, 708);
            this.splitContainer2.SplitterDistance = 933;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 705);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(933, 3);
            this.splitter1.TabIndex = 52;
            this.splitter1.TabStop = false;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.metroDMButton19);
            this.panelMap.Controls.Add(this.metroDMButton14);
            this.panelMap.Controls.Add(this.metroDMButton6);
            this.panelMap.Controls.Add(this.gMapControl1);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 0);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(933, 708);
            this.panelMap.TabIndex = 51;
            // 
            // metroDMButton19
            // 
            this.metroDMButton19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDMButton19.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton19.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton19.DownImage")));
            this.metroDMButton19.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton19.Image = null;
            this.metroDMButton19.IsShowBorder = true;
            this.metroDMButton19.Location = new System.Drawing.Point(836, 68);
            this.metroDMButton19.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton19.MoveImage")));
            this.metroDMButton19.Name = "metroDMButton19";
            this.metroDMButton19.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton19.NormalImage")));
            this.metroDMButton19.Size = new System.Drawing.Size(94, 36);
            this.metroDMButton19.TabIndex = 4;
            this.metroDMButton19.Text = "小蚁拍照";
            this.metroDMButton19.UseVisualStyleBackColor = false;
            this.metroDMButton19.Click += new System.EventHandler(this.metroDMButton19_Click);
            // 
            // metroDMButton14
            // 
            this.metroDMButton14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDMButton14.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton14.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton14.DownImage")));
            this.metroDMButton14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton14.Image = null;
            this.metroDMButton14.IsShowBorder = true;
            this.metroDMButton14.Location = new System.Drawing.Point(836, 135);
            this.metroDMButton14.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton14.MoveImage")));
            this.metroDMButton14.Name = "metroDMButton14";
            this.metroDMButton14.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton14.NormalImage")));
            this.metroDMButton14.Size = new System.Drawing.Size(94, 36);
            this.metroDMButton14.TabIndex = 3;
            this.metroDMButton14.Text = "小蚁模式";
            this.metroDMButton14.UseVisualStyleBackColor = false;
            this.metroDMButton14.Click += new System.EventHandler(this.metroDMButton14_Click_1);
            // 
            // metroDMButton6
            // 
            this.metroDMButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDMButton6.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton6.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton6.DownImage")));
            this.metroDMButton6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton6.Image = null;
            this.metroDMButton6.IsShowBorder = true;
            this.metroDMButton6.Location = new System.Drawing.Point(836, 6);
            this.metroDMButton6.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton6.MoveImage")));
            this.metroDMButton6.Name = "metroDMButton6";
            this.metroDMButton6.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton6.NormalImage")));
            this.metroDMButton6.Size = new System.Drawing.Size(94, 36);
            this.metroDMButton6.TabIndex = 2;
            this.metroDMButton6.Text = "小蚁开关";
            this.metroDMButton6.UseVisualStyleBackColor = false;
            this.metroDMButton6.Click += new System.EventHandler(this.metroDMButton6_Click_1);
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.Color.Transparent;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(933, 708);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDown);
            this.gMapControl1.MouseLeave += new System.EventHandler(this.gMapControl1_MouseLeave);
            this.gMapControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseMove);
            // 
            // dmTabControl1
            // 
            this.dmTabControl1.BackColor = System.Drawing.Color.Transparent;
            this.dmTabControl1.Controls.Add(this.tabPage1);
            this.dmTabControl1.Controls.Add(this.tabPage2);
            this.dmTabControl1.Controls.Add(this.tabPage3);
            this.dmTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dmTabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmTabControl1.ItemSize = new System.Drawing.Size(80, 32);
            this.dmTabControl1.Location = new System.Drawing.Point(0, 0);
            this.dmTabControl1.Name = "dmTabControl1";
            this.dmTabControl1.SelectedIndex = 0;
            this.dmTabControl1.Size = new System.Drawing.Size(279, 708);
            this.dmTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dmTabControl1.TabIndex = 2;
            this.dmTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.dmTabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3Command);
            this.tabPage1.Controls.Add(this.panelAttitude);
            this.tabPage1.Controls.Add(this.panelStates);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(271, 668);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "飞行数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel3Command
            // 
            this.panel3Command.AssociatedSplitter = null;
            this.panel3Command.BackColor = System.Drawing.Color.Transparent;
            this.panel3Command.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.panel3Command.CaptionHeight = 27;
            this.panel3Command.Controls.Add(this.metroDMButton13);
            this.panel3Command.Controls.Add(this.dmButton2);
            this.panel3Command.Controls.Add(this.metroDMButton5);
            this.panel3Command.Controls.Add(this.dmButton4);
            this.panel3Command.Controls.Add(this.metroDMButton4);
            this.panel3Command.Controls.Add(this.dmButton3);
            this.panel3Command.Controls.Add(this.metroDMButton3);
            this.panel3Command.Controls.Add(this.dmButton1);
            this.panel3Command.Controls.Add(this.myButtonRTL);
            this.panel3Command.Controls.Add(this.myButtonAuto);
            this.panel3Command.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel3Command.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panel3Command.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panel3Command.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel3Command.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panel3Command.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3Command.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel3Command.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel3Command.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panel3Command.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panel3Command.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panel3Command.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel3Command.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panel3Command.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3Command.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel3Command.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3Command.Image = null;
            this.panel3Command.Location = new System.Drawing.Point(3, 420);
            this.panel3Command.MinimumSize = new System.Drawing.Size(27, 27);
            this.panel3Command.Name = "panel3Command";
            this.panel3Command.Size = new System.Drawing.Size(265, 245);
            this.panel3Command.TabIndex = 88;
            this.panel3Command.ToolTipTextCloseIcon = null;
            this.panel3Command.ToolTipTextExpandIconPanelCollapsed = null;
            this.panel3Command.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // metroDMButton13
            // 
            this.metroDMButton13.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton13.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton13.DownImage")));
            this.metroDMButton13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton13.Image = null;
            this.metroDMButton13.IsShowBorder = true;
            this.metroDMButton13.Location = new System.Drawing.Point(141, 130);
            this.metroDMButton13.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton13.MoveImage")));
            this.metroDMButton13.Name = "metroDMButton13";
            this.metroDMButton13.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton13.NormalImage")));
            this.metroDMButton13.Size = new System.Drawing.Size(108, 45);
            this.metroDMButton13.TabIndex = 91;
            this.metroDMButton13.Text = "任务开始";
            this.metroDMButton13.UseVisualStyleBackColor = false;
            this.metroDMButton13.Click += new System.EventHandler(this.metroDMButton13_Click);
            // 
            // dmButton2
            // 
            this.dmButton2.BackColor = System.Drawing.Color.Transparent;
            this.dmButton2.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton2.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dmButton2.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dmButton2.DM_NormalColor = System.Drawing.Color.Coral;
            this.dmButton2.DM_Radius = 5;
            this.dmButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButton2.Image = null;
            this.dmButton2.Location = new System.Drawing.Point(171, 161);
            this.dmButton2.Name = "dmButton2";
            this.dmButton2.Size = new System.Drawing.Size(89, 33);
            this.dmButton2.TabIndex = 90;
            this.dmButton2.Text = "拍照测试";
            this.dmButton2.UseVisualStyleBackColor = false;
            this.dmButton2.Visible = false;
            this.dmButton2.Click += new System.EventHandler(this.dmButton2_Click);
            // 
            // metroDMButton5
            // 
            this.metroDMButton5.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton5.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton5.DownImage")));
            this.metroDMButton5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton5.Image = null;
            this.metroDMButton5.IsShowBorder = true;
            this.metroDMButton5.Location = new System.Drawing.Point(15, 130);
            this.metroDMButton5.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton5.MoveImage")));
            this.metroDMButton5.Name = "metroDMButton5";
            this.metroDMButton5.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton5.NormalImage")));
            this.metroDMButton5.Size = new System.Drawing.Size(108, 45);
            this.metroDMButton5.TabIndex = 5;
            this.metroDMButton5.Text = "解锁/加锁";
            this.metroDMButton5.UseVisualStyleBackColor = false;
            this.metroDMButton5.Click += new System.EventHandler(this.metroDMButton5_Click);
            // 
            // dmButton4
            // 
            this.dmButton4.BackColor = System.Drawing.Color.Transparent;
            this.dmButton4.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton4.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dmButton4.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dmButton4.DM_NormalColor = System.Drawing.Color.Coral;
            this.dmButton4.DM_Radius = 5;
            this.dmButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButton4.Image = null;
            this.dmButton4.Location = new System.Drawing.Point(171, 161);
            this.dmButton4.Name = "dmButton4";
            this.dmButton4.Size = new System.Drawing.Size(89, 33);
            this.dmButton4.TabIndex = 89;
            this.dmButton4.Text = "下载航点";
            this.dmButton4.UseVisualStyleBackColor = false;
            this.dmButton4.Visible = false;
            this.dmButton4.Click += new System.EventHandler(this.myButton_downloadWPs_Click);
            // 
            // metroDMButton4
            // 
            this.metroDMButton4.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton4.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton4.DownImage")));
            this.metroDMButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton4.Image = null;
            this.metroDMButton4.IsShowBorder = true;
            this.metroDMButton4.Location = new System.Drawing.Point(141, 55);
            this.metroDMButton4.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton4.MoveImage")));
            this.metroDMButton4.Name = "metroDMButton4";
            this.metroDMButton4.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton4.NormalImage")));
            this.metroDMButton4.Size = new System.Drawing.Size(108, 45);
            this.metroDMButton4.TabIndex = 4;
            this.metroDMButton4.Text = "自动";
            this.metroDMButton4.UseVisualStyleBackColor = false;
            this.metroDMButton4.Click += new System.EventHandler(this.metroDMButton4_Click);
            // 
            // dmButton3
            // 
            this.dmButton3.BackColor = System.Drawing.Color.Transparent;
            this.dmButton3.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton3.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dmButton3.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dmButton3.DM_NormalColor = System.Drawing.Color.Coral;
            this.dmButton3.DM_Radius = 5;
            this.dmButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButton3.Image = null;
            this.dmButton3.Location = new System.Drawing.Point(171, 161);
            this.dmButton3.Name = "dmButton3";
            this.dmButton3.Size = new System.Drawing.Size(89, 33);
            this.dmButton3.TabIndex = 88;
            this.dmButton3.Text = "上传航点";
            this.dmButton3.UseVisualStyleBackColor = false;
            this.dmButton3.Visible = false;
            this.dmButton3.Click += new System.EventHandler(this.myButton_uploadWPs_Click);
            // 
            // metroDMButton3
            // 
            this.metroDMButton3.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton3.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton3.DownImage")));
            this.metroDMButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton3.Image = null;
            this.metroDMButton3.IsShowBorder = true;
            this.metroDMButton3.Location = new System.Drawing.Point(15, 55);
            this.metroDMButton3.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton3.MoveImage")));
            this.metroDMButton3.Name = "metroDMButton3";
            this.metroDMButton3.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton3.NormalImage")));
            this.metroDMButton3.Size = new System.Drawing.Size(108, 45);
            this.metroDMButton3.TabIndex = 3;
            this.metroDMButton3.Text = "回家";
            this.metroDMButton3.UseVisualStyleBackColor = false;
            this.metroDMButton3.Click += new System.EventHandler(this.metroDMButton3_Click);
            // 
            // dmButton1
            // 
            this.dmButton1.BackColor = System.Drawing.Color.Transparent;
            this.dmButton1.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton1.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dmButton1.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dmButton1.DM_NormalColor = System.Drawing.Color.Coral;
            this.dmButton1.DM_Radius = 5;
            this.dmButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButton1.Image = null;
            this.dmButton1.Location = new System.Drawing.Point(171, 161);
            this.dmButton1.Name = "dmButton1";
            this.dmButton1.Size = new System.Drawing.Size(89, 33);
            this.dmButton1.TabIndex = 86;
            this.dmButton1.Text = "解锁/加锁";
            this.dmButton1.UseVisualStyleBackColor = false;
            this.dmButton1.Visible = false;
            this.dmButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // myButtonRTL
            // 
            this.myButtonRTL.BackColor = System.Drawing.Color.Transparent;
            this.myButtonRTL.DM_DisabledColor = System.Drawing.Color.Empty;
            this.myButtonRTL.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.myButtonRTL.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.myButtonRTL.DM_NormalColor = System.Drawing.Color.Coral;
            this.myButtonRTL.DM_Radius = 5;
            this.myButtonRTL.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myButtonRTL.Image = null;
            this.myButtonRTL.Location = new System.Drawing.Point(171, 161);
            this.myButtonRTL.Name = "myButtonRTL";
            this.myButtonRTL.Size = new System.Drawing.Size(89, 33);
            this.myButtonRTL.TabIndex = 84;
            this.myButtonRTL.Text = "回家";
            this.myButtonRTL.UseVisualStyleBackColor = false;
            this.myButtonRTL.Visible = false;
            this.myButtonRTL.Click += new System.EventHandler(this.myButton4_Click);
            // 
            // myButtonAuto
            // 
            this.myButtonAuto.BackColor = System.Drawing.Color.Transparent;
            this.myButtonAuto.DM_DisabledColor = System.Drawing.Color.Empty;
            this.myButtonAuto.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.myButtonAuto.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.myButtonAuto.DM_NormalColor = System.Drawing.Color.Coral;
            this.myButtonAuto.DM_Radius = 5;
            this.myButtonAuto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myButtonAuto.Image = null;
            this.myButtonAuto.Location = new System.Drawing.Point(171, 161);
            this.myButtonAuto.Name = "myButtonAuto";
            this.myButtonAuto.Size = new System.Drawing.Size(89, 33);
            this.myButtonAuto.TabIndex = 85;
            this.myButtonAuto.Text = "自动";
            this.myButtonAuto.UseVisualStyleBackColor = false;
            this.myButtonAuto.Visible = false;
            this.myButtonAuto.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // panelAttitude
            // 
            this.panelAttitude.AssociatedSplitter = null;
            this.panelAttitude.BackColor = System.Drawing.Color.Transparent;
            this.panelAttitude.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.panelAttitude.CaptionHeight = 27;
            this.panelAttitude.Controls.Add(this.hud1);
            this.panelAttitude.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panelAttitude.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panelAttitude.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panelAttitude.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelAttitude.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panelAttitude.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelAttitude.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelAttitude.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelAttitude.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panelAttitude.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panelAttitude.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelAttitude.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelAttitude.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panelAttitude.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAttitude.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelAttitude.Image = null;
            this.panelAttitude.Location = new System.Drawing.Point(3, 195);
            this.panelAttitude.MinimumSize = new System.Drawing.Size(27, 27);
            this.panelAttitude.Name = "panelAttitude";
            this.panelAttitude.ShowCaptionbar = false;
            this.panelAttitude.Size = new System.Drawing.Size(265, 225);
            this.panelAttitude.TabIndex = 90;
            this.panelAttitude.Text = "姿态";
            this.panelAttitude.ToolTipTextCloseIcon = null;
            this.panelAttitude.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelAttitude.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // hud1
            // 
            this.hud1.airspeed = 0F;
            this.hud1.alt = 0F;
            this.hud1.BackColor = System.Drawing.Color.Black;
            this.hud1.batterylevel = 0F;
            this.hud1.batteryon = false;
            this.hud1.batteryremaining = 0F;
            this.hud1.connected = false;
            this.hud1.current = 0F;
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("airspeed", this.bindingSourceHud, "airspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("alt", this.bindingSourceHud, "alt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batterylevel", this.bindingSourceHud, "battery_voltage", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batteryremaining", this.bindingSourceHud, "battery_remaining", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("connected", this.bindingSourceHud, "connected", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("current", this.bindingSourceHud, "current", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("datetime", this.bindingSourceHud, "datetime", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("disttowp", this.bindingSourceHud, "wp_dist", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("failsafe", this.bindingSourceHud, "failsafe", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix", this.bindingSourceHud, "gpsstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop", this.bindingSourceHud, "gpshdop", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundalt", this.bindingSourceHud, "HomeAlt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundcourse", this.bindingSourceHud, "groundcourse", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundspeed", this.bindingSourceHud, "groundspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("heading", this.bindingSourceHud, "yaw", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("linkqualitygcs", this.bindingSourceHud, "linkqualitygcs", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("message", this.bindingSourceHud, "messageHigh", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("messagetime", this.bindingSourceHud, "messageHighTime", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("mode", this.bindingSourceHud, "mode", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navpitch", this.bindingSourceHud, "nav_pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navroll", this.bindingSourceHud, "nav_roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("pitch", this.bindingSourceHud, "pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("roll", this.bindingSourceHud, "roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("status", this.bindingSourceHud, "armed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetalt", this.bindingSourceHud, "targetalt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetheading", this.bindingSourceHud, "nav_bearing", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetspeed", this.bindingSourceHud, "targetairspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("turnrate", this.bindingSourceHud, "turnrate", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("verticalspeed", this.bindingSourceHud, "verticalspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("wpno", this.bindingSourceHud, "wpno", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("xtrack_error", this.bindingSourceHud, "xtrack_error", true));
            this.hud1.datetime = new System.DateTime(((long)(0)));
            this.hud1.displayArmInfo = false;
            this.hud1.displayconninfo = false;
            this.hud1.displayFailesafeInfo = false;
            this.hud1.displayFlyMode = false;
            this.hud1.displaygps = false;
            this.hud1.displayMessage = false;
            this.hud1.displayxtrack = false;
            this.hud1.disttowp = 0F;
            this.hud1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hud1.failsafe = false;
            this.hud1.gpsfix = 0F;
            this.hud1.gpshdop = 0F;
            this.hud1.groundalt = 0F;
            this.hud1.groundcourse = 0F;
            this.hud1.groundspeed = 0F;
            this.hud1.heading = 0F;
            this.hud1.hudcolor = System.Drawing.Color.White;
            this.hud1.linkqualitygcs = 0F;
            this.hud1.Location = new System.Drawing.Point(0, 0);
            this.hud1.lowairspeed = false;
            this.hud1.lowgroundspeed = false;
            this.hud1.lowvoltagealert = false;
            this.hud1.message = "";
            this.hud1.messagetime = new System.DateTime(((long)(0)));
            this.hud1.mode = "Unknown";
            this.hud1.Name = "hud1";
            this.hud1.navpitch = 0F;
            this.hud1.navroll = 0F;
            this.hud1.opengl = true;
            this.hud1.pitch = 0F;
            this.hud1.roll = 0F;
            this.hud1.Russian = false;
            this.hud1.Size = new System.Drawing.Size(265, 225);
            this.hud1.status = false;
            this.hud1.streamjpg = null;
            this.hud1.TabIndex = 81;
            this.hud1.targetalt = 0F;
            this.hud1.targetheading = 0F;
            this.hud1.targetspeed = 0F;
            this.hud1.turnrate = 0F;
            this.hud1.UseOpenGL = true;
            this.hud1.verticalspeed = 0F;
            this.hud1.VSync = true;
            this.hud1.wpno = 0;
            this.hud1.xtrack_error = 0F;
            // 
            // panelStates
            // 
            this.panelStates.AssociatedSplitter = null;
            this.panelStates.BackColor = System.Drawing.Color.Transparent;
            this.panelStates.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.panelStates.CaptionHeight = 27;
            this.panelStates.Controls.Add(this.extQuickView1);
            this.panelStates.Controls.Add(this.extQuickView2);
            this.panelStates.Controls.Add(this.extQuickView5);
            this.panelStates.Controls.Add(this.extQuickView4);
            this.panelStates.Controls.Add(this.extQuickView3);
            this.panelStates.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panelStates.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panelStates.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panelStates.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelStates.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panelStates.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelStates.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelStates.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelStates.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panelStates.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panelStates.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelStates.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelStates.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panelStates.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStates.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelStates.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelStates.Image = null;
            this.panelStates.Location = new System.Drawing.Point(3, 3);
            this.panelStates.MinimumSize = new System.Drawing.Size(27, 27);
            this.panelStates.Name = "panelStates";
            this.panelStates.Size = new System.Drawing.Size(265, 192);
            this.panelStates.TabIndex = 89;
            this.panelStates.Text = "状态";
            this.panelStates.ToolTipTextCloseIcon = null;
            this.panelStates.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelStates.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Commands);
            this.tabPage2.Controls.Add(this.metroPanel1);
            this.tabPage2.Controls.Add(this.metroPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(271, 668);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "航线规划";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Commands
            // 
            this.Commands.AllowUserToAddRows = false;
            this.Commands.ColumnHeadersHeight = 30;
            this.Commands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Command,
            this.Param1,
            this.Param2,
            this.Param3,
            this.Param4,
            this.Lat,
            this.Lon,
            this.Alt,
            this.Delete,
            this.Up,
            this.Down,
            this.Grad,
            this.Dist,
            this.AZ});
            this.Commands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Commands.Location = new System.Drawing.Point(3, 303);
            this.Commands.Name = "Commands";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Commands.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Commands.RowHeadersWidth = 50;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Commands.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Commands.Size = new System.Drawing.Size(265, 362);
            this.Commands.TabIndex = 6;
            this.Commands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellContentClick);
            this.Commands.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellEndEdit);
            this.Commands.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Commands_EditingControlShowing);
            this.Commands.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_RowEnter);
            this.Commands.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Commands_RowsAdded);
            // 
            // Command
            // 
            this.Command.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Command.DefaultCellStyle = dataGridViewCellStyle1;
            this.Command.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Command.HeaderText = "命令";
            this.Command.MinimumWidth = 60;
            this.Command.Name = "Command";
            this.Command.ToolTipText = "APM Command";
            this.Command.Width = 60;
            // 
            // Param1
            // 
            this.Param1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Param1.HeaderText = "P1";
            this.Param1.MinimumWidth = 40;
            this.Param1.Name = "Param1";
            this.Param1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Param1.Width = 40;
            // 
            // Param2
            // 
            this.Param2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Param2.HeaderText = "P2";
            this.Param2.MinimumWidth = 40;
            this.Param2.Name = "Param2";
            this.Param2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Param2.Visible = false;
            this.Param2.Width = 40;
            // 
            // Param3
            // 
            this.Param3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Param3.HeaderText = "P3";
            this.Param3.MinimumWidth = 40;
            this.Param3.Name = "Param3";
            this.Param3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Param3.Visible = false;
            this.Param3.Width = 40;
            // 
            // Param4
            // 
            this.Param4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Param4.HeaderText = "P4";
            this.Param4.MinimumWidth = 40;
            this.Param4.Name = "Param4";
            this.Param4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Param4.Visible = false;
            this.Param4.Width = 40;
            // 
            // Lat
            // 
            this.Lat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Lat.HeaderText = "纬度";
            this.Lat.MinimumWidth = 60;
            this.Lat.Name = "Lat";
            this.Lat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Lat.Width = 60;
            // 
            // Lon
            // 
            this.Lon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Lon.HeaderText = "经度";
            this.Lon.MinimumWidth = 60;
            this.Lon.Name = "Lon";
            this.Lon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Lon.Width = 60;
            // 
            // Alt
            // 
            this.Alt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Alt.HeaderText = "高度";
            this.Alt.MinimumWidth = 60;
            this.Alt.Name = "Alt";
            this.Alt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Alt.Width = 60;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Delete.HeaderText = "删除";
            this.Delete.MinimumWidth = 50;
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            this.Delete.ToolTipText = "Delete the row";
            this.Delete.Visible = false;
            this.Delete.Width = 50;
            // 
            // Up
            // 
            this.Up.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Up.DefaultCellStyle = dataGridViewCellStyle2;
            this.Up.HeaderText = "上移";
            this.Up.Image = ((System.Drawing.Image)(resources.GetObject("Up.Image")));
            this.Up.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Up.MinimumWidth = 40;
            this.Up.Name = "Up";
            this.Up.ToolTipText = "Move the row UP";
            this.Up.Visible = false;
            this.Up.Width = 40;
            // 
            // Down
            // 
            this.Down.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Down.DefaultCellStyle = dataGridViewCellStyle3;
            this.Down.HeaderText = "下移";
            this.Down.Image = ((System.Drawing.Image)(resources.GetObject("Down.Image")));
            this.Down.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Down.MinimumWidth = 40;
            this.Down.Name = "Down";
            this.Down.ToolTipText = "Move the row down";
            this.Down.Visible = false;
            this.Down.Width = 40;
            // 
            // Grad
            // 
            this.Grad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Grad.HeaderText = "坡度";
            this.Grad.MinimumWidth = 50;
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Grad.Visible = false;
            this.Grad.Width = 50;
            // 
            // Dist
            // 
            this.Dist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Dist.HeaderText = "距离";
            this.Dist.MinimumWidth = 50;
            this.Dist.Name = "Dist";
            this.Dist.ReadOnly = true;
            this.Dist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Dist.Visible = false;
            this.Dist.Width = 50;
            // 
            // AZ
            // 
            this.AZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.AZ.HeaderText = "方位角";
            this.AZ.MinimumWidth = 50;
            this.AZ.Name = "AZ";
            this.AZ.ReadOnly = true;
            this.AZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AZ.Visible = false;
            this.AZ.Width = 50;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.panel2);
            this.metroPanel1.Controls.Add(this.coords1);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.DM_HorizontalScrollbarBarColor = true;
            this.metroPanel1.DM_HorizontalScrollbarDM_HighlightOnWheel = false;
            this.metroPanel1.DM_HorizontalScrollbarSize = 10;
            this.metroPanel1.DM_ThumbColor = System.Drawing.Color.Gray;
            this.metroPanel1.DM_ThumbNormalColor = System.Drawing.Color.Gray;
            this.metroPanel1.DM_UseBarColor = true;
            this.metroPanel1.DM_VerticalScrollbarBarColor = true;
            this.metroPanel1.DM_VerticalScrollbarDM_HighlightOnWheel = false;
            this.metroPanel1.DM_VerticalScrollbarSize = 10;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.Location = new System.Drawing.Point(3, 121);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(265, 182);
            this.metroPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.LBL_WPRad);
            this.panel2.Controls.Add(this.TXT_loiterrad);
            this.panel2.Controls.Add(this.TXT_DefaultAlt);
            this.panel2.Controls.Add(this.CHK_splinedefault);
            this.panel2.Controls.Add(this.LBL_defalutalt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TXT_WPRad);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.TXT_altwarn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 90);
            this.panel2.TabIndex = 67;
            // 
            // LBL_WPRad
            // 
            this.LBL_WPRad.AutoSize = true;
            this.LBL_WPRad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBL_WPRad.Location = new System.Drawing.Point(3, 2);
            this.LBL_WPRad.Name = "LBL_WPRad";
            this.LBL_WPRad.Size = new System.Drawing.Size(56, 17);
            this.LBL_WPRad.TabIndex = 59;
            this.LBL_WPRad.Text = "航点半径";
            // 
            // TXT_loiterrad
            // 
            this.TXT_loiterrad.Enabled = false;
            this.TXT_loiterrad.Location = new System.Drawing.Point(83, 19);
            this.TXT_loiterrad.Name = "TXT_loiterrad";
            this.TXT_loiterrad.Size = new System.Drawing.Size(36, 23);
            this.TXT_loiterrad.TabIndex = 56;
            this.TXT_loiterrad.Text = "45";
            // 
            // TXT_DefaultAlt
            // 
            this.TXT_DefaultAlt.Location = new System.Drawing.Point(151, 19);
            this.TXT_DefaultAlt.Name = "TXT_DefaultAlt";
            this.TXT_DefaultAlt.Size = new System.Drawing.Size(40, 23);
            this.TXT_DefaultAlt.TabIndex = 57;
            this.TXT_DefaultAlt.Text = "100";
            // 
            // CHK_splinedefault
            // 
            this.CHK_splinedefault.AutoSize = true;
            this.CHK_splinedefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHK_splinedefault.Location = new System.Drawing.Point(83, 60);
            this.CHK_splinedefault.Name = "CHK_splinedefault";
            this.CHK_splinedefault.Size = new System.Drawing.Size(51, 21);
            this.CHK_splinedefault.TabIndex = 65;
            this.CHK_splinedefault.Text = "曲线";
            this.CHK_splinedefault.UseVisualStyleBackColor = true;
            this.CHK_splinedefault.Visible = false;
            // 
            // LBL_defalutalt
            // 
            this.LBL_defalutalt.AutoSize = true;
            this.LBL_defalutalt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBL_defalutalt.Location = new System.Drawing.Point(145, 2);
            this.LBL_defalutalt.Name = "LBL_defalutalt";
            this.LBL_defalutalt.Size = new System.Drawing.Size(56, 17);
            this.LBL_defalutalt.TabIndex = 60;
            this.LBL_defalutalt.Text = "默认高度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(74, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "悬停半径";
            // 
            // TXT_WPRad
            // 
            this.TXT_WPRad.Location = new System.Drawing.Point(14, 19);
            this.TXT_WPRad.Name = "TXT_WPRad";
            this.TXT_WPRad.Size = new System.Drawing.Size(36, 23);
            this.TXT_WPRad.TabIndex = 55;
            this.TXT_WPRad.Text = "30";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(3, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 64;
            this.label17.Text = "高度警告";
            this.label17.Visible = false;
            // 
            // TXT_altwarn
            // 
            this.TXT_altwarn.Location = new System.Drawing.Point(12, 60);
            this.TXT_altwarn.Name = "TXT_altwarn";
            this.TXT_altwarn.Size = new System.Drawing.Size(40, 23);
            this.TXT_altwarn.TabIndex = 63;
            this.TXT_altwarn.Text = "0";
            this.TXT_altwarn.Visible = false;
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.AltUnit = "m";
            this.coords1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.coords1.Dock = System.Windows.Forms.DockStyle.Top;
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            this.coords1.Location = new System.Drawing.Point(0, 60);
            this.coords1.Name = "coords1";
            this.coords1.Size = new System.Drawing.Size(265, 70);
            this.coords1.TabIndex = 67;
            this.coords1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.TXT_homealt);
            this.panel1.Controls.Add(this.TXT_homelng);
            this.panel1.Controls.Add(this.TXT_homelat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 60);
            this.panel1.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(18, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.TabStop = true;
            this.label4.Text = "回家位置";
            this.label4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label4_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(149, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "高度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(149, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "经度";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(20, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 17);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "纬度";
            // 
            // TXT_homealt
            // 
            this.TXT_homealt.Location = new System.Drawing.Point(188, 3);
            this.TXT_homealt.Name = "TXT_homealt";
            this.TXT_homealt.Size = new System.Drawing.Size(65, 23);
            this.TXT_homealt.TabIndex = 14;
            this.TXT_homealt.Text = "100";
            this.TXT_homealt.TextChanged += new System.EventHandler(this.TXT_homealt_TextChanged);
            // 
            // TXT_homelng
            // 
            this.TXT_homelng.Location = new System.Drawing.Point(188, 30);
            this.TXT_homelng.Name = "TXT_homelng";
            this.TXT_homelng.Size = new System.Drawing.Size(65, 23);
            this.TXT_homelng.TabIndex = 13;
            this.TXT_homelng.Text = "114.2";
            this.TXT_homelng.TextChanged += new System.EventHandler(this.TXT_homelng_TextChanged);
            // 
            // TXT_homelat
            // 
            this.TXT_homelat.Location = new System.Drawing.Point(63, 29);
            this.TXT_homelat.Name = "TXT_homelat";
            this.TXT_homelat.Size = new System.Drawing.Size(65, 23);
            this.TXT_homelat.TabIndex = 12;
            this.TXT_homelat.Text = "22.7";
            this.TXT_homelat.TextChanged += new System.EventHandler(this.TXT_homelat_TextChanged);
            this.TXT_homelat.Enter += new System.EventHandler(this.TXT_homelat_Enter);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroDMButton2);
            this.metroPanel2.Controls.Add(this.metroDMButton1);
            this.metroPanel2.Controls.Add(this.metroDMButton9);
            this.metroPanel2.Controls.Add(this.metroDMButton8);
            this.metroPanel2.Controls.Add(this.metroDMButton7);
            this.metroPanel2.Controls.Add(this.dmButtonGridUI);
            this.metroPanel2.Controls.Add(this.dmButtonClreaGird);
            this.metroPanel2.Controls.Add(this.dmButtonCreatGrid);
            this.metroPanel2.DM_HorizontalScrollbarBarColor = true;
            this.metroPanel2.DM_HorizontalScrollbarDM_HighlightOnWheel = false;
            this.metroPanel2.DM_HorizontalScrollbarSize = 10;
            this.metroPanel2.DM_ThumbColor = System.Drawing.Color.Gray;
            this.metroPanel2.DM_ThumbNormalColor = System.Drawing.Color.Gray;
            this.metroPanel2.DM_UseBarColor = true;
            this.metroPanel2.DM_VerticalScrollbarBarColor = true;
            this.metroPanel2.DM_VerticalScrollbarDM_HighlightOnWheel = false;
            this.metroPanel2.DM_VerticalScrollbarSize = 10;
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(265, 118);
            this.metroPanel2.TabIndex = 7;
            // 
            // metroDMButton2
            // 
            this.metroDMButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton2.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton2.DownImage")));
            this.metroDMButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton2.Image = null;
            this.metroDMButton2.IsShowBorder = true;
            this.metroDMButton2.Location = new System.Drawing.Point(142, 63);
            this.metroDMButton2.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton2.MoveImage")));
            this.metroDMButton2.Name = "metroDMButton2";
            this.metroDMButton2.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton2.NormalImage")));
            this.metroDMButton2.Size = new System.Drawing.Size(108, 45);
            this.metroDMButton2.TabIndex = 92;
            this.metroDMButton2.Text = "下载航点";
            this.metroDMButton2.UseVisualStyleBackColor = false;
            // 
            // metroDMButton1
            // 
            this.metroDMButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton1.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton1.DownImage")));
            this.metroDMButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton1.Image = null;
            this.metroDMButton1.IsShowBorder = true;
            this.metroDMButton1.Location = new System.Drawing.Point(16, 63);
            this.metroDMButton1.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton1.MoveImage")));
            this.metroDMButton1.Name = "metroDMButton1";
            this.metroDMButton1.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton1.NormalImage")));
            this.metroDMButton1.Size = new System.Drawing.Size(108, 45);
            this.metroDMButton1.TabIndex = 91;
            this.metroDMButton1.Text = "上传航点";
            this.metroDMButton1.UseVisualStyleBackColor = false;
            // 
            // metroDMButton9
            // 
            this.metroDMButton9.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton9.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton9.DownImage")));
            this.metroDMButton9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton9.Image = null;
            this.metroDMButton9.IsShowBorder = true;
            this.metroDMButton9.Location = new System.Drawing.Point(180, 12);
            this.metroDMButton9.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton9.MoveImage")));
            this.metroDMButton9.Name = "metroDMButton9";
            this.metroDMButton9.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton9.NormalImage")));
            this.metroDMButton9.Size = new System.Drawing.Size(80, 45);
            this.metroDMButton9.TabIndex = 6;
            this.metroDMButton9.Text = "生成";
            this.metroToolTip1.SetToolTip(this.metroDMButton9, "在规划区域内生成航线");
            this.metroDMButton9.UseVisualStyleBackColor = false;
            this.metroDMButton9.Click += new System.EventHandler(this.metroDMButton9_Click);
            // 
            // metroDMButton8
            // 
            this.metroDMButton8.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton8.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton8.DownImage")));
            this.metroDMButton8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton8.Image = null;
            this.metroDMButton8.IsShowBorder = true;
            this.metroDMButton8.Location = new System.Drawing.Point(94, 12);
            this.metroDMButton8.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton8.MoveImage")));
            this.metroDMButton8.Name = "metroDMButton8";
            this.metroDMButton8.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton8.NormalImage")));
            this.metroDMButton8.Size = new System.Drawing.Size(80, 45);
            this.metroDMButton8.TabIndex = 5;
            this.metroDMButton8.Text = "清除";
            this.metroToolTip1.SetToolTip(this.metroDMButton8, "清除已经绘制的规划区域");
            this.metroDMButton8.UseVisualStyleBackColor = false;
            this.metroDMButton8.Click += new System.EventHandler(this.metroDMButton8_Click);
            // 
            // metroDMButton7
            // 
            this.metroDMButton7.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton7.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton7.DownImage")));
            this.metroDMButton7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton7.Image = null;
            this.metroDMButton7.IsShowBorder = true;
            this.metroDMButton7.Location = new System.Drawing.Point(8, 12);
            this.metroDMButton7.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton7.MoveImage")));
            this.metroDMButton7.Name = "metroDMButton7";
            this.metroDMButton7.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton7.NormalImage")));
            this.metroDMButton7.Size = new System.Drawing.Size(80, 45);
            this.metroDMButton7.TabIndex = 4;
            this.metroDMButton7.Text = "绘制";
            this.metroToolTip1.SetToolTip(this.metroDMButton7, "绘制规划区域用于生成航线");
            this.metroDMButton7.UseVisualStyleBackColor = false;
            this.metroDMButton7.Click += new System.EventHandler(this.metroDMButton7_Click);
            // 
            // dmButtonGridUI
            // 
            this.dmButtonGridUI.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonGridUI.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButtonGridUI.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmButtonGridUI.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmButtonGridUI.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmButtonGridUI.DM_Radius = 5;
            this.dmButtonGridUI.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButtonGridUI.Image = null;
            this.dmButtonGridUI.Location = new System.Drawing.Point(188, 39);
            this.dmButtonGridUI.Name = "dmButtonGridUI";
            this.dmButtonGridUI.Size = new System.Drawing.Size(72, 33);
            this.dmButtonGridUI.TabIndex = 90;
            this.dmButtonGridUI.Text = "自动生成";
            this.dmButtonGridUI.UseVisualStyleBackColor = false;
            this.dmButtonGridUI.Visible = false;
            this.dmButtonGridUI.Click += new System.EventHandler(this.dmButtonGridUI_Click);
            // 
            // dmButtonClreaGird
            // 
            this.dmButtonClreaGird.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonClreaGird.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButtonClreaGird.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmButtonClreaGird.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmButtonClreaGird.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmButtonClreaGird.DM_Radius = 5;
            this.dmButtonClreaGird.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButtonClreaGird.Image = null;
            this.dmButtonClreaGird.Location = new System.Drawing.Point(188, 39);
            this.dmButtonClreaGird.Name = "dmButtonClreaGird";
            this.dmButtonClreaGird.Size = new System.Drawing.Size(72, 33);
            this.dmButtonClreaGird.TabIndex = 89;
            this.dmButtonClreaGird.Text = "清除区域";
            this.dmButtonClreaGird.UseVisualStyleBackColor = false;
            this.dmButtonClreaGird.Visible = false;
            this.dmButtonClreaGird.Click += new System.EventHandler(this.dmButtonClreaGird_Click);
            // 
            // dmButtonCreatGrid
            // 
            this.dmButtonCreatGrid.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonCreatGrid.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButtonCreatGrid.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmButtonCreatGrid.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmButtonCreatGrid.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmButtonCreatGrid.DM_Radius = 5;
            this.dmButtonCreatGrid.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButtonCreatGrid.Image = null;
            this.dmButtonCreatGrid.Location = new System.Drawing.Point(188, 39);
            this.dmButtonCreatGrid.Name = "dmButtonCreatGrid";
            this.dmButtonCreatGrid.Size = new System.Drawing.Size(72, 33);
            this.dmButtonCreatGrid.TabIndex = 88;
            this.dmButtonCreatGrid.Text = "绘制区域";
            this.dmButtonCreatGrid.UseVisualStyleBackColor = false;
            this.dmButtonCreatGrid.Visible = false;
            this.dmButtonCreatGrid.Click += new System.EventHandler(this.addPolygonPointToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(271, 668);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "日志下载";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.AssociatedSplitter = null;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.panel5.CaptionHeight = 27;
            this.panel5.Controls.Add(this.metroDMButton18);
            this.panel5.Controls.Add(this.metroDMButton17);
            this.panel5.Controls.Add(this.metroDMButton16);
            this.panel5.Controls.Add(this.dmButton13);
            this.panel5.Controls.Add(this.dmButton14);
            this.panel5.Controls.Add(this.dmButton15);
            this.panel5.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel5.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panel5.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panel5.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel5.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panel5.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel5.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel5.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel5.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panel5.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panel5.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panel5.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel5.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Image = null;
            this.panel5.Location = new System.Drawing.Point(3, 233);
            this.panel5.MinimumSize = new System.Drawing.Size(27, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 107);
            this.panel5.TabIndex = 92;
            this.panel5.Text = "相机";
            this.panel5.ToolTipTextCloseIcon = null;
            this.panel5.ToolTipTextExpandIconPanelCollapsed = null;
            this.panel5.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // metroDMButton18
            // 
            this.metroDMButton18.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton18.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton18.DownImage")));
            this.metroDMButton18.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton18.Image = null;
            this.metroDMButton18.IsShowBorder = true;
            this.metroDMButton18.Location = new System.Drawing.Point(180, 42);
            this.metroDMButton18.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton18.MoveImage")));
            this.metroDMButton18.Name = "metroDMButton18";
            this.metroDMButton18.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton18.NormalImage")));
            this.metroDMButton18.Size = new System.Drawing.Size(80, 45);
            this.metroDMButton18.TabIndex = 93;
            this.metroDMButton18.Text = "开关";
            this.metroDMButton18.UseVisualStyleBackColor = false;
            this.metroDMButton18.Click += new System.EventHandler(this.metroDMButton18_Click);
            // 
            // metroDMButton17
            // 
            this.metroDMButton17.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton17.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton17.DownImage")));
            this.metroDMButton17.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton17.Image = null;
            this.metroDMButton17.IsShowBorder = true;
            this.metroDMButton17.Location = new System.Drawing.Point(94, 42);
            this.metroDMButton17.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton17.MoveImage")));
            this.metroDMButton17.Name = "metroDMButton17";
            this.metroDMButton17.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton17.NormalImage")));
            this.metroDMButton17.Size = new System.Drawing.Size(80, 45);
            this.metroDMButton17.TabIndex = 92;
            this.metroDMButton17.Text = "锁定";
            this.metroDMButton17.UseVisualStyleBackColor = false;
            this.metroDMButton17.Click += new System.EventHandler(this.metroDMButton17_Click);
            // 
            // metroDMButton16
            // 
            this.metroDMButton16.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton16.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton16.DownImage")));
            this.metroDMButton16.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton16.Image = null;
            this.metroDMButton16.IsShowBorder = true;
            this.metroDMButton16.Location = new System.Drawing.Point(8, 42);
            this.metroDMButton16.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton16.MoveImage")));
            this.metroDMButton16.Name = "metroDMButton16";
            this.metroDMButton16.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton16.NormalImage")));
            this.metroDMButton16.Size = new System.Drawing.Size(80, 45);
            this.metroDMButton16.TabIndex = 91;
            this.metroDMButton16.Text = "拍照";
            this.metroDMButton16.UseVisualStyleBackColor = false;
            this.metroDMButton16.Click += new System.EventHandler(this.metroDMButton16_Click);
            // 
            // dmButton13
            // 
            this.dmButton13.BackColor = System.Drawing.Color.Transparent;
            this.dmButton13.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton13.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmButton13.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmButton13.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmButton13.DM_Radius = 5;
            this.dmButton13.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButton13.Image = null;
            this.dmButton13.Location = new System.Drawing.Point(161, 148);
            this.dmButton13.Name = "dmButton13";
            this.dmButton13.Size = new System.Drawing.Size(72, 33);
            this.dmButton13.TabIndex = 90;
            this.dmButton13.Text = "生成POS";
            this.dmButton13.UseVisualStyleBackColor = false;
            this.dmButton13.Visible = false;
            // 
            // dmButton14
            // 
            this.dmButton14.BackColor = System.Drawing.Color.Transparent;
            this.dmButton14.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton14.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmButton14.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmButton14.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmButton14.DM_Radius = 5;
            this.dmButton14.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButton14.Image = null;
            this.dmButton14.Location = new System.Drawing.Point(161, 148);
            this.dmButton14.Name = "dmButton14";
            this.dmButton14.Size = new System.Drawing.Size(72, 33);
            this.dmButton14.TabIndex = 89;
            this.dmButton14.Text = "下载日志";
            this.dmButton14.UseVisualStyleBackColor = false;
            this.dmButton14.Visible = false;
            // 
            // dmButton15
            // 
            this.dmButton15.BackColor = System.Drawing.Color.Transparent;
            this.dmButton15.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton15.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dmButton15.DM_MoveColor = System.Drawing.Color.Gray;
            this.dmButton15.DM_NormalColor = System.Drawing.Color.LightGray;
            this.dmButton15.DM_Radius = 5;
            this.dmButton15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButton15.Image = null;
            this.dmButton15.Location = new System.Drawing.Point(161, 147);
            this.dmButton15.Name = "dmButton15";
            this.dmButton15.Size = new System.Drawing.Size(55, 33);
            this.dmButton15.TabIndex = 82;
            this.dmButton15.Text = "切点";
            this.metroToolTip1.SetToolTip(this.dmButton15, "航点切换");
            this.dmButton15.UseVisualStyleBackColor = false;
            this.dmButton15.Visible = false;
            // 
            // panel4
            // 
            this.panel4.AssociatedSplitter = null;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.panel4.CaptionHeight = 27;
            this.panel4.Controls.Add(this.metroDMButton15);
            this.panel4.Controls.Add(this.dmButton10);
            this.panel4.Controls.Add(this.dmButton11);
            this.panel4.Controls.Add(this.dmButton12);
            this.panel4.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel4.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panel4.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panel4.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel4.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panel4.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel4.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel4.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel4.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panel4.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panel4.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panel4.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel4.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Image = null;
            this.panel4.Location = new System.Drawing.Point(3, 118);
            this.panel4.MinimumSize = new System.Drawing.Size(27, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 115);
            this.panel4.TabIndex = 91;
            this.panel4.Text = "RTK";
            this.panel4.ToolTipTextCloseIcon = null;
            this.panel4.ToolTipTextExpandIconPanelCollapsed = null;
            this.panel4.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // metroDMButton15
            // 
            this.metroDMButton15.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton15.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton15.DownImage")));
            this.metroDMButton15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton15.Image = null;
            this.metroDMButton15.IsShowBorder = true;
            this.metroDMButton15.Location = new System.Drawing.Point(16, 51);
            this.metroDMButton15.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton15.MoveImage")));
            this.metroDMButton15.Name = "metroDMButton15";
            this.metroDMButton15.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton15.NormalImage")));
            this.metroDMButton15.Size = new System.Drawing.Size(108, 45);
            this.metroDMButton15.TabIndex = 91;
            this.metroDMButton15.Text = "RTK";
            this.metroDMButton15.UseVisualStyleBackColor = false;
            this.metroDMButton15.Click += new System.EventHandler(this.metroDMButton15_Click);
            // 
            // dmButton10
            // 
            this.dmButton10.BackColor = System.Drawing.Color.Transparent;
            this.dmButton10.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton10.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmButton10.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmButton10.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmButton10.DM_Radius = 5;
            this.dmButton10.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButton10.Image = null;
            this.dmButton10.Location = new System.Drawing.Point(161, 148);
            this.dmButton10.Name = "dmButton10";
            this.dmButton10.Size = new System.Drawing.Size(72, 33);
            this.dmButton10.TabIndex = 90;
            this.dmButton10.Text = "生成POS";
            this.dmButton10.UseVisualStyleBackColor = false;
            this.dmButton10.Visible = false;
            // 
            // dmButton11
            // 
            this.dmButton11.BackColor = System.Drawing.Color.Transparent;
            this.dmButton11.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton11.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmButton11.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmButton11.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmButton11.DM_Radius = 5;
            this.dmButton11.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButton11.Image = null;
            this.dmButton11.Location = new System.Drawing.Point(161, 148);
            this.dmButton11.Name = "dmButton11";
            this.dmButton11.Size = new System.Drawing.Size(72, 33);
            this.dmButton11.TabIndex = 89;
            this.dmButton11.Text = "下载日志";
            this.dmButton11.UseVisualStyleBackColor = false;
            this.dmButton11.Visible = false;
            // 
            // dmButton12
            // 
            this.dmButton12.BackColor = System.Drawing.Color.Transparent;
            this.dmButton12.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton12.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dmButton12.DM_MoveColor = System.Drawing.Color.Gray;
            this.dmButton12.DM_NormalColor = System.Drawing.Color.LightGray;
            this.dmButton12.DM_Radius = 5;
            this.dmButton12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButton12.Image = null;
            this.dmButton12.Location = new System.Drawing.Point(161, 147);
            this.dmButton12.Name = "dmButton12";
            this.dmButton12.Size = new System.Drawing.Size(55, 33);
            this.dmButton12.TabIndex = 82;
            this.dmButton12.Text = "切点";
            this.metroToolTip1.SetToolTip(this.dmButton12, "航点切换");
            this.dmButton12.UseVisualStyleBackColor = false;
            this.dmButton12.Visible = false;
            // 
            // panel3
            // 
            this.panel3.AssociatedSplitter = null;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.panel3.CaptionHeight = 27;
            this.panel3.Controls.Add(this.metroDMButton11);
            this.panel3.Controls.Add(this.metroDMButton10);
            this.panel3.Controls.Add(this.dmButton8);
            this.panel3.Controls.Add(this.dmButton7);
            this.panel3.Controls.Add(this.dmButtonChangeWP);
            this.panel3.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel3.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panel3.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panel3.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel3.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panel3.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel3.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel3.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panel3.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panel3.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panel3.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel3.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Image = null;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.MinimumSize = new System.Drawing.Size(27, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 115);
            this.panel3.TabIndex = 90;
            this.panel3.Text = "日志";
            this.panel3.ToolTipTextCloseIcon = null;
            this.panel3.ToolTipTextExpandIconPanelCollapsed = null;
            this.panel3.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // metroDMButton11
            // 
            this.metroDMButton11.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton11.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton11.DownImage")));
            this.metroDMButton11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton11.Image = null;
            this.metroDMButton11.IsShowBorder = true;
            this.metroDMButton11.Location = new System.Drawing.Point(143, 47);
            this.metroDMButton11.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton11.MoveImage")));
            this.metroDMButton11.Name = "metroDMButton11";
            this.metroDMButton11.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton11.NormalImage")));
            this.metroDMButton11.Size = new System.Drawing.Size(108, 45);
            this.metroDMButton11.TabIndex = 91;
            this.metroDMButton11.Text = "生成POS";
            this.metroDMButton11.UseVisualStyleBackColor = false;
            this.metroDMButton11.Click += new System.EventHandler(this.metroDMButton11_Click);
            // 
            // metroDMButton10
            // 
            this.metroDMButton10.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton10.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton10.DownImage")));
            this.metroDMButton10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton10.Image = null;
            this.metroDMButton10.IsShowBorder = true;
            this.metroDMButton10.Location = new System.Drawing.Point(16, 47);
            this.metroDMButton10.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton10.MoveImage")));
            this.metroDMButton10.Name = "metroDMButton10";
            this.metroDMButton10.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton10.NormalImage")));
            this.metroDMButton10.Size = new System.Drawing.Size(108, 45);
            this.metroDMButton10.TabIndex = 4;
            this.metroDMButton10.Text = "下载日志";
            this.metroDMButton10.UseVisualStyleBackColor = false;
            this.metroDMButton10.Click += new System.EventHandler(this.metroDMButton10_Click);
            // 
            // dmButton8
            // 
            this.dmButton8.BackColor = System.Drawing.Color.Transparent;
            this.dmButton8.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton8.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmButton8.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmButton8.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmButton8.DM_Radius = 5;
            this.dmButton8.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButton8.Image = null;
            this.dmButton8.Location = new System.Drawing.Point(161, 148);
            this.dmButton8.Name = "dmButton8";
            this.dmButton8.Size = new System.Drawing.Size(72, 33);
            this.dmButton8.TabIndex = 90;
            this.dmButton8.Text = "生成POS";
            this.dmButton8.UseVisualStyleBackColor = false;
            this.dmButton8.Visible = false;
            this.dmButton8.Click += new System.EventHandler(this.dmButton8_Click);
            // 
            // dmButton7
            // 
            this.dmButton7.BackColor = System.Drawing.Color.Transparent;
            this.dmButton7.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton7.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmButton7.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmButton7.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmButton7.DM_Radius = 5;
            this.dmButton7.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButton7.Image = null;
            this.dmButton7.Location = new System.Drawing.Point(161, 148);
            this.dmButton7.Name = "dmButton7";
            this.dmButton7.Size = new System.Drawing.Size(72, 33);
            this.dmButton7.TabIndex = 89;
            this.dmButton7.Text = "下载日志";
            this.dmButton7.UseVisualStyleBackColor = false;
            this.dmButton7.Visible = false;
            this.dmButton7.Click += new System.EventHandler(this.dmButton7_Click);
            // 
            // dmButtonChangeWP
            // 
            this.dmButtonChangeWP.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonChangeWP.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButtonChangeWP.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dmButtonChangeWP.DM_MoveColor = System.Drawing.Color.Gray;
            this.dmButtonChangeWP.DM_NormalColor = System.Drawing.Color.LightGray;
            this.dmButtonChangeWP.DM_Radius = 5;
            this.dmButtonChangeWP.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmButtonChangeWP.Image = null;
            this.dmButtonChangeWP.Location = new System.Drawing.Point(161, 147);
            this.dmButtonChangeWP.Name = "dmButtonChangeWP";
            this.dmButtonChangeWP.Size = new System.Drawing.Size(55, 33);
            this.dmButtonChangeWP.TabIndex = 82;
            this.dmButtonChangeWP.Text = "切点";
            this.metroToolTip1.SetToolTip(this.dmButtonChangeWP, "航点切换");
            this.dmButtonChangeWP.UseVisualStyleBackColor = false;
            this.dmButtonChangeWP.Visible = false;
            this.dmButtonChangeWP.Click += new System.EventHandler(this.myButtonChangeWP_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.dmButtonMinLightFormMin);
            this.metroTile1.Controls.Add(this.dmButtonCloseLightFormClose);
            this.metroTile1.DM_TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.DM_TileTextDM_FontSize = DMSkin.Metro.MetroTileTextSize.Tall;
            this.metroTile1.DM_TileTextDM_FontWeight = DMSkin.Metro.MetroTileTextWeight.Bold;
            this.metroTile1.DM_UseSelectable = true;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1216, 30);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "ArduDrone";
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            this.metroTile1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroTile1_MouseDown);
            this.metroTile1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroTile1_MouseMove);
            this.metroTile1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.metroTile1_MouseUp);
            // 
            // dmButtonMinLightFormMin
            // 
            this.dmButtonMinLightFormMin.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonMinLightFormMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.dmButtonMinLightFormMin.Location = new System.Drawing.Point(1156, 0);
            this.dmButtonMinLightFormMin.Name = "dmButtonMinLightFormMin";
            this.dmButtonMinLightFormMin.Size = new System.Drawing.Size(30, 30);
            this.dmButtonMinLightFormMin.TabIndex = 1;
            this.dmButtonMinLightFormMin.Click += new System.EventHandler(this.dmButtonMinLightFormMin_Click);
            // 
            // dmButtonCloseLightFormClose
            // 
            this.dmButtonCloseLightFormClose.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonCloseLightFormClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.dmButtonCloseLightFormClose.Location = new System.Drawing.Point(1186, 0);
            this.dmButtonCloseLightFormClose.MaximumSize = new System.Drawing.Size(30, 27);
            this.dmButtonCloseLightFormClose.MinimumSize = new System.Drawing.Size(30, 27);
            this.dmButtonCloseLightFormClose.Name = "dmButtonCloseLightFormClose";
            this.dmButtonCloseLightFormClose.Size = new System.Drawing.Size(30, 27);
            this.dmButtonCloseLightFormClose.TabIndex = 0;
            this.dmButtonCloseLightFormClose.Click += new System.EventHandler(this.dmButtonCloseLightFormClose_Click);
            // 
            // timerTileDoubleClick
            // 
            this.timerTileDoubleClick.Tick += new System.EventHandler(this.timerTileDoubleClick_Tick);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = DMSkin.Metro.MetroColorStyle.Black;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = DMSkin.Metro.MetroThemeStyle.Default;
            // 
            // dmButtonZoomOut
            // 
            this.dmButtonZoomOut.BackColor = System.Drawing.Color.LightGray;
            this.dmButtonZoomOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dmButtonZoomOut.BackgroundImage")));
            this.dmButtonZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dmButtonZoomOut.DM_DisabledColor = System.Drawing.Color.Transparent;
            this.dmButtonZoomOut.DM_DownColor = System.Drawing.Color.Transparent;
            this.dmButtonZoomOut.DM_MoveColor = System.Drawing.Color.Transparent;
            this.dmButtonZoomOut.DM_NormalColor = System.Drawing.Color.Transparent;
            this.dmButtonZoomOut.DM_Radius = 5;
            this.dmButtonZoomOut.Image = null;
            this.dmButtonZoomOut.Location = new System.Drawing.Point(475, 7);
            this.dmButtonZoomOut.Name = "dmButtonZoomOut";
            this.dmButtonZoomOut.Size = new System.Drawing.Size(32, 32);
            this.dmButtonZoomOut.TabIndex = 93;
            this.dmButtonZoomOut.Text = "";
            this.metroToolTip1.SetToolTip(this.dmButtonZoomOut, "地图缩小");
            this.dmButtonZoomOut.UseVisualStyleBackColor = false;
            this.dmButtonZoomOut.Click += new System.EventHandler(this.dmButtonZoomOut_Click);
            this.dmButtonZoomOut.MouseEnter += new System.EventHandler(this.dmButton5_MouseEnter);
            this.dmButtonZoomOut.MouseLeave += new System.EventHandler(this.dmButton5_MouseLeave);
            // 
            // dmButtonZoomIn
            // 
            this.dmButtonZoomIn.BackColor = System.Drawing.Color.LightGray;
            this.dmButtonZoomIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dmButtonZoomIn.BackgroundImage")));
            this.dmButtonZoomIn.DM_DisabledColor = System.Drawing.Color.Transparent;
            this.dmButtonZoomIn.DM_DownColor = System.Drawing.Color.Transparent;
            this.dmButtonZoomIn.DM_MoveColor = System.Drawing.Color.Transparent;
            this.dmButtonZoomIn.DM_NormalColor = System.Drawing.Color.Transparent;
            this.dmButtonZoomIn.DM_Radius = 5;
            this.dmButtonZoomIn.Image = null;
            this.dmButtonZoomIn.Location = new System.Drawing.Point(429, 7);
            this.dmButtonZoomIn.Name = "dmButtonZoomIn";
            this.dmButtonZoomIn.Size = new System.Drawing.Size(32, 32);
            this.dmButtonZoomIn.TabIndex = 92;
            this.dmButtonZoomIn.Text = "";
            this.metroToolTip1.SetToolTip(this.dmButtonZoomIn, "地图放大");
            this.dmButtonZoomIn.UseVisualStyleBackColor = false;
            this.dmButtonZoomIn.Click += new System.EventHandler(this.dmButtonZoomIn_Click);
            this.dmButtonZoomIn.MouseEnter += new System.EventHandler(this.dmButton5_MouseEnter);
            this.dmButtonZoomIn.MouseLeave += new System.EventHandler(this.dmButton5_MouseLeave);
            // 
            // dmButton5
            // 
            this.dmButton5.BackColor = System.Drawing.Color.LightGray;
            this.dmButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dmButton5.BackgroundImage")));
            this.dmButton5.DM_DisabledColor = System.Drawing.Color.Transparent;
            this.dmButton5.DM_DownColor = System.Drawing.Color.Transparent;
            this.dmButton5.DM_MoveColor = System.Drawing.Color.Transparent;
            this.dmButton5.DM_NormalColor = System.Drawing.Color.Transparent;
            this.dmButton5.DM_Radius = 5;
            this.dmButton5.Image = null;
            this.dmButton5.Location = new System.Drawing.Point(271, 7);
            this.dmButton5.Name = "dmButton5";
            this.dmButton5.Size = new System.Drawing.Size(32, 32);
            this.dmButton5.TabIndex = 91;
            this.dmButton5.Text = "";
            this.metroToolTip1.SetToolTip(this.dmButton5, "回家点居中");
            this.dmButton5.UseVisualStyleBackColor = false;
            this.dmButton5.Click += new System.EventHandler(this.dmButton5_Click);
            this.dmButton5.MouseEnter += new System.EventHandler(this.dmButton5_MouseEnter);
            this.dmButton5.MouseLeave += new System.EventHandler(this.dmButton5_MouseLeave);
            // 
            // dmButton6
            // 
            this.dmButton6.BackColor = System.Drawing.Color.LightGray;
            this.dmButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dmButton6.BackgroundImage")));
            this.dmButton6.DM_DisabledColor = System.Drawing.Color.Transparent;
            this.dmButton6.DM_DownColor = System.Drawing.Color.Transparent;
            this.dmButton6.DM_MoveColor = System.Drawing.Color.Transparent;
            this.dmButton6.DM_NormalColor = System.Drawing.Color.Transparent;
            this.dmButton6.DM_Radius = 5;
            this.dmButton6.Image = null;
            this.dmButton6.Location = new System.Drawing.Point(314, 7);
            this.dmButton6.Name = "dmButton6";
            this.dmButton6.Size = new System.Drawing.Size(32, 32);
            this.dmButton6.TabIndex = 90;
            this.dmButton6.Text = "";
            this.metroToolTip1.SetToolTip(this.dmButton6, "飞行器居中");
            this.dmButton6.UseVisualStyleBackColor = false;
            this.dmButton6.Click += new System.EventHandler(this.dmButton6_Click);
            this.dmButton6.MouseEnter += new System.EventHandler(this.dmButton5_MouseEnter);
            this.dmButton6.MouseLeave += new System.EventHandler(this.dmButton5_MouseLeave);
            // 
            // CMB_setwp
            // 
            this.CMB_setwp.DM_UseSelectable = true;
            this.CMB_setwp.FormattingEnabled = true;
            this.CMB_setwp.ItemHeight = 24;
            this.CMB_setwp.Location = new System.Drawing.Point(43, 8);
            this.CMB_setwp.Name = "CMB_setwp";
            this.CMB_setwp.Size = new System.Drawing.Size(89, 30);
            this.CMB_setwp.TabIndex = 83;
            this.metroToolTip1.SetToolTip(this.CMB_setwp, "航点号");
            this.CMB_setwp.Click += new System.EventHandler(this.CMB_setwp_Click);
            // 
            // metroComboBoxMapType
            // 
            this.metroComboBoxMapType.DM_UseSelectable = true;
            this.metroComboBoxMapType.FormattingEnabled = true;
            this.metroComboBoxMapType.ItemHeight = 24;
            this.metroComboBoxMapType.Items.AddRange(new object[] {
            "高德卫星",
            "高德地图"});
            this.metroComboBoxMapType.Location = new System.Drawing.Point(523, 8);
            this.metroComboBoxMapType.Name = "metroComboBoxMapType";
            this.metroComboBoxMapType.Size = new System.Drawing.Size(92, 30);
            this.metroComboBoxMapType.TabIndex = 94;
            this.metroToolTip1.SetToolTip(this.metroComboBoxMapType, "地图类型切换");
            this.metroComboBoxMapType.SelectedValueChanged += new System.EventHandler(this.metroComboBoxMapType_SelectedValueChanged);
            // 
            // dmLabel5
            // 
            this.dmLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dmLabel5.BackColor = System.Drawing.Color.Transparent;
            this.dmLabel5.DM_Color = System.Drawing.Color.Black;
            this.dmLabel5.DM_Font_Size = 18F;
            this.dmLabel5.DM_Key = DMSkin.Controls.DMLabelKey.圆_问;
            this.dmLabel5.DM_Text = "";
            this.dmLabel5.Location = new System.Drawing.Point(1180, 8);
            this.dmLabel5.Name = "dmLabel5";
            this.dmLabel5.Size = new System.Drawing.Size(32, 30);
            this.dmLabel5.TabIndex = 100;
            this.dmLabel5.Text = "dmLabel5";
            this.metroToolTip1.SetToolTip(this.dmLabel5, "帮助");
            this.dmLabel5.Click += new System.EventHandler(this.dmLabel5_Click);
            // 
            // dmButton9
            // 
            this.dmButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dmButton9.BackColor = System.Drawing.Color.LightGray;
            this.dmButton9.BackgroundImage = global::MissionPlanner.Properties.Resources.max;
            this.dmButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dmButton9.DM_DisabledColor = System.Drawing.Color.Transparent;
            this.dmButton9.DM_DownColor = System.Drawing.Color.Transparent;
            this.dmButton9.DM_MoveColor = System.Drawing.Color.Transparent;
            this.dmButton9.DM_NormalColor = System.Drawing.Color.Transparent;
            this.dmButton9.DM_Radius = 5;
            this.dmButton9.Image = null;
            this.dmButton9.Location = new System.Drawing.Point(1142, 8);
            this.dmButton9.Name = "dmButton9";
            this.dmButton9.Size = new System.Drawing.Size(32, 32);
            this.dmButton9.TabIndex = 101;
            this.dmButton9.Text = "";
            this.metroToolTip1.SetToolTip(this.dmButton9, "最大化");
            this.dmButton9.UseVisualStyleBackColor = false;
            this.dmButton9.Click += new System.EventHandler(this.dmButton9_Click);
            // 
            // metroComboBoxSPort
            // 
            this.metroComboBoxSPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboBoxSPort.DM_UseSelectable = true;
            this.metroComboBoxSPort.FormattingEnabled = true;
            this.metroComboBoxSPort.ItemHeight = 24;
            this.metroComboBoxSPort.Location = new System.Drawing.Point(998, 8);
            this.metroComboBoxSPort.Name = "metroComboBoxSPort";
            this.metroComboBoxSPort.Size = new System.Drawing.Size(69, 30);
            this.metroComboBoxSPort.TabIndex = 102;
            this.metroToolTip1.SetToolTip(this.metroComboBoxSPort, "端口选择");
            // 
            // panelControl
            // 
            this.panelControl.AssociatedSplitter = null;
            this.panelControl.BackColor = System.Drawing.Color.Transparent;
            this.panelControl.CaptionFont = new System.Drawing.Font("Microsoft YaHei", 11.75F, System.Drawing.FontStyle.Bold);
            this.panelControl.CaptionHeight = 27;
            this.panelControl.Controls.Add(this.metroComboBox1);
            this.panelControl.Controls.Add(this.metroComboBoxSPort);
            this.panelControl.Controls.Add(this.dmButton9);
            this.panelControl.Controls.Add(this.metroDMButton12);
            this.panelControl.Controls.Add(this.dmLabel5);
            this.panelControl.Controls.Add(this.dmLabel3);
            this.panelControl.Controls.Add(this.dmLabel2);
            this.panelControl.Controls.Add(this.labelHomeDisToPlane);
            this.panelControl.Controls.Add(this.dmLabel1);
            this.panelControl.Controls.Add(this.metroComboBoxMapType);
            this.panelControl.Controls.Add(this.dmButtonZoomOut);
            this.panelControl.Controls.Add(this.dmButtonZoomIn);
            this.panelControl.Controls.Add(this.dmButton5);
            this.panelControl.Controls.Add(this.dmButton6);
            this.panelControl.Controls.Add(this.BUT_Connect);
            this.panelControl.Controls.Add(this.CMB_setwp);
            this.panelControl.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panelControl.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panelControl.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panelControl.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelControl.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panelControl.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelControl.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelControl.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelControl.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panelControl.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panelControl.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelControl.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelControl.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelControl.Image = null;
            this.panelControl.Location = new System.Drawing.Point(0, 30);
            this.panelControl.MinimumSize = new System.Drawing.Size(27, 27);
            this.panelControl.Name = "panelControl";
            this.panelControl.ShowCaptionbar = false;
            this.panelControl.Size = new System.Drawing.Size(1216, 42);
            this.panelControl.TabIndex = 1;
            this.panelControl.Text = "panel2";
            this.panelControl.ToolTipTextCloseIcon = null;
            this.panelControl.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelControl.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // metroDMButton12
            // 
            this.metroDMButton12.BackColor = System.Drawing.Color.Transparent;
            this.metroDMButton12.DownImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton12.DownImage")));
            this.metroDMButton12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.metroDMButton12.Image = null;
            this.metroDMButton12.IsShowBorder = true;
            this.metroDMButton12.Location = new System.Drawing.Point(148, 6);
            this.metroDMButton12.MoveImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton12.MoveImage")));
            this.metroDMButton12.Name = "metroDMButton12";
            this.metroDMButton12.NormalImage = ((System.Drawing.Image)(resources.GetObject("metroDMButton12.NormalImage")));
            this.metroDMButton12.Size = new System.Drawing.Size(76, 35);
            this.metroDMButton12.TabIndex = 92;
            this.metroDMButton12.Text = "切点";
            this.metroDMButton12.UseVisualStyleBackColor = false;
            this.metroDMButton12.Click += new System.EventHandler(this.metroDMButton12_Click);
            // 
            // dmLabel3
            // 
            this.dmLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dmLabel3.DM_Color = System.Drawing.Color.Black;
            this.dmLabel3.DM_Font_Size = 18F;
            this.dmLabel3.DM_Key = DMSkin.Controls.DMLabelKey.飞机;
            this.dmLabel3.DM_Text = "";
            this.dmLabel3.Location = new System.Drawing.Point(10, 8);
            this.dmLabel3.Name = "dmLabel3";
            this.dmLabel3.Size = new System.Drawing.Size(32, 32);
            this.dmLabel3.TabIndex = 98;
            this.dmLabel3.Text = "dmLabel3";
            // 
            // dmLabel2
            // 
            this.dmLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dmLabel2.DM_Color = System.Drawing.Color.Black;
            this.dmLabel2.DM_Font_Size = 18F;
            this.dmLabel2.DM_Key = DMSkin.Controls.DMLabelKey.定位;
            this.dmLabel2.DM_Text = "";
            this.dmLabel2.Location = new System.Drawing.Point(240, 8);
            this.dmLabel2.Name = "dmLabel2";
            this.dmLabel2.Size = new System.Drawing.Size(32, 32);
            this.dmLabel2.TabIndex = 97;
            this.dmLabel2.Text = "dmLabel2";
            // 
            // labelHomeDisToPlane
            // 
            this.labelHomeDisToPlane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHomeDisToPlane.AutoSize = true;
            this.labelHomeDisToPlane.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHomeDisToPlane.Location = new System.Drawing.Point(788, 14);
            this.labelHomeDisToPlane.Name = "labelHomeDisToPlane";
            this.labelHomeDisToPlane.Size = new System.Drawing.Size(79, 22);
            this.labelHomeDisToPlane.TabIndex = 96;
            this.labelHomeDisToPlane.Text = "回家距离:";
            // 
            // dmLabel1
            // 
            this.dmLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dmLabel1.DM_Color = System.Drawing.Color.Black;
            this.dmLabel1.DM_Font_Size = 18F;
            this.dmLabel1.DM_Key = DMSkin.Controls.DMLabelKey.地球;
            this.dmLabel1.DM_Text = "";
            this.dmLabel1.Location = new System.Drawing.Point(392, 8);
            this.dmLabel1.Name = "dmLabel1";
            this.dmLabel1.Size = new System.Drawing.Size(32, 32);
            this.dmLabel1.TabIndex = 95;
            this.dmLabel1.Text = "dmLabel1";
            // 
            // BUT_Connect
            // 
            this.BUT_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Connect.BackColor = System.Drawing.Color.Transparent;
            this.BUT_Connect.DM_DisabledColor = System.Drawing.Color.Empty;
            this.BUT_Connect.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BUT_Connect.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BUT_Connect.DM_NormalColor = System.Drawing.Color.LimeGreen;
            this.BUT_Connect.DM_Radius = 5;
            this.BUT_Connect.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BUT_Connect.Image = null;
            this.BUT_Connect.Location = new System.Drawing.Point(1073, 7);
            this.BUT_Connect.Name = "BUT_Connect";
            this.BUT_Connect.Size = new System.Drawing.Size(66, 33);
            this.BUT_Connect.TabIndex = 88;
            this.BUT_Connect.Text = "连接";
            this.BUT_Connect.UseVisualStyleBackColor = false;
            this.BUT_Connect.Click += new System.EventHandler(this.BUT_setwp_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboBox1.DM_UseSelectable = true;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "57600",
            "115200"});
            this.metroComboBox1.Location = new System.Drawing.Point(911, 7);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(81, 30);
            this.metroComboBox1.TabIndex = 103;
            this.metroToolTip1.SetToolTip(this.metroComboBox1, "波特率");
            // 
            // bindingSourceHud
            // 
            this.bindingSourceHud.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // extQuickView1
            // 
            this.extQuickView1.DataBindings.Add(new System.Windows.Forms.Binding("LabelValue", this.bindingSourceState, "alt", true));
            this.extQuickView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.extQuickView1.LabelExtValue = null;
            this.extQuickView1.LabelExtValueUnit = null;
            this.extQuickView1.LabelIcon = null;
            this.extQuickView1.LabelName = "气压高度";
            this.extQuickView1.LabelValue = "0.0";
            this.extQuickView1.LabelValueUnit = null;
            this.extQuickView1.Location = new System.Drawing.Point(1, 188);
            this.extQuickView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extQuickView1.Name = "extQuickView1";
            this.extQuickView1.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.extQuickView1.Size = new System.Drawing.Size(263, 38);
            this.extQuickView1.TabIndex = 82;
            this.extQuickView1.Visible = false;
            // 
            // bindingSourceState
            // 
            this.bindingSourceState.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // extQuickView2
            // 
            this.extQuickView2.DataBindings.Add(new System.Windows.Forms.Binding("LabelValue", this.bindingSourceState, "mode", true));
            this.extQuickView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.extQuickView2.LabelExtValue = null;
            this.extQuickView2.LabelExtValueUnit = null;
            this.extQuickView2.LabelIcon = ((System.Drawing.Image)(resources.GetObject("extQuickView2.LabelIcon")));
            this.extQuickView2.LabelName = "模式";
            this.extQuickView2.LabelValue = "无";
            this.extQuickView2.LabelValueUnit = null;
            this.extQuickView2.Location = new System.Drawing.Point(1, 148);
            this.extQuickView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extQuickView2.Name = "extQuickView2";
            this.extQuickView2.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.extQuickView2.Size = new System.Drawing.Size(263, 40);
            this.extQuickView2.TabIndex = 83;
            // 
            // extQuickView5
            // 
            this.extQuickView5.BackColor = System.Drawing.Color.Gainsboro;
            this.extQuickView5.DataBindings.Add(new System.Windows.Forms.Binding("LabelValue", this.bindingSourceState, "airspeed", true));
            this.extQuickView5.Dock = System.Windows.Forms.DockStyle.Top;
            this.extQuickView5.LabelExtValue = null;
            this.extQuickView5.LabelExtValueUnit = null;
            this.extQuickView5.LabelIcon = ((System.Drawing.Image)(resources.GetObject("extQuickView5.LabelIcon")));
            this.extQuickView5.LabelName = "空速";
            this.extQuickView5.LabelValue = "0.0";
            this.extQuickView5.LabelValueUnit = "米/秒";
            this.extQuickView5.Location = new System.Drawing.Point(1, 108);
            this.extQuickView5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extQuickView5.Name = "extQuickView5";
            this.extQuickView5.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.extQuickView5.Size = new System.Drawing.Size(263, 40);
            this.extQuickView5.TabIndex = 86;
            // 
            // extQuickView4
            // 
            this.extQuickView4.DataBindings.Add(new System.Windows.Forms.Binding("LabelExtValue", this.bindingSourceState, "gpshdop", true));
            this.extQuickView4.DataBindings.Add(new System.Windows.Forms.Binding("LabelValue", this.bindingSourceState, "satcount", true));
            this.extQuickView4.Dock = System.Windows.Forms.DockStyle.Top;
            this.extQuickView4.LabelExtValue = null;
            this.extQuickView4.LabelExtValueUnit = null;
            this.extQuickView4.LabelIcon = ((System.Drawing.Image)(resources.GetObject("extQuickView4.LabelIcon")));
            this.extQuickView4.LabelName = "GPS";
            this.extQuickView4.LabelValue = "0.0";
            this.extQuickView4.LabelValueUnit = "颗";
            this.extQuickView4.Location = new System.Drawing.Point(1, 68);
            this.extQuickView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extQuickView4.Name = "extQuickView4";
            this.extQuickView4.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.extQuickView4.Size = new System.Drawing.Size(263, 40);
            this.extQuickView4.TabIndex = 85;
            // 
            // extQuickView3
            // 
            this.extQuickView3.BackColor = System.Drawing.Color.Gainsboro;
            this.extQuickView3.DataBindings.Add(new System.Windows.Forms.Binding("LabelExtValue", this.bindingSourceState, "battery_voltage", true));
            this.extQuickView3.DataBindings.Add(new System.Windows.Forms.Binding("LabelValue", this.bindingSourceState, "battery_remaining", true));
            this.extQuickView3.Dock = System.Windows.Forms.DockStyle.Top;
            this.extQuickView3.LabelExtValue = null;
            this.extQuickView3.LabelExtValueUnit = "V";
            this.extQuickView3.LabelIcon = ((System.Drawing.Image)(resources.GetObject("extQuickView3.LabelIcon")));
            this.extQuickView3.LabelName = "电量";
            this.extQuickView3.LabelValue = "0.0";
            this.extQuickView3.LabelValueUnit = "%";
            this.extQuickView3.Location = new System.Drawing.Point(1, 28);
            this.extQuickView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extQuickView3.Name = "extQuickView3";
            this.extQuickView3.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.extQuickView3.Size = new System.Drawing.Size(263, 40);
            this.extQuickView3.TabIndex = 84;
            // 
            // GCSMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 780);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.metroTile1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "GCSMainForm";
            this.Text = "ArduFly";
            this.Load += new System.EventHandler(this.GCSMainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelMap.ResumeLayout(false);
            this.dmTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3Command.ResumeLayout(false);
            this.panelAttitude.ResumeLayout(false);
            this.panelStates.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.metroTile1.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.BindingSource bindingSourceHud;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.BindingSource bindingSourceState;
        private Controls.HUD hud1;
        private GCSViews.ExtQuickView extQuickView2;
        private GCSViews.ExtQuickView extQuickView1;
        private GCSViews.ExtQuickView extQuickView3;
        private GCSViews.ExtQuickView extQuickView5;
        private GCSViews.ExtQuickView extQuickView4;
        private System.Windows.Forms.DataGridView Commands;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteWP;
        private System.Windows.Forms.ToolStripMenuItem InsertWP;
        private System.Windows.Forms.CheckBox CHK_splinedefault;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TXT_altwarn;
        private System.Windows.Forms.Label LBL_WPRad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_loiterrad;
        private System.Windows.Forms.Label LBL_defalutalt;
        private System.Windows.Forms.TextBox TXT_DefaultAlt;
        private System.Windows.Forms.TextBox TXT_WPRad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TXT_homealt;
        private System.Windows.Forms.TextBox TXT_homelng;
        private System.Windows.Forms.TextBox TXT_homelat;
        private Controls.Coords coords1;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem clearMissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setROIToolStripMenuItem;
        private BSE.Windows.Forms.Panel panel3Command;
        private BSE.Windows.Forms.Panel panelStates;
        private BSE.Windows.Forms.Panel panelAttitude;
        private BSE.Windows.Forms.Panel panelControl;
        private DMSkin.Controls.DMButton dmButtonChangeWP;
        private DMSkin.Metro.Controls.MetroComboBox CMB_setwp;
        private DMSkin.Metro.Controls.MetroTile metroTile1;
        private DMSkin.Controls.DMButtonCloseLight dmButtonCloseLightFormClose;
        private DMSkin.Controls.DMButtonMinLight dmButtonMinLightFormMin;
        private DMSkin.Controls.DMButton dmButton1;
        private DMSkin.Controls.DMButton myButtonAuto;
        private DMSkin.Controls.DMButton myButtonRTL;
        private DMSkin.Controls.DMButton dmButton4;
        private DMSkin.Controls.DMButton dmButton3;
        public DMSkin.Controls.DMButton BUT_Connect;
        private System.Windows.Forms.Timer timerTileDoubleClick;
        private DMSkin.Controls.DMTabControl dmTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DMSkin.Metro.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Panel panel2;
        private DMSkin.Metro.Controls.MetroPanel metroPanel2;
        private DMSkin.Controls.DMButton dmButtonCreatGrid;
        private DMSkin.Controls.DMButton dmButtonClreaGird;
        private DMSkin.Controls.DMButton dmButtonGridUI;
        private DMSkin.Controls.DMButton dmButton5;
        private DMSkin.Controls.DMButton dmButton6;
        private DMSkin.Controls.DMButton dmButtonZoomOut;
        private DMSkin.Controls.DMButton dmButtonZoomIn;
        private DMSkin.Metro.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alt;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Up;
        private System.Windows.Forms.DataGridViewImageColumn Down;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dist;
        private System.Windows.Forms.DataGridViewTextBoxColumn AZ;
        private DMSkin.Controls.DMButton dmButton2;
        private DMSkin.Metro.Controls.MetroComboBox metroComboBoxMapType;
        private System.Windows.Forms.ToolStripMenuItem measureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label labelHomeDisToPlane;
        private DMSkin.Controls.DMLabel dmLabel1;
        private DMSkin.Controls.DMLabel dmLabel2;
        private DMSkin.Controls.DMLabel dmLabel3;
        private System.Windows.Forms.TabPage tabPage3;
        private BSE.Windows.Forms.Panel panel3;
        private DMSkin.Controls.DMButton dmButton7;
        private DMSkin.Controls.DMButton dmButton8;
        private DMSkin.Controls.DMLabel dmLabel5;
        private DMSkin.MetroDMButton metroDMButton3;
        private DMSkin.MetroDMButton metroDMButton4;
        private DMSkin.MetroDMButton metroDMButton5;
        private DMSkin.MetroDMButton metroDMButton7;
        private DMSkin.MetroDMButton metroDMButton8;
        private DMSkin.MetroDMButton metroDMButton9;
        private DMSkin.MetroDMButton metroDMButton10;
        private DMSkin.MetroDMButton metroDMButton11;
        private DMSkin.MetroDMButton metroDMButton12;
        private DMSkin.MetroDMButton metroDMButton13;
        private DMSkin.Controls.DMButton dmButton9;
        private BSE.Windows.Forms.Panel panel4;
        private DMSkin.MetroDMButton metroDMButton15;
        private DMSkin.Controls.DMButton dmButton10;
        private DMSkin.Controls.DMButton dmButton11;
        private DMSkin.Controls.DMButton dmButton12;
        private DMSkin.Metro.Controls.MetroComboBox metroComboBoxSPort;
        private BSE.Windows.Forms.Panel panel5;
        private DMSkin.MetroDMButton metroDMButton18;
        private DMSkin.MetroDMButton metroDMButton17;
        private DMSkin.MetroDMButton metroDMButton16;
        private DMSkin.Controls.DMButton dmButton13;
        private DMSkin.Controls.DMButton dmButton14;
        private DMSkin.Controls.DMButton dmButton15;
        private DMSkin.MetroDMButton metroDMButton19;
        private DMSkin.MetroDMButton metroDMButton14;
        private DMSkin.MetroDMButton metroDMButton6;
        private DMSkin.MetroDMButton metroDMButton2;
        private DMSkin.MetroDMButton metroDMButton1;
        private DMSkin.Metro.Controls.MetroComboBox metroComboBox1;
    }
}