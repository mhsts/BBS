namespace BBS.View
{
    partial class ReportView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cashLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uitstaandLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inkopenLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inkomstenLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nettoWinstLbl = new System.Windows.Forms.Label();
            this.aankopenLbl = new System.Windows.Forms.Label();
            this.afschrijvingenLbl = new System.Windows.Forms.Label();
            this.brutoWinstLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.otherBuysList = new System.Windows.Forms.ListBox();
            this.stockAdditionsList = new System.Windows.Forms.ListBox();
            this.personenPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prodPanel = new BBS.ListPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.cashLbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.uitstaandLbl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.inkopenLbl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.inkomstenLbl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(537, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cashLbl
            // 
            this.cashLbl.AutoSize = true;
            this.cashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLbl.ForeColor = System.Drawing.Color.Red;
            this.cashLbl.Location = new System.Drawing.Point(141, 70);
            this.cashLbl.Name = "cashLbl";
            this.cashLbl.Size = new System.Drawing.Size(53, 16);
            this.cashLbl.TabIndex = 1;
            this.cashLbl.Text = "€ -24,50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Inkomsten";
            // 
            // uitstaandLbl
            // 
            this.uitstaandLbl.AutoSize = true;
            this.uitstaandLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uitstaandLbl.Location = new System.Drawing.Point(141, 43);
            this.uitstaandLbl.Name = "uitstaandLbl";
            this.uitstaandLbl.Size = new System.Drawing.Size(53, 16);
            this.uitstaandLbl.TabIndex = 1;
            this.uitstaandLbl.Text = "€ -17,50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Voorraad inkopen";
            // 
            // inkopenLbl
            // 
            this.inkopenLbl.AutoSize = true;
            this.inkopenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkopenLbl.Location = new System.Drawing.Point(141, 27);
            this.inkopenLbl.Name = "inkopenLbl";
            this.inkopenLbl.Size = new System.Drawing.Size(53, 16);
            this.inkopenLbl.TabIndex = 1;
            this.inkopenLbl.Text = "€ -11,50";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Uitstaand (periode)";
            // 
            // inkomstenLbl
            // 
            this.inkomstenLbl.AutoSize = true;
            this.inkomstenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkomstenLbl.Location = new System.Drawing.Point(141, 11);
            this.inkomstenLbl.Name = "inkomstenLbl";
            this.inkomstenLbl.Size = new System.Drawing.Size(42, 16);
            this.inkomstenLbl.TabIndex = 1;
            this.inkomstenLbl.Text = "€ 3,50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cash (periode)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.nettoWinstLbl);
            this.groupBox2.Controls.Add(this.aankopenLbl);
            this.groupBox2.Controls.Add(this.afschrijvingenLbl);
            this.groupBox2.Controls.Add(this.brutoWinstLbl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(139, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 206);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // nettoWinstLbl
            // 
            this.nettoWinstLbl.AutoSize = true;
            this.nettoWinstLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nettoWinstLbl.Location = new System.Drawing.Point(126, 70);
            this.nettoWinstLbl.Name = "nettoWinstLbl";
            this.nettoWinstLbl.Size = new System.Drawing.Size(42, 16);
            this.nettoWinstLbl.TabIndex = 1;
            this.nettoWinstLbl.Text = "€ 3,50";
            // 
            // aankopenLbl
            // 
            this.aankopenLbl.AutoSize = true;
            this.aankopenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aankopenLbl.Location = new System.Drawing.Point(126, 43);
            this.aankopenLbl.Name = "aankopenLbl";
            this.aankopenLbl.Size = new System.Drawing.Size(49, 16);
            this.aankopenLbl.TabIndex = 1;
            this.aankopenLbl.Text = "€ - 5,00";
            // 
            // afschrijvingenLbl
            // 
            this.afschrijvingenLbl.AutoSize = true;
            this.afschrijvingenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afschrijvingenLbl.Location = new System.Drawing.Point(126, 27);
            this.afschrijvingenLbl.Name = "afschrijvingenLbl";
            this.afschrijvingenLbl.Size = new System.Drawing.Size(46, 16);
            this.afschrijvingenLbl.TabIndex = 1;
            this.afschrijvingenLbl.Text = "€ -1,50";
            // 
            // brutoWinstLbl
            // 
            this.brutoWinstLbl.AutoSize = true;
            this.brutoWinstLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brutoWinstLbl.Location = new System.Drawing.Point(126, 11);
            this.brutoWinstLbl.Name = "brutoWinstLbl";
            this.brutoWinstLbl.Size = new System.Drawing.Size(49, 16);
            this.brutoWinstLbl.TabIndex = 1;
            this.brutoWinstLbl.Text = "€ 10,50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Netto winst";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Overige aankopen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Afschrijvingen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bruto winst";
            // 
            // otherBuysList
            // 
            this.otherBuysList.FormattingEnabled = true;
            this.otherBuysList.Location = new System.Drawing.Point(3, 318);
            this.otherBuysList.Name = "otherBuysList";
            this.otherBuysList.Size = new System.Drawing.Size(130, 199);
            this.otherBuysList.TabIndex = 16;
            // 
            // stockAdditionsList
            // 
            this.stockAdditionsList.FormattingEnabled = true;
            this.stockAdditionsList.Location = new System.Drawing.Point(348, 318);
            this.stockAdditionsList.Name = "stockAdditionsList";
            this.stockAdditionsList.Size = new System.Drawing.Size(183, 199);
            this.stockAdditionsList.TabIndex = 16;
            // 
            // personenPanel
            // 
            this.personenPanel.BackColor = System.Drawing.Color.LightCyan;
            this.personenPanel.Location = new System.Drawing.Point(281, 14);
            this.personenPanel.Name = "personenPanel";
            this.personenPanel.Size = new System.Drawing.Size(457, 297);
            this.personenPanel.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 14);
            this.panel1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 30);
            this.label9.TabIndex = 24;
            this.label9.Text = "Gratis";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(643, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "Uitstaand (totaal)";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(572, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 27);
            this.label16.TabIndex = 18;
            this.label16.Text = "Uitstaand (periode)";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(506, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "Naam";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(206, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 30);
            this.label18.TabIndex = 23;
            this.label18.Text = "Netto";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(138, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 30);
            this.label19.TabIndex = 22;
            this.label19.Text = "Afschrijving";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(421, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 15);
            this.label20.TabIndex = 13;
            this.label20.Text = "Uitstaand (totaal)";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(346, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 27);
            this.label21.TabIndex = 14;
            this.label21.Text = "Uitstaand (periode)";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(283, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 15);
            this.label22.TabIndex = 15;
            this.label22.Text = "Naam";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(102, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 30);
            this.label23.TabIndex = 21;
            this.label23.Text = "Bruto";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(60, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 30);
            this.label24.TabIndex = 20;
            this.label24.Text = "Aantal";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 30);
            this.label25.TabIndex = 19;
            this.label25.Text = "Product";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(505, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 296);
            this.panel2.TabIndex = 0;
            // 
            // prodPanel
            // 
            this.prodPanel.AutoScroll = true;
            this.prodPanel.BackColor = System.Drawing.Color.LightCyan;
            this.prodPanel.Location = new System.Drawing.Point(3, 14);
            this.prodPanel.Name = "prodPanel";
            this.prodPanel.Size = new System.Drawing.Size(275, 297);
            this.prodPanel.SuspendLayout = false;
            this.prodPanel.TabIndex = 0;
            this.prodPanel.UseRowColoring = true;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.prodPanel);
            this.Controls.Add(this.personenPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stockAdditionsList);
            this.Controls.Add(this.otherBuysList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ReportView";
            this.Size = new System.Drawing.Size(741, 526);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListPanel prodPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nettoWinstLbl;
        private System.Windows.Forms.Label aankopenLbl;
        private System.Windows.Forms.Label afschrijvingenLbl;
        private System.Windows.Forms.Label brutoWinstLbl;
        private System.Windows.Forms.Label cashLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label uitstaandLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label inkopenLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label inkomstenLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox otherBuysList;
        private System.Windows.Forms.ListBox stockAdditionsList;
        private System.Windows.Forms.FlowLayoutPanel personenPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
    }
}
