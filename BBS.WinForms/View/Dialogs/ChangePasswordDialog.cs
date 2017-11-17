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
    public partial class ChangePasswordDialog : Form
    {
        private Person person;

        public ChangePasswordDialog(Person p)
        {
            person = p;
            InitializeComponent();
            if (Session.GetCurrentUser().IsAdmin())
            {
                oldPassWTxt.Enabled = false;
                label1.ForeColor = Color.Gray;
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (Session.GetCurrentUser().IsAdmin() || oldPassWTxt.Text.Equals(person.ID.Password))
            {
                if (pwTxt1.Text.Equals(pwTxt2.Text))
                {
                    person.ID.Password = pwTxt1.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                    MessageBoxCreator.RaiseWarning("Nieuwe wachtwoorden komen niet overeen.");
            }
            else
                MessageBoxCreator.RaiseWarning("Oud wachtwoord verkeerd.");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
