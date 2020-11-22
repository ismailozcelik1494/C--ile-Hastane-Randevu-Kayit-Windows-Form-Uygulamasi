using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DevExpress.Xpo;

namespace deneme1
{
    public class Muayene: XPObject
    {
        public string TCNO { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime RandevuTarih { get; set; }
        public string Bolum { get; set; }
        public Doktor Doktoru { get; set; }
        public string Teshis { get; set; }
        public override string ToString()
        {
            return TCNO;
        }
    }
}
