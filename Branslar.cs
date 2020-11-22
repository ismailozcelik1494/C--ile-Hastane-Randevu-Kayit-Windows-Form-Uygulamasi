using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Windows.Forms;

namespace deneme1
{
    public partial class Branslar : Form
    {
        public Branslar()
        {
            InitializeComponent();
        }

        //private void Branslar_Load(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = new XPCollection<Brans>();
        //}

        [Obsolete]
        private void Btn_Bul_Click(object sender, EventArgs e)
        {
            CriteriaOperatorCollection filtreler = new CriteriaOperatorCollection();

            if (combo_Kategori.SelectedIndex == 0)
            {
                filtreler.Esit("Kod", txt_Ara);
            }
            else if (combo_Kategori.SelectedIndex == 1)
            {
                filtreler.Esit("Ad", txt_Ara);
            }

            dgv_Kayit_Listele.DataSource = Brans = new XPCollection<Brans>(CriteriaOperator.And(filtreler));
        }
        XPCollection<Brans> Brans ;
        
        Brans duzenlenenBrans;

        private void Branslar_Load(object sender, EventArgs e)
        {
            btn_Bul.PerformClick();
        }

        private void BtnBransEkle_Click(object sender, EventArgs e)
        {
            duzenlenenBrans = (Brans)dgv_Kayit_Listele.CurrentRow.DataBoundItem;
            var duzenlemeFormu = new BransDuzenle(null);
            if (duzenlemeFormu.ShowDialog() == DialogResult.OK)
            {
                Brans.Reload();
            }
            return;
        }

        private void BtnBransDuzenle_Click(object sender, EventArgs e)
        {
            duzenlenenBrans = (Brans)dgv_Kayit_Listele.CurrentRow.DataBoundItem;
            var duzenlemeFormu = new BransDuzenle(duzenlenenBrans);
            if (duzenlemeFormu.ShowDialog() == DialogResult.OK)
            {
                Brans.Reload();
            }
            return;
        }
    }
}
