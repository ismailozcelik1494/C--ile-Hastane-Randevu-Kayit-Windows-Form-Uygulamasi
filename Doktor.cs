using DevExpress.Xpo;
using System;
using System.Drawing;
namespace deneme1
{
    public class Doktor: XPObject
    {
        [Size(11)]
        public string TCNO { get; set; }
        [Size(25)]
        public string Ad { get; set; }
        [Size(25)]
        public string Soyad { get; set; }
        public DateTime GorevTarih { get; set; }
        public Brans Brans { get; set; }
        public Unvan Unvan { get; set; }
        public Boolean GorevDurum { get; set; }

        
        [Association("DoktorRandevular")]
        public XPCollection<Randevu> Randevular => GetCollection<Randevu>("Randevular");

        [PersistentAlias("Concat([Ad],' ' ,[Soyad])")]
        //public string AdSoyad => string.Concat(Ad, " ", Soyad, " - ", TCNO);
        public string AdSoyad => string.Concat(Ad, " ", Soyad);
        public override string ToString()
        {
            return AdSoyad;
        }

        public static explicit operator Doktor(string v)
        {
            throw new NotImplementedException();
        }


        //private DateTime tarih;
        //public DateTime GorevTarih { get => tarih; set => SetPropertyValue("Tarih", ref tarih, value); }
    }
}
