using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace deneme1
{
    public partial class TanimlarKayitlar : Form
    {
        public TanimlarKayitlar()
        {
            InitializeComponent();
        }

        private void TanimlarKayitlar_Load(object sender, EventArgs e)
        {
            btn_Bul.PerformClick();
        }

        private void Btn_Bul_Click(object sender, EventArgs e)
        {
            CriteriaOperatorCollection filtreler = new CriteriaOperatorCollection();

            if (combo_Kategori.SelectedIndex == 0)
            {
                filtreler.Esit("UnvanKod", txt_Ara);
            }
            else if (combo_Kategori.SelectedIndex == 1)
            {
                filtreler.Esit("UnvanAd", txt_Ara);
            }
            else if (combo_Kategori.SelectedIndex == 2)
            {
                filtreler.Esit("BransKod", txt_Ara);
            }
            else if (combo_Kategori.SelectedIndex == 3)
            {
                filtreler.Esit("BransAd", txt_Ara);
            }

            dgv_Kayit_Listele.DataSource = Tanimlar = new XPCollection<Tanimlar>(CriteriaOperator.And(filtreler));
        }

        XPCollection<Tanimlar> Tanimlar;

        Tanimlar duzenlenenTanimlar;
        private void Dgv_Kayit_Listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Tanimlar == null)
            {
                duzenlenenTanimlar = (Tanimlar)dgv_Kayit_Listele.CurrentRow.DataBoundItem;
                var duzenlemeFormu = new TanimlarKayitDuzenle(null);
                if (duzenlemeFormu.ShowDialog() == DialogResult.OK)
                {
                    Tanimlar.Reload();
                }
                return;
            }
            else
            {
                duzenlenenTanimlar = (Tanimlar)dgv_Kayit_Listele.CurrentRow.DataBoundItem;
                var duzenlemeFormu = new TanimlarKayitDuzenle(duzenlenenTanimlar);
                if (duzenlemeFormu.ShowDialog() == DialogResult.OK)
                {
                    Tanimlar.Reload();
                }
                return;
            }
        }
    }
}
