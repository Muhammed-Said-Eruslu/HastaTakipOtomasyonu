using HastaneOtomasyon.Elemanlar.Tedavi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Elemanlar.DoktorTipleri
{
    public class Enfeksiyon : Doctor, IİlaçYaz , INumune
    {
        public Enfeksiyon(string ad, string tc) : base(ad, tc)
        {
            Adı = ad;
            Tc = tc;
            Hemşeriler = new List<string>();
            Randevular = new List<string>();
        }

        public string NumuneAl()
        {
            return "Numune İste";
        }

        public string İlaçYaz()
        {
            return "Reçete Yaz";
        }
    }

   
}
