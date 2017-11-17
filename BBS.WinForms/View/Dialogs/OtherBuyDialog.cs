using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using BBS.Model;

namespace BBS
{
    public partial class OtherBuysDialog : Form
    {
        public OtherBuysDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (descTxt.Text != "")
            {
                Decimal price = 0m;

                try
                {
                    price = DecimalExtensions.ParseInvariant(priceTxt.Text);

                    if (price != 0m)
                    {
                        OtherBuys ob = new OtherBuys(descTxt.Text, price);
                        Session.AddBarMutation(ob);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBoxCreator.RaiseWarning("Bedrag mag niet nul zijn.");
                    }
                }
                catch (Exception ee)
                {
                    MessageBoxCreator.RaiseError("Bedrag met onjuist decimaal teken.",ee);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
