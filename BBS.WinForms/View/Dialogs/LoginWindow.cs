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
    public partial class LoginWindow : Form
    {
        private Person targetPerson;
        private BarCode bc = null;

        public LoginWindow(Person p)
        {
            InitializeComponent();
            targetPerson = p;
            FillControl();
            //BarCodeScanner bcs = new BarCodeScanner(this);
            //bcs.Scanned += new BarCodeScanner.scannedDelegate(bcs_Scanned);
        }

        private void bcs_Scanned(BarCode barcode)
        {
            bc = barcode;
            label2.Text = bc.ToString();
            Login();
        }

        public void FillControl()
        {
            this.Text = "Login " + targetPerson.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            String bcValue = null;
            if (bc != null)
                bcValue = bc.Value;

            if (Session.LogInUser(targetPerson, new ID(bcValue, pwBox.Text)))
                DialogResult = DialogResult.OK;
            else
            {
                MessageBoxCreator.RaiseWarning("Ongeldig wachtwoord of onbekende barcode");
                if (bc != null)
                {
                    bc = null;
                    label2.Text = "...scan barcode opnieuw...";
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pwBox.Enabled = radioButton1.Checked;
            pwBox.Focus();
        }

        private void pwBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                Login();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pwBox.Enabled = radioButton1.Checked;
        }

    }
}
