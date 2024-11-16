using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Class
{
    public class Nurse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Tc { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Shift { get; set; }
        public string Branch { get; set; }
        public int? DoctorId { get; set; } // Foreign Key, nullable
        public Doctor Doctor { get; set; } // Nullable Navigation Property
    }
}
