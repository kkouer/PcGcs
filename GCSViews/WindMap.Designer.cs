namespace MissionPlanner.GCSViews
{
    partial class WindMap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.WindSpeed = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MissionPlanner.Properties.Resources.wind80_80;
            this.pictureBox1.Location = new System.Drawing.Point(4, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(10, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(68, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "估算风向:";
            // 
            // WindSpeed
            // 
            this.WindSpeed.AutoSize = true;
            this.WindSpeed.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WindSpeed.Location = new System.Drawing.Point(8, 106);
            this.WindSpeed.Name = "WindSpeed";
            this.WindSpeed.Size = new System.Drawing.Size(17, 20);
            this.WindSpeed.TabIndex = 2;
            this.WindSpeed.Text = "0";
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.unit.Location = new System.Drawing.Point(41, 106);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(43, 20);
            this.unit.TabIndex = 3;
            this.unit.Text = "米/秒";
            // 
            // WindMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.unit);
            this.Controls.Add(this.WindSpeed);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WindMap";
            this.Size = new System.Drawing.Size(86, 136);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label WindSpeed;
        private System.Windows.Forms.Label unit;
    }
}
