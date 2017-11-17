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
    public partial class ListPanel : UserControl
    {
        public bool UseRowColoring { get; set; }

        public ListPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            UseRowColoring = true;
            this.ControlAdded += new ControlEventHandler(ListPanel_ControlAdded);
            this.ControlRemoved += new ControlEventHandler(ListPanel_ControlRemoved);            
            this.AutoScroll = true;
            this.VerticalScroll.Enabled = true;
            this.HorizontalScroll.Enabled = false;
        }

        private void ListPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (!suspendLayout)
                RefreshControl();
        }

        public void RefreshControl()
        {
            Console.WriteLine("Refreshing!");

            int top = 0;
            
            List<SortableItemView> sivs = new List<SortableItemView>();

            foreach (Control c in Controls)
                if (c is SortableItemView)
                    sivs.Add(c as SortableItemView);

            if (sivs.Count > 0)
                if (sivs[0].SortProperty != "")
                    sivs.Sort(delegate(SortableItemView p1, SortableItemView p2) { return p1.SortProperty.CompareTo(p2.SortProperty); });

            int count = 0;

            foreach (SortableItemView siv in sivs)
            {
                siv.Top = top;
                siv.Left = 0;
                siv.Width = this.Width;
                top += siv.Height;

                if (UseRowColoring)
                {
                    if ((count % 2) == 0)
                    {
                        siv.ForeColor = Color.Black;
                        siv.BackColor = Color.Transparent;
                    }
                    else
                    {
                        siv.ForeColor = Color.White;
                        siv.BackColor = Color.LimeGreen;
                    }
                    count++;
                }
            }
        }
        
        private bool suspendLayout = false;
        public new bool SuspendLayout { get{return suspendLayout;} 
            set
            {
                suspendLayout = value;
                if (suspendLayout == true)
                {
                    this.Visible = false;
                    this.SuspendLayout();
                }
                else
                {
                    this.ResumeLayout();
                    this.RefreshControl();
                    this.Visible = true;
                }
            }
        }

        private void ListPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (!suspendLayout)
                RefreshControl();
        }
    }
}
