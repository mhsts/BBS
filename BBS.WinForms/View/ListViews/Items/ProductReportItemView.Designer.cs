namespace BBS
{
    partial class ProductReportItemView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLbl = new System.Windows.Forms.Label();
            this.amountLbl = new System.Windows.Forms.Label();
            this.brutoLbl = new System.Windows.Forms.Label();
            this.writeOffLbl = new System.Windows.Forms.Label();
            this.nettoLbl = new System.Windows.Forms.Label();
            this.freeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.Location = new System.Drawing.Point(0, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(60, 15);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Bier";
            // 
            // amountLbl
            // 
            this.amountLbl.Location = new System.Drawing.Point(60, 0);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(30, 15);
            this.amountLbl.TabIndex = 1;
            this.amountLbl.Text = "52";
            // 
            // brutoLbl
            // 
            this.brutoLbl.Location = new System.Drawing.Point(105, 0);
            this.brutoLbl.Name = "brutoLbl";
            this.brutoLbl.Size = new System.Drawing.Size(51, 15);
            this.brutoLbl.TabIndex = 2;
            this.brutoLbl.Text = "Bruto";
            // 
            // writeOffLbl
            // 
            this.writeOffLbl.Location = new System.Drawing.Point(141, 0);
            this.writeOffLbl.Name = "writeOffLbl";
            this.writeOffLbl.Size = new System.Drawing.Size(51, 15);
            this.writeOffLbl.TabIndex = 3;
            this.writeOffLbl.Text = "Afschrijving";
            // 
            // nettoLbl
            // 
            this.nettoLbl.Location = new System.Drawing.Point(207, 0);
            this.nettoLbl.Name = "nettoLbl";
            this.nettoLbl.Size = new System.Drawing.Size(51, 15);
            this.nettoLbl.TabIndex = 4;
            this.nettoLbl.Text = "Netto";
            // 
            // freeLbl
            // 
            this.freeLbl.Location = new System.Drawing.Point(257, 0);
            this.freeLbl.Name = "freeLbl";
            this.freeLbl.Size = new System.Drawing.Size(30, 15);
            this.freeLbl.TabIndex = 5;
            this.freeLbl.Text = "5";
            // 
            // ProductReportItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.freeLbl);
            this.Controls.Add(this.nettoLbl);
            this.Controls.Add(this.writeOffLbl);
            this.Controls.Add(this.brutoLbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "ProductReportItemView";
            this.Size = new System.Drawing.Size(290, 15);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label brutoLbl;
        private System.Windows.Forms.Label writeOffLbl;
        private System.Windows.Forms.Label nettoLbl;
        private System.Windows.Forms.Label freeLbl;
    }
}
