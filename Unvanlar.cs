using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Windows.Forms;

namespace deneme1
{
    public partial class Unvanlar : Form
    {
        public Unvanlar()
        {
            InitializeComponent();
        }

        //private void Unvanlar_Load(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = new XPCollection<Unvan>();
        //}

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

            dgv_Kayit_Listele.DataSource = Unvan = new XPCollection<Unvan>(CriteriaOperator.And(filtreler));
        }

        XPCollection<Unvan> Unvan;

        Unvan duzenleneUnvan;

        private void Unvanlar_Load(object sender, EventArgs e)
        {
            btn_Bul.PerformClick();
        }

        private void BtnUnvanEkle_Click(object sender, EventArgs e)
        {
            duzenleneUnvan = (Unvan)dgv_Kayit_Listele.CurrentRow.DataBoundItem;
            var duzenlemeFormu = new UnvanDuzenle(null);
            if (duzenlemeFormu.ShowDialog() == DialogResult.OK)
            {
                Unvan.Reload();
            }
            return;
        }

        private void BtnBransDuzenle_Click(object sender, EventArgs e)
        {
            duzenleneUnvan = (Unvan)dgv_Kayit_Listele.CurrentRow.DataBoundItem;
            var duzenlemeFormu = new UnvanDuzenle(duzenleneUnvan);
            if (duzenlemeFormu.ShowDialog() == DialogResult.OK)
            {
                Unvan.Reload();
            }
            return;
        }

        private void ExcelExport()
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application xlsDoc;
                Microsoft.Office.Interop.Excel.Workbook xlsWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlsWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                Int16 i = 0;
                Int16 j = 0;

                xlsDoc = new Microsoft.Office.Interop.Excel.Application();
                xlsWorkBook = xlsDoc.Workbooks.Add(misValue);

                xlsWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlsWorkBook.Worksheets.get_Item(1);

                int baslangicKolonu = 1;
                int baslangicSatiri = 1;

                for (j = 0; j < dgv_Kayit_Listele.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range r = (Microsoft.Office.Interop.Excel.Range)xlsWorkSheet.Cells[baslangicSatiri, baslangicKolonu + j];
                    r.Value2 = dgv_Kayit_Listele.Columns[j].HeaderText;
                }

                baslangicSatiri++;

                for (i = 0; i <= dgv_Kayit_Listele.RowCount - 2; i++)
                {
                    for (j = 0; j <= dgv_Kayit_Listele.ColumnCount - 1; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range r = (Microsoft.Office.Interop.Excel.Range)xlsWorkSheet.Cells[baslangicSatiri + i, baslangicKolonu + j];
                        r.Value2 = dgv_Kayit_Listele[j, i].Value == null ? "" : dgv_Kayit_Listele[j, i].Value;
                    }
                }

                xlsWorkBook.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                xlsWorkBook.Close(true, misValue, misValue);
                xlsDoc.Quit();
            }
        }
        private void ExcelAktar_Click(object sender, EventArgs e)
        {
            ExcelExport();
        }
    }
}
