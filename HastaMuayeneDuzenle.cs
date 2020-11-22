using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme1
{
    public partial class HastaMuayeneDuzenle : Form
    {
        Muayene duzenlenenMuayeneler;
        public HastaMuayeneDuzenle(Muayene muayene)
        {
            InitializeComponent();
            duzenlenenMuayeneler = muayene;

            if(muayene == null)
            {
                btn_sil.Visible = false;
            }
            else
            {
                muayene.Reload();
                txtTcNo.Text = duzenlenenMuayeneler.TCNO;
                txtAd.Text = duzenlenenMuayeneler.Ad;
                txtSoyad.Text = duzenlenenMuayeneler.Soyad;
                dtp_Tarih.Value = duzenlenenMuayeneler.RandevuTarih;
                cbBolum.Text = duzenlenenMuayeneler.Bolum;
                cbDoktor.Text = Convert.ToString(duzenlenenMuayeneler.Doktoru);
                txtTeshis.Text = duzenlenenMuayeneler.Teshis;
            }
        }

        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var hatakontrol = new HataKontrol();
                hatakontrol.TCKimlikKontrol(txtTcNo, "TCNO");
                hatakontrol.TextBosKontrol(txtAd, "Ad");
                hatakontrol.TextBosKontrol(txtSoyad, "Soyad");
                hatakontrol.TextBosKontrol(txtTeshis, "Teshis");
                if (hatakontrol.HataVarmi()) return;

                if(duzenlenenMuayeneler == null)
                {
                    duzenlenenMuayeneler = new Muayene();
                }
                duzenlenenMuayeneler.TCNO = txtTcNo.Text.Trim();
                duzenlenenMuayeneler.Ad = txtAd.Text.Trim();
                duzenlenenMuayeneler.Soyad = txtSoyad.Text.Trim();
                duzenlenenMuayeneler.RandevuTarih = dtp_Tarih.Value.Date;
                duzenlenenMuayeneler.Bolum = cbBolum.Text.Trim();
                //duzenlenenMuayeneler.Doktoru = Convert.ToString(cbDoktor.Text);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
