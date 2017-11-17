namespace BBS
{
    partial class EditPerson
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
            this.components = new System.ComponentModel.Container();
            this.depositBtn = new System.Windows.Forms.Button();
            this.depositTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.makeAdmin = new System.Windows.Forms.Button();
            this.makeBar = new System.Windows.Forms.Button();
            this.groupsAccountChkBox = new System.Windows.Forms.CheckBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tegoedLabel = new System.Windows.Forms.Label();
            this.makeNormal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.barcode2Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(263, 94);
            this.depositBtn.Margin = new System.Windows.Forms.Padding(4);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(100, 28);
            this.depositBtn.TabIndex = 0;
            this.depositBtn.Text = "Storten";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // depositTxt
            // 
            this.depositTxt.Location = new System.Drawing.Point(16, 97);
            this.depositTxt.Margin = new System.Windows.Forms.Padding(4);
            this.depositTxt.Name = "depositTxt";
            this.depositTxt.Size = new System.Drawing.Size(237, 22);
            this.depositTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vul een bedrag in om te \'storten\':";
            // 
            // makeAdmin
            // 
            this.makeAdmin.Location = new System.Drawing.Point(8, 95);
            this.makeAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.makeAdmin.Name = "makeAdmin";
            this.makeAdmin.Size = new System.Drawing.Size(331, 28);
            this.makeAdmin.TabIndex = 3;
            this.makeAdmin.Text = "Maak \'admin\'";
            this.makeAdmin.UseVisualStyleBackColor = true;
            this.makeAdmin.Click += new System.EventHandler(this.makeAdmin_Click);
            // 
            // makeBar
            // 
            this.makeBar.Location = new System.Drawing.Point(8, 59);
            this.makeBar.Margin = new System.Windows.Forms.Padding(4);
            this.makeBar.Name = "makeBar";
            this.makeBar.Size = new System.Drawing.Size(331, 28);
            this.makeBar.TabIndex = 3;
            this.makeBar.Text = "Maak \'bar\'";
            this.makeBar.UseVisualStyleBackColor = true;
            this.makeBar.Click += new System.EventHandler(this.makeBar_Click);
            // 
            // groupsAccountChkBox
            // 
            this.groupsAccountChkBox.AutoSize = true;
            this.groupsAccountChkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.groupsAccountChkBox.Location = new System.Drawing.Point(13, 225);
            this.groupsAccountChkBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupsAccountChkBox.Name = "groupsAccountChkBox";
            this.groupsAccountChkBox.Size = new System.Drawing.Size(119, 20);
            this.groupsAccountChkBox.TabIndex = 4;
            this.groupsAccountChkBox.Text = "Groepsaccount";
            this.groupsAccountChkBox.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 11);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(126, 16);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Persoon: X";
            // 
            // tegoedLabel
            // 
            this.tegoedLabel.AutoSize = true;
            this.tegoedLabel.Location = new System.Drawing.Point(12, 39);
            this.tegoedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tegoedLabel.Name = "tegoedLabel";
            this.tegoedLabel.Size = new System.Drawing.Size(99, 16);
            this.tegoedLabel.TabIndex = 6;
            this.tegoedLabel.Text = "Huidig tegoed: ";
            // 
            // makeNormal
            // 
            this.makeNormal.Location = new System.Drawing.Point(8, 23);
            this.makeNormal.Margin = new System.Windows.Forms.Padding(4);
            this.makeNormal.Name = "makeNormal";
            this.makeNormal.Size = new System.Drawing.Size(331, 28);
            this.makeNormal.TabIndex = 3;
            this.makeNormal.Text = "Maak \'normaal\'";
            this.makeNormal.UseVisualStyleBackColor = true;
            this.makeNormal.Click += new System.EventHandler(this.makeNormal_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 401);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Opslaan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Location = new System.Drawing.Point(128, 134);
            this.barcodeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(233, 22);
            this.barcodeTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Barcode";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Wachtwoord wijzigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 401);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Annuleren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.makeNormal);
            this.groupBox1.Controls.Add(this.makeAdmin);
            this.groupBox1.Controls.Add(this.makeBar);
            this.groupBox1.Location = new System.Drawing.Point(19, 253);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(347, 140);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Barcode 2";
            // 
            // barcode2Txt
            // 
            this.barcode2Txt.Location = new System.Drawing.Point(128, 164);
            this.barcode2Txt.Margin = new System.Windows.Forms.Padding(4);
            this.barcode2Txt.Name = "barcode2Txt";
            this.barcode2Txt.Size = new System.Drawing.Size(233, 22);
            this.barcode2Txt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email adres";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 195);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditPerson
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 440);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barcode2Txt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barcodeTxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tegoedLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.groupsAccountChkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depositTxt);
            this.Controls.Add(this.depositBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPerson";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Persoon bewerken";
            this.Load += new System.EventHandler(this.EditPerson_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.TextBox depositTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button makeAdmin;
        private System.Windows.Forms.Button makeBar;
        private System.Windows.Forms.CheckBox groupsAccountChkBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label tegoedLabel;
        private System.Windows.Forms.Button makeNormal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barcode2Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}