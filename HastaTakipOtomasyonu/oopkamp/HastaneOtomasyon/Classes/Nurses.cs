using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Elemanlar
{
    public class Nurses : İnsan
    {
        public Nurses(string ad, string tc) : base(ad, tc)
        {
            Adı = ad;
            Tc = tc;

        }

        public string Branş { get; set; }
        public string Vardiya { get; set; }
       
    }
}
