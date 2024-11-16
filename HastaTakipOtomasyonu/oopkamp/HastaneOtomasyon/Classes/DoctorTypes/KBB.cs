using HastaneOtomasyon.Elemanlar.Tedavi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Elemanlar.DoktorTipleri
{
    public class KBB : Doctor , IİlaçYaz ,IAmeliyat
    {
        public KBB(string ad, string tc) : base(ad, tc)
        {
            Adı = ad;
            Tc = tc;
            Hemşeriler = new List<string>();
            Randevular = new List<string>();
        }

        public string Ameliyat()
        {
            return "Ameliyat Et";
        }

        public  string İlaçYaz()
        {
            return "Reçete Yaz";
        }
    }
}
