using System;
using System.Windows.Forms;

namespace deneme1
{
    public partial class HastaDuzenle : Form
    {
        Hasta duzenlenenHasta;
        public HastaDuzenle(Hasta hasta)
        {
            InitializeComponent();
            duzenlenenHasta = hasta;

            if (hasta == null)
            {
                btn_sil.Visible = false;
            }
            else
            {
                hasta.Reload();
                txtTcNo.Text = duzenlenenHasta.TCNO;
                txtAd.Text = duzenlenenHasta.Ad;
                txtSoyad.Text = duzenlenenHasta.Soyad;
                txtAnneAd.Text = duzenlenenHasta.AnneAd;
                txtBabaAd.Text = duzenlenenHasta.BabaAd;
                dtpDogumTarihi.Value = Convert.ToDateTime(duzenlenenHasta.DogumTarih);
                txtYas.Text = Convert.ToString(duzenlenenHasta.Yas);
                txtTelEv.Text = duzenlenenHasta.TelEv;
                txtTelCep.Text = duzenlenenHasta.TelCep;
                txtAdres.Text = duzenlenenHasta.Adres;
                rbErkek.Text = duzenlenenHasta.Cinsiyet;
                rbKadin.Text = duzenlenenHasta.Cinsiyet;
                rbCocuk.Text = duzenlenenHasta.Cinsiyet;
                txtKanGrup.Text = duzenlenenHasta.KanGrub;
                rbCalismaEvet.Checked = duzenlenenHasta.CalismaDurum;
                rbCalismaHayir.Checked = duzenlenenHasta.CalismaDurum;
                txtMeslek.Text = duzenlenenHasta.Meslek;
                rbSigortaEvet.Checked = duzenlenenHasta.SigortaVarYok;
                rbSigortaHayir.Checked = duzenlenenHasta.SigortaVarYok;
                cbSigortaDurum.Text = duzenlenenHasta.SigortaDurum;
                dtpSigortaBTarih.Value = Convert.ToDateTime(duzenlenenHasta.SigortaBaslamaTarih);
                txtCalistigiGunSayisi.Text = duzenlenenHasta.CalistigiGun;
                cbDoktor.Text = Convert.ToString(duzenlenenHasta.Doktor);
            }
        }

        private void FormDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                var hataKontrol = new HataKontrol();
                hataKontrol.TextBosKontrol(txtAd, "Ad");
                hataKontrol.TextBosKontrol(txtSoyad, "Soyad");
                hataKontrol.TCKimlikKontrol(txtTcNo, "TCNO");
                if (hataKontrol.HataVarmi()) return;

                if (duzenlenenHasta == null)
                {
                    duzenlenenHasta = new Hasta();
                }

                duzenlenenHasta.TCNO = txtTcNo.Text.Trim();
                duzenlenenHasta.Ad = txtAd.Text.Trim();
                duzenlenenHasta.Soyad = txtSoyad.Text.Trim();
                duzenlenenHasta.AnneAd = txtAnneAd.Text.Trim();
                duzenlenenHasta.BabaAd = txtBabaAd.Text.Trim();
                duzenlenenHasta.DogumTarih = Convert.ToDateTime(dtpDogumTarihi.Value.Date);
                duzenlenenHasta.Yas = byte.Parse(txtYas.Text);
                duzenlenenHasta.TelEv = txtTelEv.Text.Trim();
                duzenlenenHasta.TelCep = txtTelCep.Text.Trim();
                duzenlenenHasta.Adres = txtAdres.Text.Trim();
                duzenlenenHasta.Cinsiyet = rbErkek.Text.Trim();
                duzenlenenHasta.Cinsiyet = rbKadin.Text.Trim();
                duzenlenenHasta.Cinsiyet = rbCocuk.Text.Trim();
                duzenlenenHasta.KanGrub = txtKanGrup.Text.Trim();
                duzenlenenHasta.CalismaDurum = Convert.ToBoolean(rbCalismaEvet.Checked);
                duzenlenenHasta.CalismaDurum = Convert.ToBoolean(rbCalismaHayir.Checked);
                duzenlenenHasta.Meslek = txtMeslek.Text.Trim();
                duzenlenenHasta.SigortaVarYok = Convert.ToBoolean(rbSigortaEvet.Checked);
                duzenlenenHasta.SigortaVarYok = Convert.ToBoolean(rbSigortaHayir.Checked);
                duzenlenenHasta.SigortaDurum = cbSigortaDurum.Text.Trim();
                duzenlenenHasta.SigortaBaslamaTarih = Convert.ToDateTime(dtpSigortaBTarih.Value.Date);
                duzenlenenHasta.CalistigiGun = txtCalistigiGunSayisi.Text.Trim();
                duzenlenenHasta.Doktor = (Doktor)cbDoktor.Text.Trim();
                duzenlenenHasta.Save();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }   
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            duzenlenenHasta.Delete();
        }

        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}