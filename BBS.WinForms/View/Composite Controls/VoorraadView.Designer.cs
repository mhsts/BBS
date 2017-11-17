namespace BBS
{
    partial class VoorraadView
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
            this.voorraadWaarschuwingenCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new BBS.View.DataLists.DataGridView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // voorraadWaarschuwingenCheckBox
            // 
            this.voorraadWaarschuwingenCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.voorraadWaarschuwingenCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.voorraadWaarschuwingenCheckBox.Location = new System.Drawing.Point(5, 56);
            this.voorraadWaarschuwingenCheckBox.Margin = new System.Windows.Forms.Padding(10);
            this.voorraadWaarschuwingenCheckBox.Name = "voorraadWaarschuwingenCheckBox";
            this.voorraadWaarschuwingenCheckBox.Size = new System.Drawing.Size(106, 39);
            this.voorraadWaarschuwingenCheckBox.TabIndex = 13;
            this.voorraadWaarschuwingenCheckBox.Text = "Voorraad waarschuwingen";
            this.voorraadWaarschuwingenCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.voorraadWaarschuwingenCheckBox.UseVisualStyleBackColor = true;
            this.voorraadWaarschuwingenCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Nieuw product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddNewProductClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.voorraadWaarschuwingenCheckBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(793, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(116, 400);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 13);
            this.panel2.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSize = true;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 400);
            this.dataGridView1.TabIndex = 14;
            // 
            // VoorraadView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "VoorraadView";
            this.Size = new System.Drawing.Size(909, 400);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox voorraadWaarschuwingenCheckBox;
        private BBS.View.DataLists.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

    }
}
