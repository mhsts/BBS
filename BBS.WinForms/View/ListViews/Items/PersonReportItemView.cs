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
    public partial class PersonReportItemView : SortableItemView
    {
        private PersonReport personR;

        public PersonReportItemView(PersonReport pr)
        {
            personR = pr;
            InitializeComponent();
            FillControl();       
        }

        public void FillControl()
        {
            nameLbl.Text = personR.Owner.Name;
            Decimal uitstaandPeriod = personR.Deposited - personR.Spend;
            
            uitstaandPeriodLbl.Text = String.Format("{0:0.00}",uitstaandPeriod);
            uitstaandLbl.Text = String.Format("{0:0.00}", personR.Owner.Balance);

            SetColorBySign(uitstaandPeriodLbl, uitstaandPeriod);
            SetColorBySign(uitstaandLbl, personR.Owner.Balance);
        }
    }
}
