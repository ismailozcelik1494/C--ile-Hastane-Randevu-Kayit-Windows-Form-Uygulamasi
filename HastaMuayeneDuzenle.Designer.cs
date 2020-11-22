namespace deneme1
{
    partial class HastaMuayeneDuzenle
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
            this.cbDoktor = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTeshis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_Tarih = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbBolum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDoktor
            // 
            this.cbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoktor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDoktor.FormattingEnabled = true;
            this.cbDoktor.Items.AddRange(new object[] {
            "SSK",
            "BAĞ-KUR",
            "EMEKLİ SANDIĞI",
            "ÖĞRENCİ",
            "TSK-MENSUBU"});
            this.cbDoktor.Location = new System.Drawing.Point(120, 144);
            this.cbDoktor.Name = "cbDoktor";
            this.cbDoktor.Size = new System.Drawing.Size(174, 21);
            this.cbDoktor.TabIndex = 92;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(58, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 90;
            this.label17.Text = "DOKTOR:";
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Yellow;
            this.btn_iptal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_iptal.Location = new System.Drawing.Point(219, 260);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 72;
            this.btn_iptal.Text = "İPTAL";
            this.btn_iptal.UseVisualStyleBackColor = false;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kaydet.Location = new System.Drawing.Point(138, 260);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 71;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.Btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sil.Location = new System.Drawing.Point(11, 260);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 70;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "TC NO:";
            // 
            // txtTcNo
            // 
            this.txtTcNo.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtTcNo.Location = new System.Drawing.Point(120, 11);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(174, 20);
            this.txtTcNo.TabIndex = 58;
            // 
            // txtAd
            // 
            this.txtAd.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtAd.Location = new System.Drawing.Point(120, 37);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(174, 20);
            this.txtAd.TabIndex = 59;
            // 
            // txtSoyad
            // 
            this.txtSoyad.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtSoyad.Location = new System.Drawing.Point(120, 63);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(174, 20);
            this.txtSoyad.TabIndex = 60;
            // 
            // txtTeshis
            // 
            this.txtTeshis.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtTeshis.Location = new System.Drawing.Point(120, 173);
            this.txtTeshis.Multiline = true;
            this.txtTeshis.Name = "txtTeshis";
            this.txtTeshis.Size = new System.Drawing.Size(174, 81);
            this.txtTeshis.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "AD:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "SOYAD:";
            // 
            // dtp_Tarih
            // 
            this.dtp_Tarih.CalendarMonthBackground = System.Drawing.Color.MediumTurquoise;
            this.dtp_Tarih.Location = new System.Drawing.Point(120, 90);
            this.dtp_Tarih.Name = "dtp_Tarih";
            this.dtp_Tarih.Size = new System.Drawing.Size(174, 20);
            this.dtp_Tarih.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "RANDEVU TARİHİ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "TEŞHİS:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(310, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 94;
            this.button1.Text = "HASTA BUL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbBolum
            // 
            this.cbBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBolum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBolum.FormattingEnabled = true;
            this.cbBolum.Items.AddRange(new object[] {
            "SSK",
            "BAĞ-KUR",
            "EMEKLİ SANDIĞI",
            "ÖĞRENCİ",
            "TSK-MENSUBU"});
            this.cbBolum.Location = new System.Drawing.Point(120, 118);
            this.cbBolum.Name = "cbBolum";
            this.cbBolum.Size = new System.Drawing.Size(174, 21);
            this.cbBolum.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "BÖLÜM:";
            // 
            // HastaMuayeneDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(403, 293);
            this.Controls.Add(this.cbBolum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDoktor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtTeshis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtp_Tarih);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Name = "HastaMuayeneDuzenle";
            this.Text = "HastaMuayene";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDoktor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTeshis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_Tarih;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbBolum;
        private System.Windows.Forms.Label label1;
    }
}