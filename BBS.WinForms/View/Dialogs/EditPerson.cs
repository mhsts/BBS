using System;
using System.ComponentModel;
using System.Net.Mail;
using System.Windows.Forms;
using BBS.Model;

namespace BBS
{
    public partial class EditPerson : Form
    {
        private readonly Person editPerson;

        public EditPerson(Person p)
        {
            InitializeComponent();
            errorProvider1.SetIconAlignment(textBox1, ErrorIconAlignment.MiddleLeft);

            editPerson = p;

            if (Session.GetCurrentUser().Role != Person.PersonRole.ADMIN)
            {
                makeBar.Enabled = false;
                makeAdmin.Enabled = false;
            }

            FillControl();
        }

        private void FillControl()
        {
            nameLabel.Text = "Persoon: " + editPerson.Name;
            tegoedLabel.Text = String.Format("Tegoed: {0:0.00}", editPerson.Balance);
            barcodeTxt.Text = editPerson.ID.BarCode.Value;
            barcode2Txt.Text = editPerson.ID.BarCode2.Value;
            groupsAccountChkBox.Checked = editPerson.GroupAccount;
        }

        private void makeBar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deze persoon 'bar' rechten geven, zeker weten?", "Rechten", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                editPerson.Role = Person.PersonRole.BAR;
                Logger.Log(String.Format("{0} heeft 'bar' rechten gekregen van {1}", editPerson.Name, Session.GetCurrentUser().Name));
            }
        }

        private void makeAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deze persoon 'admin' rechten geven, zeker weten?", "Rechten", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                editPerson.Role = Person.PersonRole.ADMIN;
                Logger.Log(String.Format("{0} heeft 'admin' rechten gekregen van {1}", editPerson.Name, Session.GetCurrentUser().Name));
            }
        }

        private void makeNormal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deze persoon rechten afnemen, zeker weten?", "Rechten", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                editPerson.Role = Person.PersonRole.NORMAL;
                Logger.Log(String.Format("{0} heeft geen speciale rechten meer (door {1})", editPerson.Name, Session.GetCurrentUser().Name));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editPerson.ID.BarCode = new BarCode(barcodeTxt.Text);
            editPerson.ID.BarCode2 = new BarCode(barcode2Txt.Text);
            editPerson.GroupAccount = groupsAccountChkBox.Checked;

            DialogResult = DialogResult.OK;
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal amount = DecimalExtensions.ParseInvariant(depositTxt.Text);

                if (MessageBox.Show(String.Format("Een bedrag van {0:0.00} storten op deze account?", amount), "Geld toevoegen aan tegoed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Deposit d = new Deposit(editPerson, Session.GetCurrentUser(), amount);
                    editPerson.AddNewMutation(d);
                    editPerson.CommitMutation();
                    FillControl();
                }
            }
            catch (Exception ee)
            {
                MessageBoxCreator.RaiseError("Fout in tekst velden (gebruik juiste decimaal teken)",ee);
            }
        }

        private void EditPerson_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePasswordDialog cpd = new ChangePasswordDialog(editPerson);
            cpd.ShowDialog();
            cpd.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            // must be empty or valid email adres
            if (string.IsNullOrEmpty(textBox1.Text) || IsValidEmailAddress(textBox1.Text)) 
                return;
            
            // invalid input:
            e.Cancel = true;
            textBox1.Select(0, textBox1.Text.Length);
        }

        private static bool IsValidEmailAddress(string email)
        {
            try
            {
                new MailAddress(email);

                // do some additional validation: (expect a . after @)
                var dotIndex = email.LastIndexOf(".", StringComparison.Ordinal);
                var atIndex = email.LastIndexOf("@", StringComparison.Ordinal);

                if (dotIndex > -1 && dotIndex > atIndex)
                    return true;
            }
            catch
            {
                return false;
            }
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
            // must be empty or valid email adres
            if (string.IsNullOrEmpty(textBox1.Text) || IsValidEmailAddress(textBox1.Text))
                return;
            errorProvider1.SetError(textBox1, "Email adres niet correct");
        }
    }
}
