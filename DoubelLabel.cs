using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MissionPlanner
{
    public partial class DoubelLabel : UserControl
    {
        public DoubelLabel()
        {
            InitializeComponent();
        }
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
        [System.ComponentModel.Browsable(true)]
        public string LabelValue
        {
            get
            {
                return labelValue.Text;
            }
            set
            {
                //if (labelValue.Text == value)
                //    return;
                //labelValue.Text = value;

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

                if (IsNumeric(ans))
                    ans = Math.Round(Convert.ToDouble(ans), 2).ToString();
                labelValue.Text = ans ;


            }
        }

        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }

    }
}
