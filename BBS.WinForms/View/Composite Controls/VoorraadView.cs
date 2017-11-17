using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BBS.View.DataLists.DataItems;

namespace BBS
{
    public partial class VoorraadView : UserControl
    {
        public VoorraadView()
        {
            InitializeComponent();
            this.VerticalScroll.Enabled = false;
            this.HorizontalScroll.Enabled = false;
            dataGridView1.OnDeleteClicked = OnProductDelete;
            dataGridView1.OnEditClicked = OnProductEdit;

            FillControl();
        }

        private void OnProductDelete(object rowData)
        {
            var targetProduct = ((ProductStockItem)rowData).GetProduct();
            Person currentUser = Session.GetCurrentUser();
            if (!currentUser.IsBar())
            {
                MessageBoxCreator.RaiseWarning("Alleen admins kunnen producten verwijderen.");
                return;
            }

            if (MessageBox.Show("Weet je zeker dat dit product verwijderd moet worden?!", "Product verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                if (!Stock.RemoveProduct(targetProduct))
                    MessageBoxCreator.RaiseWarning("Kan dit product niet verwijderen, onbekende fout.");
                else
                {
                    targetProduct = null;
                    FillControl();
                }
            }
        }

        private void OnProductEdit(object rowData)
        {
            var targetProduct = ((ProductStockItem)rowData).GetProduct();
            EditProduct ep = new EditProduct(targetProduct);
            ep.ShowDialog();
            FillControl();
            ep.Dispose();
        }

        public void FillControl()
        {
            voorraadWaarschuwingenCheckBox.Checked = Session.ShouldShowProductAmountWarnings;
            dataGridView1.SetData(Stock.Products.Select(p => new ProductStockItem(p)).OrderBy(pi => pi.Name).ToList());
        }

        private void AddNewProductClick(object sender, EventArgs e)
        {
            InputBox ib = new InputBox();
            if (ib.ShowDialog() == DialogResult.OK)
            {
                String input = ib.GetInput();

                if (Stock.ExistsProductWithName(input))
                {
                    MessageBoxCreator.RaiseWarning("Product met die naam bestaat al, kies een ander");
                    return;
                }

                Product p = new Product(input);
                EditProduct ep = new EditProduct(p);
                ep.ShowDialog();
                ep.Dispose();
                Stock.AddProduct(p);
                FillControl();
            }
            ib.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Session.ShouldShowProductAmountWarnings = voorraadWaarschuwingenCheckBox.Checked;
        }
    }
}
