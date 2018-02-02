namespace sinemaTekSecim
{
    partial class SatinAlma
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
            this.lblUcret = new System.Windows.Forms.Label();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.cmbIndirim = new System.Windows.Forms.ComboBox();
            this.chbGözlük = new System.Windows.Forms.CheckBox();
            this.chbMenü = new System.Windows.Forms.CheckBox();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUcret.Location = new System.Drawing.Point(274, 205);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(10, 13);
            this.lblUcret.TabIndex = 13;
            this.lblUcret.Text = "-";
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(23, 138);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(75, 23);
            this.btnSatinAl.TabIndex = 11;
            this.btnSatinAl.Text = "Satin Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // cmbIndirim
            // 
            this.cmbIndirim.FormattingEnabled = true;
            this.cmbIndirim.Location = new System.Drawing.Point(23, 50);
            this.cmbIndirim.Name = "cmbIndirim";
            this.cmbIndirim.Size = new System.Drawing.Size(100, 21);
            this.cmbIndirim.TabIndex = 10;
            // 
            // chbGözlük
            // 
            this.chbGözlük.AutoSize = true;
            this.chbGözlük.Location = new System.Drawing.Point(23, 105);
            this.chbGözlük.Name = "chbGözlük";
            this.chbGözlük.Size = new System.Drawing.Size(70, 17);
            this.chbGözlük.TabIndex = 9;
            this.chbGözlük.Text = "GÖZLÜK";
            this.chbGözlük.UseVisualStyleBackColor = true;
            // 
            // chbMenü
            // 
            this.chbMenü.AutoSize = true;
            this.chbMenü.Location = new System.Drawing.Point(23, 81);
            this.chbMenü.Name = "chbMenü";
            this.chbMenü.Size = new System.Drawing.Size(58, 17);
            this.chbMenü.TabIndex = 8;
            this.chbMenü.Text = "MENÜ";
            this.chbMenü.UseVisualStyleBackColor = true;
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Location = new System.Drawing.Point(23, 11);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(100, 20);
            this.txtKoltukNo.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(150, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 121);
            this.listBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(147, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "SinemaToplamUcret:";
            // 
            // SatinAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.cmbIndirim);
            this.Controls.Add(this.chbGözlük);
            this.Controls.Add(this.chbMenü);
            this.Controls.Add(this.txtKoltukNo);
            this.Name = "SatinAlma";
            this.Text = "SatinAlma";
            this.Load += new System.EventHandler(this.SatinAlma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.ComboBox cmbIndirim;
        private System.Windows.Forms.CheckBox chbGözlük;
        private System.Windows.Forms.CheckBox chbMenü;
        private System.Windows.Forms.TextBox txtKoltukNo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}