using System;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace deneme1
{
    public partial class DoktorKayitlar : Form
    {
        public DoktorKayitlar()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void Btn_Bul_Click(object sender, EventArgs e)
        {
            CriteriaOperatorCollection filtreler = new CriteriaOperatorCollection();

            if (combo_Kategori.SelectedIndex == 0)
            {
                filtreler.Esit("TCNO", txt_Ara);
            }
            else if (combo_Kategori.SelectedIndex == 1)
            {
                filtreler.Esit("Ad", txt_Ara);
            }
            else if (combo_Kategori.SelectedIndex == 2)
            {
                filtreler.Esit("Soyad", txt_Ara);
            }
            else if (combo_Kategori.SelectedIndex == 3)
            {
                //string Tarih = Convert.ToString(dtp_Tarih.Value.Date);
                filtreler.TarihAra("Tarih", dtp_Tarih);
            }
            else if (combo_Kategori.SelectedIndex == 4)
            {
                filtreler.BuyukOlanlarByte("Yas", txt_Ara);
            }
            else
            {
                //MessageBox.Show("Yapım Aşamasında...");
            }
            dgv_Kayit_Listele.DataSource = doktorlar = new XPCollection<Doktor>(CriteriaOperator.And(filtreler));
        }
        XPCollection<Doktor> doktorlar;
        private void DoktorKayitlar_Load(object sender, EventArgs e)
        {
            txt_Ara.MaxLength = 255;
            btn_Bul.PerformClick();
        }

        Doktor duzenlenenDoktor;

        private void Dgv_Kayit_Listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (doktorlar == null)
            {
                duzenlenenDoktor = (Doktor)dgv_Kayit_Listele.CurrentRow.DataBoundItem;
                var duzenlemeFormu = new DoktorKayitDuzenle(null);
                if (duzenlemeFormu.ShowDialog() == DialogResult.OK)
                {
                    doktorlar.Reload();
                }
                return;
            }
            else
            {
                duzenlenenDoktor = (Doktor)dgv_Kayit_Listele.CurrentRow.DataBoundItem;
                var duzenlemeFormu = new DoktorKayitDuzenle(duzenlenenDoktor);
                if (duzenlemeFormu.ShowDialog() == DialogResult.OK)
                {
                    doktorlar.Reload();
                }
                return;
            }
        }
    }
}
