using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme1
{
    public class Klinik: XPObject
    {
        [Size(5)]
        public string KlinikNo { get; set; }
        [Size(20)]
        public string KlinikAd { get; set; }
        [Size(50)]
        public string SorumluPersonel { get; set; }
        [Size(50)]
        public string İlgiliDoktor { get; set; }
        [Size(5)]
        public string Blok { get; set; }
        [Size(3)]
        public string Kat { get; set; }
        public Boolean HizmetDurum { get; set; }

        [Association("KlinikRandevular")]
        public XPCollection<Randevu> Randevular => GetCollection<Randevu>("Randevular");
        [PersistentAlias("Concat([KlinikAd], ' ' ,[İlgiliDoktor])")]
        public string KlinikAdİlgiliDoktor => string.Concat(KlinikAd, " ", İlgiliDoktor);
        public override string ToString()
        {
            return KlinikAdİlgiliDoktor;
        }
        public static explicit operator Klinik(string v)
        {
            throw new NotImplementedException();
        }
    }
}
