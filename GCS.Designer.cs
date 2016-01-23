namespace MissionPlanner
{
    partial class GCS
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBoundrate = new System.Windows.Forms.ComboBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.buttonHideInfoPanel = new System.Windows.Forms.Button();
            this.buttonShowPanel = new System.Windows.Forms.Button();
            this.hud1 = new MissionPlanner.Controls.HUD();
            this.bindingSourceHud = new System.Windows.Forms.BindingSource(this.components);
            this.panelCommand = new BSE.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonHideCommandPanel = new System.Windows.Forms.Button();
            this.buttonDisarmed = new System.Windows.Forms.Button();
            this.buttonArmed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelInofPanel = new BSE.Windows.Forms.Panel();
            this.doubelLabel4 = new MissionPlanner.DoubelLabel();
            this.doubelLabel1 = new MissionPlanner.DoubelLabel();
            this.doubelLabel3 = new MissionPlanner.DoubelLabel();
            this.doubelLabel2 = new MissionPlanner.DoubelLabel();
            this.bindingSourceState = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).BeginInit();
            this.panelCommand.SuspendLayout();
            this.panelInofPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceState)).BeginInit();
            this.SuspendLayout();
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
            this.gMapControl1.Size = new System.Drawing.Size(916, 563);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDown);
            this.gMapControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseMove);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnect.Location = new System.Drawing.Point(829, 528);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "连 接";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxBoundrate
            // 
            this.comboBoxBoundrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBoundrate.FormattingEnabled = true;
            this.comboBoxBoundrate.Items.AddRange(new object[] {
            "57600",
            "115200"});
            this.comboBoxBoundrate.Location = new System.Drawing.Point(754, 529);
            this.comboBoxBoundrate.Name = "comboBoxBoundrate";
            this.comboBoxBoundrate.Size = new System.Drawing.Size(69, 20);
            this.comboBoxBoundrate.TabIndex = 3;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(693, 529);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(55, 20);
            this.comboBoxComPort.TabIndex = 4;
            this.comboBoxComPort.Click += new System.EventHandler(this.comboBoxComPort_Click);
            // 
            // buttonHideInfoPanel
            // 
            this.buttonHideInfoPanel.Location = new System.Drawing.Point(146, 3);
            this.buttonHideInfoPanel.Name = "buttonHideInfoPanel";
            this.buttonHideInfoPanel.Size = new System.Drawing.Size(27, 23);
            this.buttonHideInfoPanel.TabIndex = 0;
            this.buttonHideInfoPanel.Text = "X";
            this.buttonHideInfoPanel.UseVisualStyleBackColor = true;
            this.buttonHideInfoPanel.Click += new System.EventHandler(this.buttonHideInfoPanel_Click);
            // 
            // buttonShowPanel
            // 
            this.buttonShowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowPanel.Location = new System.Drawing.Point(12, 194);
            this.buttonShowPanel.Name = "buttonShowPanel";
            this.buttonShowPanel.Size = new System.Drawing.Size(27, 23);
            this.buttonShowPanel.TabIndex = 84;
            this.buttonShowPanel.Text = "S";
            this.buttonShowPanel.UseVisualStyleBackColor = true;
            this.buttonShowPanel.Click += new System.EventHandler(this.buttonShowPanel_Click);
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
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSourceHud, "roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("pitch", this.bindingSourceHud, "pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("roll", this.bindingSourceHud, "roll", true));
            this.hud1.datetime = new System.DateTime(((long)(0)));
            this.hud1.displayalt = false;
            this.hud1.displayArmInfo = false;
            this.hud1.displayconninfo = false;
            this.hud1.displayFailesafeInfo = false;
            this.hud1.displayFlyMode = false;
            this.hud1.displaygps = false;
            this.hud1.displayheading = false;
            this.hud1.displayMessage = false;
            this.hud1.displayspeed = false;
            this.hud1.displayTartgetWp = false;
            this.hud1.displayxtrack = false;
            this.hud1.disttowp = 0F;
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
            this.hud1.Size = new System.Drawing.Size(177, 190);
            this.hud1.status = false;
            this.hud1.streamjpg = null;
            this.hud1.TabIndex = 82;
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
            // bindingSourceHud
            // 
            this.bindingSourceHud.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // panelCommand
            // 
            this.panelCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCommand.AssociatedSplitter = null;
            this.panelCommand.BackColor = System.Drawing.Color.Transparent;
            this.panelCommand.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.panelCommand.CaptionHeight = 27;
            this.panelCommand.Controls.Add(this.button9);
            this.panelCommand.Controls.Add(this.button8);
            this.panelCommand.Controls.Add(this.button7);
            this.panelCommand.Controls.Add(this.button6);
            this.panelCommand.Controls.Add(this.button5);
            this.panelCommand.Controls.Add(this.button4);
            this.panelCommand.Controls.Add(this.button3);
            this.panelCommand.Controls.Add(this.button2);
            this.panelCommand.Controls.Add(this.buttonHideCommandPanel);
            this.panelCommand.Controls.Add(this.buttonDisarmed);
            this.panelCommand.Controls.Add(this.buttonArmed);
            this.panelCommand.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panelCommand.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panelCommand.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panelCommand.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelCommand.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panelCommand.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelCommand.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelCommand.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelCommand.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panelCommand.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panelCommand.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelCommand.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelCommand.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panelCommand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelCommand.Image = null;
            this.panelCommand.Location = new System.Drawing.Point(742, 0);
            this.panelCommand.MinimumSize = new System.Drawing.Size(27, 27);
            this.panelCommand.Name = "panelCommand";
            this.panelCommand.Size = new System.Drawing.Size(174, 288);
            this.panelCommand.TabIndex = 85;
            this.panelCommand.Text = "指令";
            this.panelCommand.ToolTipTextCloseIcon = null;
            this.panelCommand.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelCommand.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(95, 235);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "下 载";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(12, 235);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "上 传";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(95, 189);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "回 家";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(12, 189);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "拍 照";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(95, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "开 始";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(12, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "自 动";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(93, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "定 点";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(12, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "向 导";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonHideCommandPanel
            // 
            this.buttonHideCommandPanel.Location = new System.Drawing.Point(143, 3);
            this.buttonHideCommandPanel.Name = "buttonHideCommandPanel";
            this.buttonHideCommandPanel.Size = new System.Drawing.Size(27, 23);
            this.buttonHideCommandPanel.TabIndex = 5;
            this.buttonHideCommandPanel.Text = "X";
            this.buttonHideCommandPanel.UseVisualStyleBackColor = true;
            this.buttonHideCommandPanel.Click += new System.EventHandler(this.buttonHideCommandPanel_Click);
            // 
            // buttonDisarmed
            // 
            this.buttonDisarmed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisarmed.Location = new System.Drawing.Point(93, 45);
            this.buttonDisarmed.Name = "buttonDisarmed";
            this.buttonDisarmed.Size = new System.Drawing.Size(75, 23);
            this.buttonDisarmed.TabIndex = 4;
            this.buttonDisarmed.Text = "加 锁";
            this.buttonDisarmed.UseVisualStyleBackColor = true;
            // 
            // buttonArmed
            // 
            this.buttonArmed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonArmed.Location = new System.Drawing.Point(12, 45);
            this.buttonArmed.Name = "buttonArmed";
            this.buttonArmed.Size = new System.Drawing.Size(75, 23);
            this.buttonArmed.TabIndex = 3;
            this.buttonArmed.Text = "解 锁";
            this.buttonArmed.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(880, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "S";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelInofPanel
            // 
            this.panelInofPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelInofPanel.AssociatedSplitter = null;
            this.panelInofPanel.BackColor = System.Drawing.Color.Transparent;
            this.panelInofPanel.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.panelInofPanel.CaptionHeight = 27;
            this.panelInofPanel.Controls.Add(this.buttonHideInfoPanel);
            this.panelInofPanel.Controls.Add(this.doubelLabel4);
            this.panelInofPanel.Controls.Add(this.doubelLabel1);
            this.panelInofPanel.Controls.Add(this.doubelLabel3);
            this.panelInofPanel.Controls.Add(this.doubelLabel2);
            this.panelInofPanel.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panelInofPanel.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panelInofPanel.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panelInofPanel.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelInofPanel.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panelInofPanel.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelInofPanel.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelInofPanel.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelInofPanel.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panelInofPanel.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panelInofPanel.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelInofPanel.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelInofPanel.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panelInofPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelInofPanel.Image = null;
            this.panelInofPanel.Location = new System.Drawing.Point(0, 172);
            this.panelInofPanel.MinimumSize = new System.Drawing.Size(27, 27);
            this.panelInofPanel.Name = "panelInofPanel";
            this.panelInofPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelInofPanel.Size = new System.Drawing.Size(177, 391);
            this.panelInofPanel.TabIndex = 86;
            this.panelInofPanel.Text = "参数";
            this.panelInofPanel.ToolTipTextCloseIcon = null;
            this.panelInofPanel.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelInofPanel.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // doubelLabel4
            // 
            this.doubelLabel4.DataBindings.Add(new System.Windows.Forms.Binding("LabelValue", this.bindingSourceHud, "satcount", true));
            this.doubelLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.doubelLabel4.LabelName = "GPS：";
            this.doubelLabel4.LabelValue = "0.0";
            this.doubelLabel4.Location = new System.Drawing.Point(1, 111);
            this.doubelLabel4.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.doubelLabel4.Name = "doubelLabel4";
            this.doubelLabel4.Size = new System.Drawing.Size(175, 26);
            this.doubelLabel4.TabIndex = 4;
            // 
            // doubelLabel1
            // 
            this.doubelLabel1.DataBindings.Add(new System.Windows.Forms.Binding("LabelValue", this.bindingSourceHud, "battery_voltage", true));
            this.doubelLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.doubelLabel1.LabelName = "电压：";
            this.doubelLabel1.LabelValue = "0.0";
            this.doubelLabel1.Location = new System.Drawing.Point(1, 85);
            this.doubelLabel1.Name = "doubelLabel1";
            this.doubelLabel1.Size = new System.Drawing.Size(175, 26);
            this.doubelLabel1.TabIndex = 1;
            // 
            // doubelLabel3
            // 
            this.doubelLabel3.DataBindings.Add(new System.Windows.Forms.Binding("LabelValue", this.bindingSourceHud, "HomeAlt", true));
            this.doubelLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.doubelLabel3.LabelName = "高度：";
            this.doubelLabel3.LabelValue = "0.0";
            this.doubelLabel3.Location = new System.Drawing.Point(1, 59);
            this.doubelLabel3.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.doubelLabel3.Name = "doubelLabel3";
            this.doubelLabel3.Size = new System.Drawing.Size(175, 26);
            this.doubelLabel3.TabIndex = 3;
            // 
            // doubelLabel2
            // 
            this.doubelLabel2.DataBindings.Add(new System.Windows.Forms.Binding("LabelValue", this.bindingSourceHud, "current", true));
            this.doubelLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.doubelLabel2.LabelName = "电流：";
            this.doubelLabel2.LabelValue = "0.0";
            this.doubelLabel2.Location = new System.Drawing.Point(1, 33);
            this.doubelLabel2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.doubelLabel2.Name = "doubelLabel2";
            this.doubelLabel2.Size = new System.Drawing.Size(175, 26);
            this.doubelLabel2.TabIndex = 2;
            // 
            // bindingSourceState
            // 
            this.bindingSourceState.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // GCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 563);
            this.Controls.Add(this.panelInofPanel);
            this.Controls.Add(this.panelCommand);
            this.Controls.Add(this.hud1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonShowPanel);
            this.Controls.Add(this.comboBoxComPort);
            this.Controls.Add(this.comboBoxBoundrate);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.gMapControl1);
            this.Name = "GCS";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).EndInit();
            this.panelCommand.ResumeLayout(false);
            this.panelInofPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBoundrate;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private Controls.HUD hud1;
        private System.Windows.Forms.Button buttonHideInfoPanel;
        private System.Windows.Forms.Button buttonShowPanel;
        private DoubelLabel doubelLabel1;
        private DoubelLabel doubelLabel4;
        private DoubelLabel doubelLabel3;
        private DoubelLabel doubelLabel2;
        private BSE.Windows.Forms.Panel panelCommand;
        private System.Windows.Forms.Button buttonDisarmed;
        private System.Windows.Forms.Button buttonArmed;
        private System.Windows.Forms.Button buttonHideCommandPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private BSE.Windows.Forms.Panel panelInofPanel;
        private System.Windows.Forms.BindingSource bindingSourceHud;
        private System.Windows.Forms.BindingSource bindingSourceState;
    }
}