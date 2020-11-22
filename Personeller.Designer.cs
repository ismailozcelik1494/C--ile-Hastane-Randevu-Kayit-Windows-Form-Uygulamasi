namespace deneme1
{
    partial class Personeller
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
            this.btnPersonelDuzenle = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
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
            this.grp_1.Controls.Add(this.btnPersonelDuzenle);
            this.grp_1.Controls.Add(this.btnPersonelEkle);
            this.grp_1.Controls.Add(this.label3);
            this.grp_1.Controls.Add(this.combo_Kategori);
            this.grp_1.Controls.Add(this.label2);
            this.grp_1.Controls.Add(this.txt_Ara);
            this.grp_1.Controls.Add(this.dgv_Kayit_Listele);
            this.grp_1.Controls.Add(this.btn_Bul);
            this.grp_1.Location = new System.Drawing.Point(12, 12);
            this.grp_1.Name = "grp_1";
            this.grp_1.Size = new System.Drawing.Size(461, 357);
            this.grp_1.TabIndex = 27;
            this.grp_1.TabStop = false;
            this.grp_1.Text = "KAYIT LİSTELEME İŞLEMLERİ";
            this.grp_1.Enter += new System.EventHandler(this.Grp_1_Enter);
            // 
            // btnPersonelDuzenle
            // 
            this.btnPersonelDuzenle.Location = new System.Drawing.Point(285, 19);
            this.btnPersonelDuzenle.Name = "btnPersonelDuzenle";
            this.btnPersonelDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnPersonelDuzenle.TabIndex = 32;
            this.btnPersonelDuzenle.Text = "Düzenle";
            this.btnPersonelDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(374, 19);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(75, 23);
            this.btnPersonelEkle.TabIndex = 27;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 39);
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
            this.combo_Kategori.Location = new System.Drawing.Point(148, 58);
            this.combo_Kategori.Name = "combo_Kategori";
            this.combo_Kategori.Size = new System.Drawing.Size(195, 21);
            this.combo_Kategori.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Aranacak Veri";
            // 
            // txt_Ara
            // 
            this.txt_Ara.Location = new System.Drawing.Point(7, 59);
            this.txt_Ara.Name = "txt_Ara";
            this.txt_Ara.Size = new System.Drawing.Size(134, 20);
            this.txt_Ara.TabIndex = 26;
            // 
            // dgv_Kayit_Listele
            // 
            this.dgv_Kayit_Listele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Kayit_Listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kayit_Listele.EnableHeadersVisualStyles = false;
            this.dgv_Kayit_Listele.Location = new System.Drawing.Point(6, 85);
            this.dgv_Kayit_Listele.Name = "dgv_Kayit_Listele";
            this.dgv_Kayit_Listele.Size = new System.Drawing.Size(443, 261);
            this.dgv_Kayit_Listele.TabIndex = 25;
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
            this.btn_Bul.Location = new System.Drawing.Point(349, 58);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(100, 23);
            this.btn_Bul.TabIndex = 15;
            this.btn_Bul.Text = "BUL";
            this.btn_Bul.UseVisualStyleBackColor = false;
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 381);
            this.Controls.Add(this.grp_1);
            this.Name = "Personeller";
            this.Text = "Personeller";
            this.grp_1.ResumeLayout(false);
            this.grp_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kayit_Listele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_1;
        private System.Windows.Forms.Button btnPersonelDuzenle;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_Kategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ara;
        private System.Windows.Forms.DataGridView dgv_Kayit_Listele;
        private System.Windows.Forms.Button btn_Bul;
    }
}