namespace BBS
{
    partial class AdminLoginWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.adminCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vul wachtwoord in:";
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(20, 82);
            this.pwBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwBox.Name = "pwBox";
            this.pwBox.Size = new System.Drawing.Size(399, 22);
            this.pwBox.TabIndex = 1;
            this.pwBox.UseSystemPasswordChar = true;
            this.pwBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwBox_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminCombo
            // 
            this.adminCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.adminCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCombo.FormattingEnabled = true;
            this.adminCombo.Location = new System.Drawing.Point(20, 16);
            this.adminCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminCombo.Name = "adminCombo";
            this.adminCombo.Size = new System.Drawing.Size(399, 33);
            this.adminCombo.TabIndex = 7;
            this.adminCombo.SelectedIndexChanged += new System.EventHandler(this.adminCombo_SelectedIndexChanged);
            // 
            // AdminLoginWindow
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 178);
            this.Controls.Add(this.adminCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminLoginWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox adminCombo;
    }
}