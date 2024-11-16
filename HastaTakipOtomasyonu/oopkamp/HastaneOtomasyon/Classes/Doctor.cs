using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Elemanlar
{
    public abstract class Doctor : İnsan
    {
        protected Doctor(string ad, string tc) : base(ad, tc)
        {

            Adı = ad;
            Tc = tc;
            Hemşeriler = new List<string>();
            Randevular = new List<string>();
        }


        public int GunlukHasta { get; set; }
        public int AylıkNöbet { get; set; }
        public int Maaş { get; set; }
        public string Ünvan { get; set; }
        public string Branş { get; set; }

        public List<string> Hemşeriler { get; set; }
        public List<string> Randevular { get; set; }


    }

}
