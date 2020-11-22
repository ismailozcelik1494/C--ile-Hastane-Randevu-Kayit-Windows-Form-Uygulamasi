using DevExpress.Xpo;
using System;

namespace deneme1
{
    public class Brans:XPObject
    {
        public string Ad { get; set; }
        public string Kod { get; set; }
        public Boolean HizmetDurum { get; set; }
        public override string ToString()
        {
            return Ad;
        }
    }
}
