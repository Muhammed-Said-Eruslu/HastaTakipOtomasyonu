using HastaneOtomasyon.Elemanlar.Tedavi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Elemanlar.DoktorTipleri
{
    public class Ortopedi : Doctor, IİlaçYaz, IRaporVer, IKırık,
        IOmuz, Iİgne
    {
        public Ortopedi(string ad, string tc) : base(ad, tc)
        {
            Adı = ad;
            Tc = tc;
            Hemşeriler = new List<string>();
            Randevular = new List<string>();
        }

        public string KırıkAmeliyatı()
        {
            return "Kırık Ameliyatı Et";
        }

        public string OmuzDüzelt()
        {
            return "Omuzu Düzelt";
        }

        public string RaporVer()
        {
            return "Rapor Yaz";
        }

        public string İlaçYaz()
        {
            return "Reçete Yaz";
        }

        public string İğneYap()
        {
            return "İğne Yap";
        }
    }
}
