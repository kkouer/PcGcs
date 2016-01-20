using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MissionPlanner.GCSViews
{
    public partial class ExtQuickView : UserControl
    {
        [System.ComponentModel.Browsable(true)]
        public string LabelName
        {
            get
            {
                return labelName.Text;
            }
            set
            {
                if (labelName.Text == value)
                    return;
                labelName.Text = value;
            }
        }
        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }

        public string LabelValue 
        {
            get
            {
                return labelValue.Text;
            }
            set
            {
                if (value == null)
                    return;

                string ans = value.ToString();
                if (labelValue.Text == ans)
                    return;

                switch (ans.ToLower())
                {
                    case "manual":
                        ans = "手动";
                        break;
                    case "unknown":
                        ans = "未知";
                        break;
                    case "stabilize":
                        ans = "RC";
                        break;
                    case "auto":
                        ans = "自主";
                        break;
                    case "rtl":
                        ans = "回家";
                        break;
                    case "loiter":
                        ans = "增稳";
                        break;

                    default:
                        break;
                }
                if (string.IsNullOrEmpty(extValue))
                {
                    if (IsNumeric(ans))
                        ans = Math.Round(Convert.ToDouble(ans), 2).ToString();
                    labelValue.Text = ans + LabelValueUnit;
                }
                else
                {
                    if (IsNumeric(ans))
                        ans = Math.Round(Convert.ToDouble(ans), 2).ToString();
                    if (IsNumeric(extValue))
                        extValue = Math.Round(Convert.ToDouble(extValue), 2).ToString();
                    labelValue.Text = ans + LabelValueUnit + "(" + extValue + LabelExtValueUnit +")";
                }
            }
        }

        string extValue;
        /// <summary>
        /// 扩展显示
        /// </summary>
        [System.ComponentModel.Browsable(true)]
        public string LabelExtValue 
        { 
            get
            {
                return extValue;
            }
            set
            {
                if (extValue == value)
                    return;
                extValue = value;
            }
        }

        [System.ComponentModel.Browsable(true)]
        public Image LabelIcon 
        { 
            get
            {
                return pictureBox1.BackgroundImage;
            }
            set
            {
                if (pictureBox1.BackgroundImage == value)
                    return;
                pictureBox1.BackgroundImage = value;
            }
        }

        string valueUnit;
        [System.ComponentModel.Browsable(true)]
        public string LabelValueUnit
        {
            get
            {
                return valueUnit;
            }
            set
            {
                if (valueUnit == value)
                    return;
                valueUnit = value;
            }
        }

        string extvalueUnit;
        [System.ComponentModel.Browsable(true)]
        public string LabelExtValueUnit
        {
            get
            {
                return extvalueUnit;
            }
            set
            {
                if (extvalueUnit == value)
                    return;
                extvalueUnit = value;
            }
        }

        [System.ComponentModel.Browsable(true)]
        public Color numberColor { get { return labelValue.ForeColor; } set { if (labelValue.ForeColor == value) return; labelValue.ForeColor = value; } }


        public ExtQuickView()
        {
            InitializeComponent();
        }
    }
}
