using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using BBS.Model;

namespace BBS
{
    public partial class EditProduct : Form
    {
        Product editProduct;

        public EditProduct(Product p)
        {
            InitializeComponent();

            editProduct = p;
            
            discountCombo.DataSource = Enum.GetValues(typeof(DiscountType));
            catCombo.DataSource = Enum.GetValues(typeof(ProductCategory));

            FillControl();
        }

        public void FillControl()
        {
            nameLabel.Text = "Product: " + editProduct.Name;
            priceTxt.Text = editProduct.Price.ToString();
            buyPriceTxt.Text = editProduct.BuyPrice.ToString();
            voorraadLbl.Text = editProduct.Amount.ToString();
            barcodeTxt.Text = editProduct.BarCode.Value;
            discountCombo.SelectedItem = editProduct.Discount;
            catCombo.SelectedItem = editProduct.Category;
            checkBox1.Checked = editProduct.Active;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Logger.Log("Product gewijzigd");

            try
            {
                editProduct.Price = DecimalExtensions.ParseInvariant(priceTxt.Text);
                editProduct.BuyPrice = DecimalExtensions.ParseInvariant(buyPriceTxt.Text);
                editProduct.BarCode.Value = barcodeTxt.Text;
                editProduct.Discount = (DiscountType)discountCombo.SelectedItem;
                editProduct.Category = (ProductCategory)catCombo.SelectedItem;
                editProduct.Active = checkBox1.Checked;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ee)
            {
                MessageBoxCreator.RaiseError("Fout in tekst velden (gebruik juiste decimaal teken)",ee);
            }
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voorraad aanvullen?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int am = Int32.Parse(addTxt.Text);
                    if (am <= 0)
                        MessageBoxCreator.RaiseWarning("Ongeldig aantal.");
                    else
                    {
                        StockAddition sa = new StockAddition(editProduct, am);
                        Session.AddBarMutation(sa);
                        addTxt.Text = "";
                        voorraadLbl.Text = editProduct.Amount.ToString();
                    }
                }
                catch (Exception ee)
                {
                    MessageBoxCreator.RaiseError("Fout in tekst veld.",ee);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voorraad afschrijven?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int am = Int32.Parse(afschrijfTxt.Text);
                    if (am <= 0)
                        MessageBoxCreator.RaiseWarning("Ongeldig aantal.");
                    else
                    {
                        WriteOff wo = new WriteOff(editProduct, am);
                        Session.AddBarMutation(wo);
                        afschrijfTxt.Text = "";
                        voorraadLbl.Text = editProduct.Amount.ToString();
                    }
                }
                catch (Exception ee)
                {
                    MessageBoxCreator.RaiseError("Fout in tekst veld.",ee);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Session.GetCurrentUser().IsAdmin())
            {
                MessageBox.Show("Alleen voor admins, sorry");
                return;
            }

            if (MessageBox.Show("Voorraad op nul zetten, zeker weten? Doe dit alleen als je weet wat je doet, dit gaat buiten de eindafrekening om!!!", "Waarschuwing", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                editProduct.Amount = 0;
                Logger.Log(String.Format("{0} heeft voorraad van {1} gereset", Session.GetCurrentUser().Name, editProduct.Name));
            }
        }
    }
}
