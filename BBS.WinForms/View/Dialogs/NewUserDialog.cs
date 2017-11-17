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
    public partial class NewUserDialog : Form
    {
        public NewUserDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //verify contents!
            if (Session.ExistsPersonWithName(nameTxt.Text))
            {
                MessageBoxCreator.RaiseWarning("Naam bestaat al.");
                return;
            }

            if (pwTxt1.Text.Length < 3)
            {
                MessageBoxCreator.RaiseWarning("Wachtwoord te kort");
                return;
            }

            if (!pwTxt1.Text.Equals(pwTxt2.Text))
            {
                MessageBoxCreator.RaiseWarning("Wachtwoorden komen niet overeen.");
                return;
            }

            Person p = new Person(nameTxt.Text,barCodeTxt.Text,pwTxt1.Text);

            Session.Persons.Add(p);

            DialogResult = DialogResult.OK;
        }
    }
}
