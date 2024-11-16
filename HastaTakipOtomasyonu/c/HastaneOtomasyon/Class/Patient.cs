using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Class
{
    public class Patient
    {
        public int Id { get;  set; } // Hasta ID, otomatik olarak ayarlanabilir
        public string Name { get;  set; } // Hasta adı
        public string Surname { get;  set; } // Hasta soyadı
        public string TCKN { get;  set; } // TC kimlik numarası
        public DateTime DateOfBirth { get;  set; } // Doğum tarihi
        public string Gender { get;  set; } // Cinsiyet (Kadın / Erkek)
        public List<Appointment> Appointments { get;  set; } // Randevular
    }
}
