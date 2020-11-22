using System;
using System.Windows.Forms;

namespace deneme1
{
    public partial class BransDuzenle : Form
    {
        Brans duzenlenenBrans;
        public BransDuzenle(Brans brans)
        {
            InitializeComponent();
            duzenlenenBrans = brans;

            if (brans == null)
            {
                btn_sil.Visible = false;
            }
            else
            {
                brans.Reload();
                txtBransKod.Text = duzenlenenBrans.Kod;
                txtBransAd.Text = duzenlenenBrans.Ad;
                cbHizmetDurum.Checked = duzenlenenBrans.HizmetDurum;
            }
        }

        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var hataKontrol = new HataKontrol();
                hataKontrol.TextBosKontrol(txtBransKod, "BransKod");
                if (hataKontrol.HataVarmi()) return;

                if (duzenlenenBrans == null)
                {
                    duzenlenenBrans = new Brans();
                }

                duzenlenenBrans.Kod = txtBransKod.Text.Trim();
                duzenlenenBrans.Ad = txtBransAd.Text.Trim();
                duzenlenenBrans.HizmetDurum = Convert.ToBoolean(cbHizmetDurum.Checked);
                duzenlenenBrans.Save();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            duzenlenenBrans.Delete();
        }

        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
