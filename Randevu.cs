using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
namespace deneme1
{
    public class Randevu:XPObject
    {
        public string TCNO { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        [Association("KlinikRandevular")]
        public Klinik Klinik { get; set; }

        [Association("DoktorRandevular")]
        public Doktor Doktor { get; set; }
        public DateTime RandevuTarih { get; set; }
        public DateTime RandevuBitis { get; set; }
    }
}
