namespace BBS
{
    partial class NewUserDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpAccnt = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pwTxt1 = new System.Windows.Forms.TextBox();
            this.pwTxt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.barCodeTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(128, 15);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(271, 22);
            this.nameTxt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(312, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Annuleren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpAccnt
            // 
            this.grpAccnt.AutoSize = true;
            this.grpAccnt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.grpAccnt.Location = new System.Drawing.Point(15, 169);
            this.grpAccnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAccnt.Name = "grpAccnt";
            this.grpAccnt.Size = new System.Drawing.Size(119, 20);
            this.grpAccnt.TabIndex = 4;
            this.grpAccnt.Text = "Groepsaccount";
            this.grpAccnt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naam";
            // 
            // pwTxt1
            // 
            this.pwTxt1.Location = new System.Drawing.Point(128, 55);
            this.pwTxt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwTxt1.Name = "pwTxt1";
            this.pwTxt1.Size = new System.Drawing.Size(271, 22);
            this.pwTxt1.TabIndex = 1;
            this.pwTxt1.UseSystemPasswordChar = true;
            // 
            // pwTxt2
            // 
            this.pwTxt2.Location = new System.Drawing.Point(128, 87);
            this.pwTxt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwTxt2.Name = "pwTxt2";
            this.pwTxt2.Size = new System.Drawing.Size(271, 22);
            this.pwTxt2.TabIndex = 2;
            this.pwTxt2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Herhaal wachtwoord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wachtwoord *";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "* Gebruik geen wachtwoord dat je ook voor andere zaken gebruikt.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Barcode";
            // 
            // barCodeTxt
            // 
            this.barCodeTxt.Location = new System.Drawing.Point(128, 137);
            this.barCodeTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barCodeTxt.Name = "barCodeTxt";
            this.barCodeTxt.Size = new System.Drawing.Size(271, 22);
            this.barCodeTxt.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 240);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Aanmaken";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewUserDialog
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(416, 283);
            this.Controls.Add(this.barCodeTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pwTxt2);
            this.Controls.Add(this.pwTxt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpAccnt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUserDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nieuwe gebruiker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox grpAccnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwTxt1;
        private System.Windows.Forms.TextBox pwTxt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox barCodeTxt;
        private System.Windows.Forms.Button button2;
    }
}