using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class WindMap : UserControl
    {
        private Image myImageA;

        public WindMap()
        {
            InitializeComponent();

            myImageA = new Bitmap(MissionPlanner.Properties.Resources.wind80_80);
        }

        [System.ComponentModel.Browsable(true)]
        public string TileString
        {
            get
            {
                return labelTitle.Text;
            }
            set
            {
                if (labelTitle.Text == value)
                    return;
                labelTitle.Text = value;
            }

        }

        [System.ComponentModel.Browsable(true)]
        public string WindSpeedValue
        {
            get
            {
                return WindSpeed.Text;
            }
            set
            {
                if (WindSpeed.Text == value)
                    return;
                WindSpeed.Text = Math.Round(Convert.ToDouble(value), 2).ToString();
            }
        }
        //风向
        float windDirection = 0.0f;

        [System.ComponentModel.Browsable(true)]
        public float WindDirectionValue
        {
            get
            {
                return windDirection;
            }
            set
            {
                if (windDirection == value)
                    return;
                windDirection = value;
                this.pictureBox1.Image = ImageEx.GetRotateImage(myImageA, 360 - windDirection);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //g = e.Graphics;

            //g.ResetTransform();

            //g.RotateTransform(windDirection);
        }

        private System.Drawing.Graphics g;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);


            //myImageA = ImageEx.GetRotateImage(myImageA, windDirection);

            //g = e.Graphics;

            //Rectangle myRect = new Rectangle(0, 0, 80, 80);

            ////g.TranslateTransform(0, 20);

            ////g.RotateTransform((int)windDirection);

            //g.DrawImage(myImageA, myRect);

            //g.ResetTransform();
        }


    }

    public static class ImageEx
    {
        public static Image GetRotateImage(this Image img, float angle)
        {
            angle = angle % 360;//弧度转换
            double radian = angle * Math.PI / 180.0;
            double cos = Math.Cos(radian);
            double sin = Math.Sin(radian);
            //原图的宽和高
            int w = img.Width;
            int h = img.Height;
            int W = 80;// (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));
            int H = 80; //(int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));
            //目标位图
            Image dsImage = new Bitmap(W, H, img.PixelFormat);
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(dsImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //计算偏移量
                Point Offset = new Point((W - w) / 2, (H - h) / 2);
                //构造图像显示区域：让图像的中心与窗口的中心点一致
                Rectangle rect = new Rectangle(Offset.X, Offset.Y, w, h);
                Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
                g.TranslateTransform(center.X, center.Y);
                g.RotateTransform(360 - angle);
                //恢复图像在水平和垂直方向的平移
                g.TranslateTransform(-center.X, -center.Y);
                g.DrawImage(img, rect);
                //重至绘图的所有变换
                g.ResetTransform();
                g.Save();
            }
            return dsImage;
        }
    }
}
