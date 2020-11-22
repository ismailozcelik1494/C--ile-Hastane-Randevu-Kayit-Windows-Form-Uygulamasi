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
    public partial class TanimlarKayitDuzenle : Form
    {
        Tanimlar duzenlenenTanimlar;
        public TanimlarKayitDuzenle(Tanimlar tanimlar)
        {
            InitializeComponent();
            duzenlenenTanimlar = tanimlar;

            if (tanimlar == null)
            {
                btn_sil.Visible = false;
            }
            else
            {
                tanimlar.Reload();
                txtBransKod.Text = duzenlenenTanimlar.BransKod;
                txtBransAd.Text = duzenlenenTanimlar.BransAd;
                txtUnvanKod.Text = duzenlenenTanimlar.UnvanKod;
                txtUnvanAd.Text = duzenlenenTanimlar.UnvanAd;
            }
        }

        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var hatakontrol = new HataKontrol();
                hatakontrol.TextBosKontrol(txtBransKod, "BransKod");
                hatakontrol.TextBosKontrol(txtUnvanKod, "UnvanKod");
                if (hatakontrol.HataVarmi()) return;

                if (duzenlenenTanimlar == null)
                {
                    duzenlenenTanimlar = new Tanimlar();
                }

                duzenlenenTanimlar.BransKod = txtBransKod.Text;
                duzenlenenTanimlar.BransAd = txtBransAd.Text;
                duzenlenenTanimlar.UnvanKod = txtUnvanKod.Text;
                duzenlenenTanimlar.UnvanAd = txtUnvanAd.Text;
                duzenlenenTanimlar.Save();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            duzenlenenTanimlar.Delete();
        }

        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
