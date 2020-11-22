using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme1
{
    public class HataKontrol
    {
        List<string> _hatalar = new List<string>();
        public void TextBosKontrol(TextBox textBox,string alanAdi)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text.Trim()))
            {
                _hatalar.Add(alanAdi + " giriniz");
            }
        }

        public bool HataVarmi()
        {
            if (_hatalar.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, _hatalar), "Lütfen alanları doldurunuz");
                return true;
            }
            return false;
        }

        public void TCKimlikKontrol(TextBox textBox, string alanAdi)
        {
        
            if (textBox.Text.Trim().Length>11)
            {
                _hatalar.Add(alanAdi + " numarası 11 karakterden büyük olamaz.");
            }
        }

        [Obsolete]
        public void YasKontrol(TextBox textBox,string alanAdi)
        {
            
            if (textBox.Text.Length>3)
            {
                _hatalar.Add(alanAdi + "Yanlış değer girdiniz. Yaş aralığı 0-150 arasındadır.");
            }
        }

    }
}
