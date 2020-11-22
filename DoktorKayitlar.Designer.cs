namespace deneme1
{
    partial class DoktorKayitlar
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
            this.grp_1 = new System.Windows.Forms.GroupBox();
            this.dtp_Tarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_Kategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ara = new System.Windows.Forms.TextBox();
            this.dgv_Kayit_Listele = new System.Windows.Forms.DataGridView();
            this.btn_Bul = new System.Windows.Forms.Button();
            this.grp_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kayit_Listele)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_1
            // 
            this.grp_1.BackColor = System.Drawing.Color.DarkOrange;
            this.grp_1.Controls.Add(this.dtp_Tarih);
            this.grp_1.Controls.Add(this.label3);
            this.grp_1.Controls.Add(this.combo_Kategori);
            this.grp_1.Controls.Add(this.label2);
            this.grp_1.Controls.Add(this.txt_Ara);
            this.grp_1.Controls.Add(this.dgv_Kayit_Listele);
            this.grp_1.Controls.Add(this.btn_Bul);
            this.grp_1.Location = new System.Drawing.Point(0, 0);
            this.grp_1.Name = "grp_1";
            this.grp_1.Size = new System.Drawing.Size(800, 328);
            this.grp_1.TabIndex = 25;
            this.grp_1.TabStop = false;
            this.grp_1.Text = "KAYIT LİSTELEME İŞLEMLERİ";
            // 
            // dtp_Tarih
            // 
            this.dtp_Tarih.Location = new System.Drawing.Point(7, 35);
            this.dtp_Tarih.Name = "dtp_Tarih";
            this.dtp_Tarih.Size = new System.Drawing.Size(208, 20);
            this.dtp_Tarih.TabIndex = 32;
            this.dtp_Tarih.Value = new System.DateTime(2019, 5, 10, 0, 25, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Kategoriler";
            // 
            // combo_Kategori
            // 
            this.combo_Kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Kategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_Kategori.FormattingEnabled = true;
            this.combo_Kategori.Items.AddRange(new object[] {
            "TCNO ile Ara",
            "Ad ile Ara",
            "Soyad ile Ara",
            "Tarih ve Saat ile Ara"});
            this.combo_Kategori.Location = new System.Drawing.Point(362, 35);
            this.combo_Kategori.Name = "combo_Kategori";
            this.combo_Kategori.Size = new System.Drawing.Size(195, 21);
            this.combo_Kategori.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Aranacak Veri";
            // 
            // txt_Ara
            // 
            this.txt_Ara.Location = new System.Drawing.Point(221, 36);
            this.txt_Ara.Name = "txt_Ara";
            this.txt_Ara.Size = new System.Drawing.Size(134, 20);
            this.txt_Ara.TabIndex = 26;
            // 
            // dgv_Kayit_Listele
            // 
            this.dgv_Kayit_Listele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Kayit_Listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kayit_Listele.EnableHeadersVisualStyles = false;
            this.dgv_Kayit_Listele.Location = new System.Drawing.Point(6, 62);
            this.dgv_Kayit_Listele.Name = "dgv_Kayit_Listele";
            this.dgv_Kayit_Listele.Size = new System.Drawing.Size(788, 261);
            this.dgv_Kayit_Listele.TabIndex = 25;
            this.dgv_Kayit_Listele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Kayit_Listele_CellClick);
            // 
            // btn_Bul
            // 
            this.btn_Bul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Bul.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Bul.FlatAppearance.BorderSize = 3;
            this.btn_Bul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Bul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Bul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Bul.ForeColor = System.Drawing.Color.White;
            this.btn_Bul.Location = new System.Drawing.Point(569, 33);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(100, 23);
            this.btn_Bul.TabIndex = 15;
            this.btn_Bul.Text = "BUL";
            this.btn_Bul.UseVisualStyleBackColor = false;
            this.btn_Bul.Click += new System.EventHandler(this.Btn_Bul_Click);
            // 
            // DoktorKayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(797, 327);
            this.Controls.Add(this.grp_1);
            this.Name = "DoktorKayitlar";
            this.Text = "DoktorKayitlar";
            this.Load += new System.EventHandler(this.DoktorKayitlar_Load);
            this.grp_1.ResumeLayout(false);
            this.grp_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kayit_Listele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_1;
        private System.Windows.Forms.DateTimePicker dtp_Tarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_Kategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ara;
        private System.Windows.Forms.DataGridView dgv_Kayit_Listele;
        private System.Windows.Forms.Button btn_Bul;
    }
}