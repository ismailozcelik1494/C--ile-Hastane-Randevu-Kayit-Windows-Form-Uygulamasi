using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme1
{
    public class Hasta : XPObject
    {
        [Size(11)]
        public string TCNO { get; set; }
        [Size(25)]
        public string Ad { get; set; }
        [Size(25)]
        public string Soyad { get; set; }
        public string AnneAd { get; set;}
        public string BabaAd { get; set; }
        public DateTime DogumTarih { get; set; }
        [Size(3)]
        public byte Yas { get; set; }
        public string TelEv { get; set; }
        public string TelCep { get; set; }
        [Size(180)]
        public string Adres { get; set; }
        public string Cinsiyet { get; set; }
        public string KanGrub { get; set; }
        public Boolean CalismaDurum { get; set; }
        public string Meslek { get; set; }
        public Boolean SigortaVarYok { get; set; }
        public string SigortaDurum { get; set; }
        public DateTime SigortaBaslamaTarih { get; set; }
        public string CalistigiGun { get; set; }
        public Doktor Doktor { get; set; }

        //private DateTime tarih;
        //public DateTime Tarih { get => tarih; set => SetPropertyValue("Tarih", ref tarih, value); }
        //[Size(180)]
        //[Size(SizeAttribute.Unlimited), Delayed(true)]
        //public string Metin
        //{
        //    get { return GetDelayedPropertyValue<string>("Metin"); }
        //    set { SetDelayedPropertyValue("Metin", value); }
        //}
    }
}