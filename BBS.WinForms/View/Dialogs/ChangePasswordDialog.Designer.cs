namespace BBS
{
    partial class ChangePasswordDialog
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
            this.pwTxt2 = new System.Windows.Forms.TextBox();
            this.pwTxt1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oldPassWTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pwTxt2
            // 
            this.pwTxt2.Location = new System.Drawing.Point(136, 84);
            this.pwTxt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwTxt2.Name = "pwTxt2";
            this.pwTxt2.Size = new System.Drawing.Size(271, 22);
            this.pwTxt2.TabIndex = 6;
            this.pwTxt2.UseSystemPasswordChar = true;
            // 
            // pwTxt1
            // 
            this.pwTxt1.Location = new System.Drawing.Point(136, 52);
            this.pwTxt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwTxt1.Name = "pwTxt1";
            this.pwTxt1.Size = new System.Drawing.Size(271, 22);
            this.pwTxt1.TabIndex = 5;
            this.pwTxt1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Herhaal wachtwoord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Oud wachtwoord";
            // 
            // oldPassWTxt
            // 
            this.oldPassWTxt.Location = new System.Drawing.Point(136, 7);
            this.oldPassWTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oldPassWTxt.Name = "oldPassWTxt";
            this.oldPassWTxt.Size = new System.Drawing.Size(271, 22);
            this.oldPassWTxt.TabIndex = 4;
            this.oldPassWTxt.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nieuw wachtwoord";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(215, 116);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(97, 28);
            this.buttonAccept.TabIndex = 10;
            this.buttonAccept.Text = "Ok";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(320, 116);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 28);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Annuleren";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ChangePasswordDialog
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(424, 154);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.oldPassWTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwTxt2);
            this.Controls.Add(this.pwTxt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wachtwoord veranderen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwTxt2;
        private System.Windows.Forms.TextBox pwTxt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPassWTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
    }
}