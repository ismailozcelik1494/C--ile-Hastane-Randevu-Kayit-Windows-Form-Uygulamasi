using System;
using System.Windows.Forms;
using DevExpress.Xpo;
namespace deneme1
{
    public partial class DoktorKayitDuzenle : Form
    {
        public DoktorKayitDuzenle()
        {
        }

        private void DoktorKayitDuzenle_Load(object sender, EventArgs e)
        {
            cbUnvan.DataSource = new XPCollection<Unvan>();
            cbBrans.DataSource = new XPCollection<Brans>();
            cbBrans.DisplayMember = "Ad";
            cbUnvan.DisplayMember = "AdKod";
        }

        Doktor DuzenlenenDoktor;
        public DoktorKayitDuzenle(Doktor doktor)
        {
            InitializeComponent();
            DuzenlenenDoktor = doktor;

            if (doktor == null)
            {
                btn_sil.Visible = false;
                dtp_Tarih.Value = DateTime.Now;
            }
            else
            {
                doktor.Reload();
                txtTcNo.Text = DuzenlenenDoktor.TCNO;
                txtAd.Text = DuzenlenenDoktor.Ad;
                txtSoyad.Text = DuzenlenenDoktor.Soyad;
                dtp_Tarih.Value = DuzenlenenDoktor.GorevTarih;
                cbBrans.SelectedItem = DuzenlenenDoktor.Brans;
                cbUnvan.SelectedItem = DuzenlenenDoktor.Unvan;
                check_Gorevdurum.Checked = DuzenlenenDoktor.GorevDurum;
            }
        }

        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var hataKontrol = new HataKontrol();
                hataKontrol.TextBosKontrol(txtAd, "Ad");
                hataKontrol.TextBosKontrol(txtSoyad, "Soyad");
                hataKontrol.TCKimlikKontrol(txtTcNo, "TCNO");
                hataKontrol.TextBosKontrol(txtTcNo, "TCNO");
                if (hataKontrol.HataVarmi()) return;

                if (DuzenlenenDoktor == null)
                {
                    DuzenlenenDoktor = new Doktor();
                }

                DuzenlenenDoktor.TCNO = txtTcNo.Text.Trim();
                DuzenlenenDoktor.Ad = txtAd.Text.Trim();
                DuzenlenenDoktor.Soyad = txtSoyad.Text.Trim();
                DuzenlenenDoktor.GorevTarih = dtp_Tarih.Value.Date;
                DuzenlenenDoktor.Brans = (Brans)cbBrans.SelectedItem;
                DuzenlenenDoktor.Unvan = (Unvan)cbUnvan.SelectedItem;
                DuzenlenenDoktor.GorevDurum = check_Gorevdurum.Checked;
                DuzenlenenDoktor.Save();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            DuzenlenenDoktor.Delete();
        }

        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
