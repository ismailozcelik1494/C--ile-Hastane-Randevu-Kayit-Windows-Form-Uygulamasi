using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme1
{
    public static class Extensions
    {
        public static void Esit(this CriteriaOperatorCollection list, string alan, TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text)) list.Add(new BinaryOperator(alan, textBox.Text));
        }

        [Obsolete]
        public static void IleBaslayan(this CriteriaOperatorCollection list, string alan, TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text)) list.Add(new BinaryOperator(alan, textBox.Text + "%", BinaryOperatorType.Like));
        }

        public static void BuyukOlanlarByte(this CriteriaOperatorCollection list, string alan, TextBox textBox)
        {
            byte deger;
            if (byte.TryParse(textBox.Text, out deger))
            {
                list.Add(new BinaryOperator(alan, deger, BinaryOperatorType.GreaterOrEqual));
            }
        }

        [Obsolete]
        public static void TarihAra(this CriteriaOperatorCollection list, string alan, DateTimePicker date)
        {
            DateTime deger;
            if (DateTime.TryParse(Convert.ToString(date.Value.Date), out deger))
                return;
            list.Add(new BinaryOperator(alan, deger, BinaryOperatorType.Equal));
        }


        //public static void RandevuTarihata(Randevu randevual, string tarih, string saat)
        //{
        //    if (!string.IsNullOrWhiteSpace(tarih))
        //    {
        //        if (!string.IsNullOrWhiteSpace(saat))
        //        {
        //            Randevu randevu = new Randevu();
        //            DateTime date = DateTime.Now;
        //            string saatal = "12:30";
        //            randevual.RandevuTarih = DateTime.ParseExact(date.ToString("dd.MM.yyyy") + " " + saatal, "dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
        //            randevu.Save();
        //        }
        //    }
        //}

    }
}
