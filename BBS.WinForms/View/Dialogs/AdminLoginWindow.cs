using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BBS
{
    public partial class AdminLoginWindow : Form
    {
        public AdminLoginWindow()
        {
            InitializeComponent();
            FillControl();
        }

        public void FillControl()
        {
            List<Person> persons = Session.GetElevatedAccounts();
            foreach (Person p in persons)
                this.adminCombo.Items.Add(p);

            if (this.adminCombo.Items.Count > 0)
                this.adminCombo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = (Person)adminCombo.SelectedItem;

            if (p != null && Session.LogInAdmin(p,new ID("", pwBox.Text)))
                DialogResult = DialogResult.OK;
            else
                MessageBoxCreator.RaiseWarning("Ongeldige gebruikersnaam/wachtwoord");
        }

        private void adminCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pwBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }
    }
}
