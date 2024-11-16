using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Class
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Tc { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }
        public int PatientsPerDay { get; set; }
        public int SeizuresPerMonth { get; set; }
        public string Title { get; set; }
        public string Unvan { get; set; }
        public string Branch { get; set; }
        public int? SpecializationId { get; set; } // Foreign Key, nullable
        public Specialization Specialization { get; set; } // Nullable Navigation Property

        public List<Nurse> Nurses { get; set; } // Nullable Collection
        public List<Appointment> Appointments { get; set; }
    }
}
