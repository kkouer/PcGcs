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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBoundrate = new System.Windows.Forms.ComboBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
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
            this.comboBoxComPort.Location = new System.Drawing.Point(679, 529);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(69, 20);
            this.comboBoxComPort.TabIndex = 4;
            // 
            // GCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 563);
            this.Controls.Add(this.comboBoxComPort);
            this.Controls.Add(this.comboBoxBoundrate);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.gMapControl1);
            this.Name = "GCS";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBoundrate;
        private System.Windows.Forms.ComboBox comboBoxComPort;
    }
}