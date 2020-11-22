using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Threading;

namespace deneme1
{
    public partial class KlinikKayitlar : Form
    {
        public KlinikKayitlar()
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
            dgv_Kayit_Listele.DataSource = klinikler = new XPCollection<Klinik>(CriteriaOperator.And(filtreler));
        }
        XPCollection<Klinik> klinikler;

        private void KlinikKayitlar_Load(object sender, EventArgs e)
        {
            txt_Ara.MaxLength = 255;
            btn_Bul.PerformClick();
        }

        Klinik duzenlenenKlinik;

        private void Dgv_Kayit_Listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (klinikler == null)
            {
                duzenlenenKlinik = (Klinik)dgv_Kayit_Listele.CurrentRow.DataBoundItem;
                var duzenlemeFormu = new KlinikKayitDuzenle(null);
                if (duzenlemeFormu.ShowDialog() == DialogResult.OK)
                {
                    klinikler.Reload();
                }
                return;
            }
            else
            {
                duzenlenenKlinik = (Klinik)dgv_Kayit_Listele.CurrentRow.DataBoundItem;
                var duzenlemeFormu = new KlinikKayitDuzenle(duzenlenenKlinik);
                if (duzenlemeFormu.ShowDialog() == DialogResult.OK)
                {
                    klinikler.Reload();
                }
                return;
            }
        }
    }
}
