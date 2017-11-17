using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBS.View
{
    public partial class AdminTabs : UserControl
    {
        public AdminTabs()
        {
            InitializeComponent();
            adminTabControl.SelectedIndexChanged += new EventHandler(adminTabControl_SelectedIndexChanged);
            adminTabControl.GotFocus += new EventHandler(adminTabControl_GotFocus);
        }

        void adminTabControl_GotFocus(object sender, EventArgs e)
        {
            HandleRefresh();
        }

        private void HandleRefresh()
        {    
            if (adminTabControl.SelectedTab == logTab)
            {
                radioTransactions.Checked = true;
                FillLogBox();
            }
            else if (adminTabControl.SelectedTab == balansTab)
            {
                balansView1.FillControl();
            }
            else if (adminTabControl.SelectedTab == voorraadTab)
            {
                voorraadView1.FillControl();
            }
            else if (adminTabControl.SelectedTab == resTab)
            {
                if (periodSelectionBox.DataSource == null)
                {
                    periodSelectionBox.DataSource = Session.GetReports();
                    periodSelectionBox.SelectedItem = Session.GetCurrentReport();
                }
                else
                    periodSelectionBox.DataSource = Session.GetReports();

                ShowSelectedPeriod();
            }
        }

        private void FillLogBox()
        {
            if (radioTransactions.Checked)
            {
                logBox.Text = Logger.GetTransactionLog();
            }
            else
            {
                logBox.Text = Logger.GetLog();
            }
            logBox.SelectionStart = (int)Math.Max(0,logBox.Text.Length - 1);
            logBox.ScrollToCaret();
        }

        void adminTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleRefresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person user = Session.GetCurrentUser();

            if (user == null || !user.IsAdmin())
            {
                MessageBoxCreator.RaiseWarning("Alleen voor admins");
                return;
            }

            if (MessageBox.Show("Weet je zeker dat je alle gegevens over mutaties in het verleden wilt wissen?", "Wissen", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                logBox.Text = "";
                Session.ClearHistory();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        public void ShowSelectedPeriod()
        {
            //Todo:
            if (periodSelectionBox.SelectedItem != null)
            {
                PeriodicReport pr = (periodSelectionBox.SelectedItem as PeriodicReport);

                if (pr != null)
                {
                    finalView1.SetData(pr.CalculateTotals());
                    return;
                }
            }
            finalView1.SetData(Session.GetCurrentReport().CalculateTotals());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OtherBuysDialog obd = new OtherBuysDialog();
            obd.ShowDialog();
            obd.Dispose();
        }

        private void radioTransactions_CheckedChanged(object sender, EventArgs e)
        {
            FillLogBox();
        }

        private void periodSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedPeriod();
        }
    }
}
