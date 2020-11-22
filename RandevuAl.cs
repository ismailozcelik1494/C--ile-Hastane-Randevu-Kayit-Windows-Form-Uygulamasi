using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace deneme1
{
    public partial class RandevuAl : Form
    {
        public RandevuAl()
        {
            InitializeComponent();
            dtpRandevuTarih.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            XPView xPView = new XPView(XpoDefault.Session, typeof(Doktor));
            xPView.AddProperty("Concat([Ad],' ' ,[Soyad])");
            xPView.AddProperty("");
            xPView.AddProperty("RandevuAdet", new AggregateOperand("Randevular", "RandevuTarih", Aggregate.Max));
        }

        private void RandevuAl_Load(object sender, EventArgs e)
        {
            cbDoktor.DataSource = new XPCollection<Doktor>();
            cbDoktor.DisplayMember = "AdSoyad";
            cbKlinik.DataSource = new XPCollection<Klinik>();
            cbKlinik.DisplayMember = "KlinikAd";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var seciliSaat = panel1.Controls.Cast<RadioButton>().Where(rb => rb.Checked && rb.Enabled).FirstOrDefault();
            
            if (seciliSaat == null)
            {
                MessageBox.Show("Lütfen randevu saatini seçiniz!");
            }
            else
            {
                var randevuTarih = dtpRandevuTarih.Value.Date.Add(TimeSpan.Parse(seciliSaat.Text));
                //MessageBox.Show(randevuTarih.ToString);
                var evetmi = MessageBox.Show(randevuTarih.ToString() + " Tarihinde ve Saatinde " + cbKlinik.Text + " Kliniğinde \n" + cbDoktor.Text + " Tarafından Muayene İçin Randevu Alınıyor ", "HASTA KAYIT PROJESİ", MessageBoxButtons.YesNo);
                if (evetmi==DialogResult.Yes)
                {
                    var kriter = new BinaryOperator("Doktor.Oid", ((Doktor)cbDoktor.SelectedItem).Oid)
                            & new BinaryOperator("RandevuTarih", randevuTarih);
                    var eskiKayit = XpoDefault.Session.FindObject<Randevu>(kriter);
                    if (eskiKayit == null)
                    {
                        var hataKontrol = new HataKontrol();
                        hataKontrol.TCKimlikKontrol(txtTCNO, "TCNO");
                        hataKontrol.TextBosKontrol(txtTCNO, "TCNO");
                        hataKontrol.TextBosKontrol(txtAd, "Ad");

                        hataKontrol.TextBosKontrol(txtSoyad, "Soyad");
                        if (hataKontrol.HataVarmi())
                            return;
                        Randevu randevu = new Randevu();
                        randevu.TCNO = txtTCNO.Text.Trim();
                        randevu.Ad = txtAd.Text.Trim();
                        randevu.Soyad = txtSoyad.Text.Trim();
                        randevu.Klinik = (Klinik)cbKlinik.SelectedItem;
                        randevu.Doktor = (Doktor)cbDoktor.SelectedItem;
                        randevu.RandevuTarih = randevuTarih;
                        //randevu.RandevuTarih = DateTime.ParseExact(randevuTarih.ToString("dd.MM.yyyy") + " " + sender.ToString().Substring(34), "dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                        randevu.Save();
                        MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                    }
                    else
                    {
                        MessageBox.Show("Bu doktor için daha önce bu tarih ve saatte randevu alınmış!");
                    }
                }
            }
        }
    }
}