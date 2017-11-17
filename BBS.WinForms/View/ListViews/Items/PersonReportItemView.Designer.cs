namespace BBS
{
    partial class PersonReportItemView
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
            this.uitstaandPeriodLbl = new System.Windows.Forms.Label();
            this.uitstaandLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameLbl.Location = new System.Drawing.Point(0, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(85, 15);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "RecoveryAdmin";
            // 
            // uitstaandPeriodLbl
            // 
            this.uitstaandPeriodLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.uitstaandPeriodLbl.Location = new System.Drawing.Point(85, 0);
            this.uitstaandPeriodLbl.Name = "uitstaandPeriodLbl";
            this.uitstaandPeriodLbl.Size = new System.Drawing.Size(53, 15);
            this.uitstaandPeriodLbl.TabIndex = 2;
            this.uitstaandPeriodLbl.Text = "E -10,50";
            // 
            // uitstaandLbl
            // 
            this.uitstaandLbl.Location = new System.Drawing.Point(147, 0);
            this.uitstaandLbl.Name = "uitstaandLbl";
            this.uitstaandLbl.Size = new System.Drawing.Size(50, 15);
            this.uitstaandLbl.TabIndex = 3;
            this.uitstaandLbl.Text = "E -15,50";
            // 
            // PersonReportItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uitstaandLbl);
            this.Controls.Add(this.uitstaandPeriodLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "PersonReportItemView";
            this.Size = new System.Drawing.Size(219, 15);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label uitstaandPeriodLbl;
        private System.Windows.Forms.Label uitstaandLbl;
    }
}
