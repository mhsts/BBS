namespace BBS.View
{
    partial class AdminTabs
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
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.voorraadTab = new System.Windows.Forms.TabPage();
            this.voorraadView1 = new BBS.VoorraadView();
            this.balansTab = new System.Windows.Forms.TabPage();
            this.balansView1 = new BBS.BalansView();
            this.resTab = new System.Windows.Forms.TabPage();
            this.finalView1 = new BBS.View.ReportView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.periodSelectionBox = new System.Windows.Forms.ComboBox();
            this.logTab = new System.Windows.Forms.TabPage();
            this.logBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioLog = new System.Windows.Forms.RadioButton();
            this.radioTransactions = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminTabControl.SuspendLayout();
            this.voorraadTab.SuspendLayout();
            this.balansTab.SuspendLayout();
            this.resTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.logTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.voorraadTab);
            this.adminTabControl.Controls.Add(this.balansTab);
            this.adminTabControl.Controls.Add(this.resTab);
            this.adminTabControl.Controls.Add(this.logTab);
            this.adminTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabControl.Location = new System.Drawing.Point(0, 0);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(1215, 455);
            this.adminTabControl.TabIndex = 1;
            // 
            // voorraadTab
            // 
            this.voorraadTab.Controls.Add(this.voorraadView1);
            this.voorraadTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voorraadTab.Location = new System.Drawing.Point(4, 40);
            this.voorraadTab.Name = "voorraadTab";
            this.voorraadTab.Size = new System.Drawing.Size(1207, 411);
            this.voorraadTab.TabIndex = 0;
            this.voorraadTab.Text = "Voorraad";
            this.voorraadTab.UseVisualStyleBackColor = true;
            // 
            // voorraadView1
            // 
            this.voorraadView1.BackColor = System.Drawing.SystemColors.Control;
            this.voorraadView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voorraadView1.Location = new System.Drawing.Point(0, 0);
            this.voorraadView1.Name = "voorraadView1";
            this.voorraadView1.Size = new System.Drawing.Size(1207, 411);
            this.voorraadView1.TabIndex = 0;
            // 
            // balansTab
            // 
            this.balansTab.Controls.Add(this.balansView1);
            this.balansTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balansTab.Location = new System.Drawing.Point(4, 40);
            this.balansTab.Name = "balansTab";
            this.balansTab.Size = new System.Drawing.Size(1207, 435);
            this.balansTab.TabIndex = 2;
            this.balansTab.Text = "Personen";
            this.balansTab.UseVisualStyleBackColor = true;
            // 
            // balansView1
            // 
            this.balansView1.BackColor = System.Drawing.SystemColors.Control;
            this.balansView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.balansView1.Location = new System.Drawing.Point(0, 0);
            this.balansView1.Name = "balansView1";
            this.balansView1.Size = new System.Drawing.Size(1207, 435);
            this.balansView1.TabIndex = 0;
            // 
            // resTab
            // 
            this.resTab.Controls.Add(this.finalView1);
            this.resTab.Controls.Add(this.panel2);
            this.resTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resTab.Location = new System.Drawing.Point(4, 40);
            this.resTab.Name = "resTab";
            this.resTab.Size = new System.Drawing.Size(1207, 435);
            this.resTab.TabIndex = 3;
            this.resTab.Text = "Afrekening";
            this.resTab.UseVisualStyleBackColor = true;
            // 
            // finalView1
            // 
            this.finalView1.BackColor = System.Drawing.SystemColors.Control;
            this.finalView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalView1.Location = new System.Drawing.Point(0, 21);
            this.finalView1.Name = "finalView1";
            this.finalView1.Size = new System.Drawing.Size(1207, 414);
            this.finalView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.periodSelectionBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 21);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 21);
            this.button3.TabIndex = 2;
            this.button3.Text = "Andere aankopen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // periodSelectionBox
            // 
            this.periodSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodSelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodSelectionBox.FormattingEnabled = true;
            this.periodSelectionBox.Location = new System.Drawing.Point(3, 2);
            this.periodSelectionBox.Name = "periodSelectionBox";
            this.periodSelectionBox.Size = new System.Drawing.Size(199, 20);
            this.periodSelectionBox.TabIndex = 0;
            this.periodSelectionBox.SelectedIndexChanged += new System.EventHandler(this.periodSelectionBox_SelectedIndexChanged);
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.logBox);
            this.logTab.Controls.Add(this.panel1);
            this.logTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTab.Location = new System.Drawing.Point(4, 40);
            this.logTab.Name = "logTab";
            this.logTab.Size = new System.Drawing.Size(1207, 435);
            this.logTab.TabIndex = 1;
            this.logTab.Text = "                          Geschiedenis";
            this.logTab.UseVisualStyleBackColor = true;
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Location = new System.Drawing.Point(0, 29);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(1207, 406);
            this.logBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioLog);
            this.panel1.Controls.Add(this.radioTransactions);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 29);
            this.panel1.TabIndex = 1;
            // 
            // radioLog
            // 
            this.radioLog.AutoSize = true;
            this.radioLog.Location = new System.Drawing.Point(429, 6);
            this.radioLog.Name = "radioLog";
            this.radioLog.Size = new System.Drawing.Size(43, 17);
            this.radioLog.TabIndex = 2;
            this.radioLog.Text = "Log";
            this.radioLog.UseVisualStyleBackColor = true;
            // 
            // radioTransactions
            // 
            this.radioTransactions.AutoSize = true;
            this.radioTransactions.Checked = true;
            this.radioTransactions.Location = new System.Drawing.Point(337, 6);
            this.radioTransactions.Name = "radioTransactions";
            this.radioTransactions.Size = new System.Drawing.Size(80, 17);
            this.radioTransactions.TabIndex = 1;
            this.radioTransactions.TabStop = true;
            this.radioTransactions.Text = "Transacties";
            this.radioTransactions.UseVisualStyleBackColor = true;
            this.radioTransactions.CheckedChanged += new System.EventHandler(this.radioTransactions_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wis ALLES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1215, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Support / vragen: BBS @ scoutingboskoop . nl";
            // 
            // AdminTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminTabControl);
            this.Controls.Add(this.label1);
            this.Name = "AdminTabs";
            this.Size = new System.Drawing.Size(1215, 479);
            this.adminTabControl.ResumeLayout(false);
            this.voorraadTab.ResumeLayout(false);
            this.balansTab.ResumeLayout(false);
            this.resTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.logTab.ResumeLayout(false);
            this.logTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage voorraadTab;
        private System.Windows.Forms.TabPage balansTab;
        private System.Windows.Forms.TabPage logTab;
        private System.Windows.Forms.TextBox logBox;
        private BalansView balansView1;
        private VoorraadView voorraadView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage resTab;
        private ReportView finalView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox periodSelectionBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioLog;
        private System.Windows.Forms.RadioButton radioTransactions;
        private System.Windows.Forms.Label label1;
    }
}
