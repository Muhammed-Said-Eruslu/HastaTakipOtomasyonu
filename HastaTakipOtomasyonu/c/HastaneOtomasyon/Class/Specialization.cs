using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Class
{
    public class Specialization
    {
        public int Id { get; set; }
        public string SpecializationName { get; set; }

        public List<Doctor> Doctors { get; set; } = new List<Doctor>(); // Nullable Collection
        public List<Nurse> Nurses { get; set; } = new List<Nurse>(); // Nullable Collection
        public Specialization()
        {
            Doctors = new List<Doctor>();
            Nurses = new List<Nurse>();
        }
    }
}

