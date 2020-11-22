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
    public partial class HastaKayitlar : Form
    {
        public HastaKayitlar()
        {
            InitializeComponent();
        }

        XPCollection<Hasta> hastalar;

        private void FormKayitlar_Load(object sender, EventArgs e)
        {
            txt_Ara.MaxLength = 255;
            btn_Bul.PerformClick();
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
            dgv_Kayit_Listele.DataSource = hastalar = new XPCollection<Hasta>(CriteriaOperator.And(filtreler));
        }

        Hasta duzenlenenHasta;

        private void Dgv_Kayit_Listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (hastalar == null)
            {
                duzenlenenHasta = (Hasta)dgv_Kayit_Listele.CurrentRow.DataBoundItem;
                var duzenlemeFormu = new HastaDuzenle(null);
                if (duzenlemeFormu.ShowDialog() == DialogResult.OK)
                {
                    hastalar.Reload();
                }
                return;
            }
            else
            {
                duzenlenenHasta = (Hasta)dgv_Kayit_Listele.CurrentRow.DataBoundItem;
                var duzenlemeFormu = new HastaDuzenle(duzenlenenHasta);
                if (duzenlemeFormu.ShowDialog() == DialogResult.OK)
                {
                    hastalar.Reload();
                }
                return;
            }
            
        }

    }
}
