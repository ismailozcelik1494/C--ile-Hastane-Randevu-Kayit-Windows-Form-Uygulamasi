namespace deneme1
{
    partial class DoktorKayitDuzenle
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
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_Tarih = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.check_Gorevdurum = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBrans = new System.Windows.Forms.ComboBox();
            this.cbUnvan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Yellow;
            this.btn_iptal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_iptal.Location = new System.Drawing.Point(222, 228);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 48;
            this.btn_iptal.Text = "İPTAL";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.Btn_iptal_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kaydet.Location = new System.Drawing.Point(141, 228);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 47;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.Btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sil.Location = new System.Drawing.Point(12, 228);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 46;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "TC NO:";
            // 
            // txtTcNo
            // 
            this.txtTcNo.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtTcNo.Location = new System.Drawing.Point(114, 21);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(183, 20);
            this.txtTcNo.TabIndex = 34;
            // 
            // txtAd
            // 
            this.txtAd.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtAd.Location = new System.Drawing.Point(114, 47);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(183, 20);
            this.txtAd.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "BRANŞ:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtSoyad.Location = new System.Drawing.Point(114, 73);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(183, 20);
            this.txtSoyad.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "AD:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "SOYAD:";
            // 
            // dtp_Tarih
            // 
            this.dtp_Tarih.CalendarMonthBackground = System.Drawing.Color.MediumTurquoise;
            this.dtp_Tarih.Location = new System.Drawing.Point(114, 99);
            this.dtp_Tarih.Name = "dtp_Tarih";
            this.dtp_Tarih.Size = new System.Drawing.Size(183, 20);
            this.dtp_Tarih.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "TARİH:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "GÖREV DURUM:";
            // 
            // check_Gorevdurum
            // 
            this.check_Gorevdurum.AutoSize = true;
            this.check_Gorevdurum.Location = new System.Drawing.Point(114, 178);
            this.check_Gorevdurum.Name = "check_Gorevdurum";
            this.check_Gorevdurum.Size = new System.Drawing.Size(60, 17);
            this.check_Gorevdurum.TabIndex = 49;
            this.check_Gorevdurum.Text = "Devam";
            this.check_Gorevdurum.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "ÜNVAN:";
            // 
            // cbBrans
            // 
            this.cbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBrans.FormattingEnabled = true;
            this.cbBrans.Location = new System.Drawing.Point(115, 126);
            this.cbBrans.Name = "cbBrans";
            this.cbBrans.Size = new System.Drawing.Size(182, 21);
            this.cbBrans.TabIndex = 52;
            // 
            // cbUnvan
            // 
            this.cbUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnvan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbUnvan.FormattingEnabled = true;
            this.cbUnvan.Location = new System.Drawing.Point(115, 155);
            this.cbUnvan.Name = "cbUnvan";
            this.cbUnvan.Size = new System.Drawing.Size(182, 21);
            this.cbUnvan.TabIndex = 53;
            // 
            // DoktorKayitDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(310, 263);
            this.Controls.Add(this.cbUnvan);
            this.Controls.Add(this.cbBrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_Gorevdurum);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtp_Tarih);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Name = "DoktorKayitDuzenle";
            this.Text = "DoktorKayitDuzenle";
            this.Load += new System.EventHandler(this.DoktorKayitDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_Tarih;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox check_Gorevdurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBrans;
        private System.Windows.Forms.ComboBox cbUnvan;
    }
}