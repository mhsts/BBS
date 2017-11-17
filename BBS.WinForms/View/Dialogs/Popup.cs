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
    public partial class Popup : Form
    {
        private bool goingUp = true;
        Timer slideTimer = new Timer();
        Timer hideTimer = new Timer();

        private static int maxheight = 200;
        private static int minheight = 36;

        public Popup()
        {
            InitializeComponent();
            this.Visible = false;

            slideTimer.Interval = 50;
            slideTimer.Enabled = false;
            slideTimer.Tick += new EventHandler(slideTimer_Tick);

            hideTimer.Interval = 5000;
            hideTimer.Enabled = false;
            hideTimer.Tick += new EventHandler(hideTimer_Tick);
        }

        private void hideTimer_Tick(object sender, EventArgs e)
        {
            hideTimer.Enabled = false;
            goingUp = false;
            slideTimer.Enabled = true;            
        }

        private void slideTimer_Tick(object sender, EventArgs e)
        {
            if (goingUp)
            {
                if (this.Height <= maxheight)
                {
                    this.Top -= 10;
                    this.Height += 10;
                }
                else
                {
                    slideTimer.Enabled = false;
                    hideTimer.Enabled = true;
                }
            }
            else
            {
                if (this.Height >= minheight+4)
                {
                    this.Top += 10;
                    this.Height -= 10;
                }
                else
                {
                    slideTimer.Enabled = false;
                    //popup done
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }
        }

        public void DoPopup(Order o, int timeoutSeconds)
        {
            if (o == null || o.ProductOrders.Count == 0)
                return;

            listBox1.Items.Clear();
            foreach (ProductOrder po in o.ProductOrders)
                listBox1.Items.Add(po.ToFriendlyString());

            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - minheight;
            this.Height = minheight;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;

            hideTimer.Interval = timeoutSeconds * 1000;

            goingUp = true;
            
            slideTimer.Enabled = true;
            
            this.TopMost = true;
            this.Show();
        }

        private void Popup_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            slideTimer.Enabled = false;
            hideTimer.Enabled = false;
        }
    }
}
