using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BBS.View.DataLists.DataItems;

namespace BBS
{
    public partial class BalansView : UserControl
    {
        public BalansView()
        {
            InitializeComponent();

            dataGridView1.OnDeleteClicked = OnPersonDelete;
            dataGridView1.OnEditClicked = OnPersonEdit;
            dataGridView1.OnCellFormatting = (propertyName, value, cellStyle) =>
                {
                    if (propertyName == "Balance")
                    {
                        double balans;
                        var balanceStr = (string)value;
                        if (Double.TryParse(balanceStr, out balans))
                        {
                            if (balans < 0)
                            {
                                cellStyle.SelectionForeColor = Color.Red;
                                cellStyle.ForeColor = Color.Red;
                                return;
                            }
                        }
                        cellStyle.ForeColor = Color.Black;
                    }
                };

            FillControl();
        }

        public void FillControl()
        {
            dataGridView1.SetData(Session.Persons.Where(p=>p.ShowToUser()).Select(p => new BalansPersonItem(p)).OrderBy(bp => bp.Name).ToList());
        }

        private void OnPersonEdit(object rowData)
        {
            var targetPerson = ((BalansPersonItem)rowData).GetPerson();
            EditPerson ep = new EditPerson(targetPerson);
            if (ep.ShowDialog(this) == DialogResult.OK)
                FillControl();
            ep.Dispose();
        }

        private void OnPersonDelete(object rowData)
        {
            var targetPerson = ((BalansPersonItem)rowData).GetPerson();
            Person currentUser = Session.GetCurrentUser();
            if (!currentUser.IsAdmin())
            {
                MessageBoxCreator.RaiseWarning("Alleen admins kunnen personen verwijderen.");
                return;
            }

            if (MessageBox.Show("Weet je zeker dat deze persoon verwijderd moet worden?", "Persoon verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!Session.RemovePerson(targetPerson))
                    MessageBoxCreator.RaiseWarning("Kan deze persoon niet verwijderen (is de balans wel 0?).");
                else
                {
                    targetPerson = null;
                    FillControl();
                }
            } 
        }

        private void ExportBalansToCsvClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = "csv";
            sfd.OverwritePrompt = true;
            sfd.Filter = "CSV bestand (Excel)|*.csv";
            sfd.FileName = String.Format("bbs_balans");

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;

                try
                {                    
                    fs = File.Open(sfd.FileName, FileMode.Create);
                    sw = new StreamWriter(fs);
                    SavePersonBalanceToStream(sw);
                }
                catch (Exception ex)
                {
                    MessageBoxCreator.RaiseError("Fout bij het openen en schrijven naar file", ex);
                }
                finally
                {
                    if (sw != null)
                        sw.Close();
                }
            }
        }

        private void SavePersonBalanceToStream(StreamWriter sw)
        {
            string csvDelimiter = ";";

            sw.WriteLine("Persoon" + csvDelimiter + "Balans");

            foreach (Person p in Session.Persons)
            {
                sw.WriteLine(String.Format("{0}{2}{1}", p.Name, p.Balance, csvDelimiter));
            }
        }
    }
}

