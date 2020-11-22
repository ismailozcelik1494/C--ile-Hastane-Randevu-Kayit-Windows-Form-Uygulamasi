using DevExpress.Xpo;
using System;

namespace deneme1
{
    public class Unvan: XPObject
    {
        public string Ad { get; set; }
        public string Kod { get; set; }
        public Boolean HizmetDurum { get; set; }
        public string AdKod { get { return string.Concat(Ad, " (", Kod, ")"); } }
    }
}
