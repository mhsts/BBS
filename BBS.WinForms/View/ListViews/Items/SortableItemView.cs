using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBS
{
    public partial class SortableItemView : UserControl
    {
        public string SortProperty = "";

        public SortableItemView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public static void SetColorBySign(Label lbl, decimal pp)
        {
            if (pp < 0m)
                lbl.ForeColor = Color.Red;
            else
                lbl.ForeColor = Color.Black;
        }
    }
}
