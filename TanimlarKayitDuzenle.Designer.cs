namespace deneme1
{
    partial class TanimlarKayitDuzenle
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
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBransKod = new System.Windows.Forms.TextBox();
            this.txtBransAd = new System.Windows.Forms.TextBox();
            this.txtUnvanKod = new System.Windows.Forms.TextBox();
            this.txtUnvanAd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Yellow;
            this.btn_iptal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_iptal.Location = new System.Drawing.Point(482, 101);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 65;
            this.btn_iptal.Text = "İPTAL";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.Btn_iptal_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kaydet.Location = new System.Drawing.Point(401, 101);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 64;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.Btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sil.Location = new System.Drawing.Point(16, 102);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 63;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "BRANŞ KODU:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "BRANŞ ADI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "ÜNVAN KODU:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "ÜNVAN ADI:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBransKod);
            this.groupBox1.Controls.Add(this.txtBransAd);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 83);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BRANŞ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUnvanAd);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtUnvanKod);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(289, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 83);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜNVAN";
            // 
            // txtBransKod
            // 
            this.txtBransKod.Location = new System.Drawing.Point(118, 18);
            this.txtBransKod.Name = "txtBransKod";
            this.txtBransKod.Size = new System.Drawing.Size(133, 20);
            this.txtBransKod.TabIndex = 67;
            // 
            // txtBransAd
            // 
            this.txtBransAd.Location = new System.Drawing.Point(118, 44);
            this.txtBransAd.Name = "txtBransAd";
            this.txtBransAd.Size = new System.Drawing.Size(133, 20);
            this.txtBransAd.TabIndex = 68;
            // 
            // txtUnvanKod
            // 
            this.txtUnvanKod.Location = new System.Drawing.Point(119, 18);
            this.txtUnvanKod.Name = "txtUnvanKod";
            this.txtUnvanKod.Size = new System.Drawing.Size(133, 20);
            this.txtUnvanKod.TabIndex = 69;
            // 
            // txtUnvanAd
            // 
            this.txtUnvanAd.Location = new System.Drawing.Point(119, 44);
            this.txtUnvanAd.Name = "txtUnvanAd";
            this.txtUnvanAd.Size = new System.Drawing.Size(133, 20);
            this.txtUnvanAd.TabIndex = 70;
            // 
            // TanimlarKayitDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 137);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_sil);
            this.Name = "TanimlarKayitDuzenle";
            this.Text = "TanimlarKayitDuzenle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBransKod;
        private System.Windows.Forms.TextBox txtBransAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUnvanAd;
        private System.Windows.Forms.TextBox txtUnvanKod;
    }
}