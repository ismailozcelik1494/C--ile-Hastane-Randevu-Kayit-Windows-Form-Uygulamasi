namespace deneme1
{
    partial class BransDuzenle
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
            this.cbHizmetDurum = new System.Windows.Forms.CheckBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBransKod = new System.Windows.Forms.TextBox();
            this.txtBransAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbHizmetDurum
            // 
            this.cbHizmetDurum.AutoSize = true;
            this.cbHizmetDurum.Location = new System.Drawing.Point(116, 67);
            this.cbHizmetDurum.Name = "cbHizmetDurum";
            this.cbHizmetDurum.Size = new System.Drawing.Size(71, 17);
            this.cbHizmetDurum.TabIndex = 58;
            this.cbHizmetDurum.Text = "Faaliyette";
            this.cbHizmetDurum.UseVisualStyleBackColor = true;
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Yellow;
            this.btn_iptal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_iptal.Location = new System.Drawing.Point(224, 117);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 57;
            this.btn_iptal.Text = "İPTAL";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.Btn_iptal_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kaydet.Location = new System.Drawing.Point(143, 117);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 56;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.Btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sil.Location = new System.Drawing.Point(14, 117);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 55;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "KOD:";
            // 
            // txtBransKod
            // 
            this.txtBransKod.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtBransKod.Location = new System.Drawing.Point(116, 14);
            this.txtBransKod.Name = "txtBransKod";
            this.txtBransKod.Size = new System.Drawing.Size(183, 20);
            this.txtBransKod.TabIndex = 50;
            // 
            // txtBransAd
            // 
            this.txtBransAd.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtBransAd.Location = new System.Drawing.Point(116, 40);
            this.txtBransAd.Name = "txtBransAd";
            this.txtBransAd.Size = new System.Drawing.Size(183, 20);
            this.txtBransAd.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "AD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "HİZMET DURUM:";
            // 
            // BransDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 162);
            this.Controls.Add(this.cbHizmetDurum);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBransKod);
            this.Controls.Add(this.txtBransAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Name = "BransDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BransDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHizmetDurum;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBransKod;
        private System.Windows.Forms.TextBox txtBransAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}