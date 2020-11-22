using DevExpress.Xpo;
using System;
using System.Windows.Forms;
namespace deneme1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(DevExpress.Xpo.DB.MySqlConnectionProvider.GetConnectionString("localhost", "root", "", "HastaneKayit"), DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
        }
        private void Btn_HastaKayitlar_Click(object sender, EventArgs e)
        {
            HastaKayitlar HastaKayit = new HastaKayitlar();
            HastaKayit.Show();
        }

        private void Btn_DoktorKayitlar_Click(object sender, EventArgs e)
        {
            DoktorKayitlar DoktorKayit = new DoktorKayitlar();
            DoktorKayit.Show();
        }

        private void Btn_RandevuAl_Click(object sender, EventArgs e)
        {
            RandevuAl RandevuAl = new RandevuAl();
            RandevuAl.Show();
        }

        private void BtnKlinikKayit_Click(object sender, EventArgs e)
        {
            KlinikKayitlar KlinikKayitlar = new KlinikKayitlar();
            KlinikKayitlar.Show();
        }

        private void BtnTanimlar_Click(object sender, EventArgs e)
        {
            new Branslar().ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Unvanlar().ShowDialog();
        }

        private void BtnPerosenller_Click(object sender, EventArgs e)
        {
            new Personeller().ShowDialog();
        }
    }
}
