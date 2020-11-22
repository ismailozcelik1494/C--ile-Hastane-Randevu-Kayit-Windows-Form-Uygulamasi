using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DevExpress.Xpo;

namespace deneme1
{
    public abstract class Personel:XPObject
    {
        [Size(11)]
        public string TCNO { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Brans { get; set; }
        public string Unvan { get; set; }
        public DateTime GorevTarih { get; set; }
        public byte SozlesmeSuresi { get; set; }
        public Boolean GorevDurum { get; set; }
        public decimal Maas { get; set; }
        
    }
}
