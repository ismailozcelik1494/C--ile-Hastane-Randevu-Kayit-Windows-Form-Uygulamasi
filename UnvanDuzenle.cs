using System;
using System.Windows.Forms;

namespace deneme1
{
    public partial class UnvanDuzenle : Form
    {
        Unvan duzenleneUnvan;
        public UnvanDuzenle(Unvan unvan)
        {
            InitializeComponent();
            duzenleneUnvan = unvan;

            if (unvan == null)
            {
                btn_sil.Visible = false;
            }
            else
            {
                unvan.Reload();
                txtUnvanKod.Text = duzenleneUnvan.Kod;
                txtUnvanAd.Text = duzenleneUnvan.Ad;
                cbHizmetDurum.Checked = duzenleneUnvan.HizmetDurum;
            }
        }

        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var hataKontrol = new HataKontrol();
                hataKontrol.TextBosKontrol(txtUnvanKod, "UnvanKod");
                if (hataKontrol.HataVarmi()) return;

                if (duzenleneUnvan == null)
                {
                    duzenleneUnvan = new Unvan();
                }

                duzenleneUnvan.Kod = txtUnvanKod.Text.Trim();
                duzenleneUnvan.Ad = txtUnvanAd.Text.Trim();
                duzenleneUnvan.HizmetDurum = Convert.ToBoolean(cbHizmetDurum.Checked);
                duzenleneUnvan.Save();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            duzenleneUnvan.Delete();
        }

        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
