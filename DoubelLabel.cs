using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        public string LabelExtValue
        {
            get
            {
                return labelValue.Text;
            }
            set
            {
                if (labelValue.Text == value)
                    return;
                labelValue.Text = value;
            }
        }
    }
}
