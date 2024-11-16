using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Elemanlar
{
    public abstract class İnsan
    {
        public İnsan(string ad, string tc)
        { 
            Adı = ad;

            Tc = tc;

        }
       
        public string Adı { get; set; }

        public string Cinsiyet { get; set; }
        public string Tc 
        { get;

            set;
         
        }
        public DateTime Doğum { get; set; }

    }
}
