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
    public partial class ReportView : UserControl
    {
        public ReportView()
        {
            InitializeComponent();
            prodPanel.AutoScroll = true;
            prodPanel.HorizontalScroll.Enabled = false;
            prodPanel.VerticalScroll.Enabled = true;
            personenPanel.AutoScroll = true;
            personenPanel.HorizontalScroll.Enabled = false;
            personenPanel.VerticalScroll.Enabled = true;
        }

        public void SetData(PeriodicReportDataSet data)
        {
            prodPanel.SuspendLayout();

            prodPanel.Controls.Clear();
            foreach (ProductReport prodr in data.ProductReports)
                prodPanel.Controls.Add(new ProductReportItemView(prodr));

            prodPanel.ResumeLayout();

            personenPanel.SuspendLayout();

            personenPanel.Controls.Clear();
            foreach (PersonReport pr in data.PersonReports)
                personenPanel.Controls.Add(new PersonReportItemView(pr));

            personenPanel.ResumeLayout();

            brutoWinstLbl.Text = String.Format("{0:0.00}", data.BrutoWinst);
            afschrijvingenLbl.Text = String.Format("{0:0.00}", data.Afschrijvingen);
            aankopenLbl.Text = String.Format("{0:0.00}", -data.AndereInkopen);

            nettoWinstLbl.Text = String.Format("{0:0.00}", data.NettoWinst);
            inkomstenLbl.Text = String.Format("{0:0.00}", data.Inkomsten);

            inkopenLbl.Text = String.Format("{0:0.00}", -data.Inkopen);
            uitstaandLbl.Text = String.Format("{0:0.00}", -data.Uitstaand);
            cashLbl.Text = String.Format("{0:0.00}", data.Cash);

            SortableItemView.SetColorBySign(brutoWinstLbl, data.BrutoWinst);
            SortableItemView.SetColorBySign(inkomstenLbl, data.Inkomsten);
            SortableItemView.SetColorBySign(nettoWinstLbl, data.NettoWinst);

            SortableItemView.SetColorBySign(afschrijvingenLbl, data.Afschrijvingen);
            SortableItemView.SetColorBySign(aankopenLbl, -data.AndereInkopen);
            SortableItemView.SetColorBySign(inkopenLbl, -data.Inkopen);
            SortableItemView.SetColorBySign(uitstaandLbl, -data.Uitstaand);

            SortableItemView.SetColorBySign(cashLbl, data.Cash);

            otherBuysList.SuspendLayout();

            otherBuysList.Items.Clear();

            if (data.OtherBuys.Count == 0)
                otherBuysList.Items.Add("...geen overige aankopen...");
            else
                foreach (OtherBuys ob in data.OtherBuys)
                    otherBuysList.Items.Add(ob);

            otherBuysList.ResumeLayout();

            stockAdditionsList.SuspendLayout();

            stockAdditionsList.Items.Clear();

            if (data.StockAdditions.Count == 0)
                stockAdditionsList.Items.Add("...geen nieuwe voorraad...");
            else
            {
                Dictionary<Product, int> productAdditions = new Dictionary<Product, int>();
                
                foreach (StockAddition sa in data.StockAdditions)
                {
                    if (!productAdditions.ContainsKey(sa.Product))
                        productAdditions.Add(sa.Product, 0); //set to 0, amount added later:

                    productAdditions[sa.Product] += sa.Amount;                    
                }

                foreach (Product p in productAdditions.Keys)
                    stockAdditionsList.Items.Add("Aanvulling " + p.Name + " met " + productAdditions[p] + " stuks");
            }
            stockAdditionsList.ResumeLayout();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
