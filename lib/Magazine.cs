using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class Magazine
    {
        public string Baslik { get; set; }

        public string Yayinci { get; set; }

        public int Sayi { get; set; }

        public int Yyili { get; set; }


        public Magazine(string baslik, string yayinci, int sayi, int yyili)
        {
            Baslik = baslik;
            Yayinci = yayinci;
            Sayi = sayi;
            Yyili = yyili;
        }

    }
}
