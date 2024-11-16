using HastaneOtomasyon.Elemanlar.Tedavi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Elemanlar.DoktorTipleri
{
    public class Cocuk : Doctor , IİlaçYaz ,IRaporVer ,IKonsultasyon
    {
        public Cocuk(string ad, string tc) : base(ad, tc)
        {
            Adı = ad;
            Tc = tc;
            Hemşeriler = new List<string>();
            Randevular = new List<string>();

        }

  
        public string Konsultasyon()
        {
            return "Kolsultasyon Al";
        }

        public string RaporVer()
        {
            return "Rapor";
        }

        public string İlaçYaz()
        {
            return "Reçete Yaz";
        }
    }
}
