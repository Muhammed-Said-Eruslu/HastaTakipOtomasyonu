using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Elemanlar
{
    public class Hasta : İnsan
    {
        public Hasta(string ad ,string tc):base(ad,tc) 
        {
            Adı = ad;
          
            Tc = tc;
                
        }
        public string Soyad { get; set; }
        public string RandevuTarihi { get; set; }
        public string RandevuBölümü { get; set; }
        public string Doktorİsmi { get; set; }
    }
}
