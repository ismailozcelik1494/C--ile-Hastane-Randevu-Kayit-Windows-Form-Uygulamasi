using System;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace deneme1
{
    public partial class KlinikKayitDuzenle : Form
    {
        public KlinikKayitDuzenle(object p)
        {
            InitializeComponent();
        }
        public KlinikKayitDuzenle(Klinik klinik)
        {
            InitializeComponent();
            DuzenlenenKlinik = klinik;

            if (klinik == null)
            {
                btn_sil.Visible = false;
            }
            else
            {
                klinik.Reload();
                txtKlinikNo.Text = Convert.ToString(DuzenlenenKlinik.KlinikNo);
                txtKlinikAd.Text = DuzenlenenKlinik.KlinikAd;
                cbİlgiliDoktor.Text = DuzenlenenKlinik.İlgiliDoktor;
                cbSorumluPersonel.Text = DuzenlenenKlinik.SorumluPersonel;
                txtBlok.Text = DuzenlenenKlinik.Blok;
                nupKat.Value = Convert.ToDecimal(DuzenlenenKlinik.Kat);
                cbHizmetDurum.Checked = DuzenlenenKlinik.HizmetDurum;
            }
        }
        Klinik DuzenlenenKlinik;
        private void KlinikKayitDuzenle_Load(object sender, EventArgs e)
        {
            cbİlgiliDoktor.DataSource = new XPCollection<Doktor>();
            cbİlgiliDoktor.DisplayMember = "AdSoyad";
            cbKlinikAdListele.DataSource = new XPCollection<Klinik>();
            cbKlinikAdListele.DisplayMember = "KlinikAd";
        }

        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var hataKontrol = new HataKontrol();
                hataKontrol.TextBosKontrol(txtKlinikNo, "KlinikNo");
                hataKontrol.TextBosKontrol(txtKlinikAd, "KlinikAd");
                hataKontrol.TCKimlikKontrol(txtKlinikNo, "KlinikNo");
                if (hataKontrol.HataVarmi()) return;

                if (DuzenlenenKlinik == null)
                {
                    DuzenlenenKlinik = new Klinik();
                }

                DuzenlenenKlinik.KlinikNo = txtKlinikNo.Text.Trim();
                DuzenlenenKlinik.KlinikAd = txtKlinikAd.Text.Trim();
                DuzenlenenKlinik.İlgiliDoktor = Convert.ToString(cbİlgiliDoktor.SelectedItem);
                DuzenlenenKlinik.SorumluPersonel = Convert.ToString(cbSorumluPersonel.SelectedItem);
                DuzenlenenKlinik.Blok = txtBlok.Text.Trim();
                DuzenlenenKlinik.Kat = Convert.ToString(nupKat.Value);
                DuzenlenenKlinik.HizmetDurum = cbHizmetDurum.Checked;
                DuzenlenenKlinik.Save();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            DuzenlenenKlinik.Delete();
        }

        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKlinikAta_Click(object sender, EventArgs e)
        {
            txtKlinikAd.Text = cbKlinikAdListele.SelectedValue.ToString();
        }
    }
}
