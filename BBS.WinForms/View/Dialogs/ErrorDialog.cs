using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBS
{
    public partial class ErrorDialog : Form
    {
        public ErrorDialog()
        {
            InitializeComponent();
        }

        public static void Show(string text, string errorDetails)
        {
            ErrorDialog ed = new ErrorDialog();
            ed.SetText(text);
            ed.SetError(errorDetails);
            ed.ShowDialog();
        }

        private void SetError(string errorDetails)
        {
            textBox1.Text = errorDetails;
        }

        private void SetText(string text)
        {
            label1.Text = text;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.Height = 140;
                tabControl1.Height = 78;
            }
            else
            {
                this.Height = 280;
                tabControl1.Height = 218;
            }
        }
    }
}
