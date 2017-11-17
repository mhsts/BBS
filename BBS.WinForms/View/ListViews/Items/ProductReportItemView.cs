using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBS
{
    public partial class ProductReportItemView : SortableItemView
    {
        ProductReport productR;

        public ProductReportItemView(ProductReport pr)
        {
            productR = pr;
            InitializeComponent();
            FillControl();
        }

        public void FillControl()
        {
            nameLbl.Text = productR.Product.Name;
            amountLbl.Text = productR.Amount.ToString();
            brutoLbl.Text = String.Format("{0:0.00}", productR.GrossIncome);
            writeOffLbl.Text = String.Format("{0:0.00} ({1})", -productR.AmountWriteOffCost, productR.AmountWriteOff);
            Decimal netto = productR.GrossIncome - productR.AmountWriteOffCost;
            nettoLbl.Text = String.Format("{0:0.00}", netto);
            freeLbl.Text = productR.NumFree.ToString();

            SetColorBySign(brutoLbl, productR.GrossIncome);
            SetColorBySign(writeOffLbl, -productR.AmountWriteOffCost);
            SetColorBySign(nettoLbl, netto);
        }
    }
}
