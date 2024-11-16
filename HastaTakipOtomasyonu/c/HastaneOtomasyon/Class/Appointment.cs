using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Class
{
    public class Appointment
    {
       
        
            public int Id { get; set; }
            public DateTime AppointmentDate { get; set; }

            public int? DoctorId { get; set; } // Foreign Key, nullable
            public Doctor Doctor { get; set; } // Nullable Navigation Property

            public int PatientId { get; set; } // Foreign Key, required
            public Patient Patient { get; set; } // Required Navigation Property
        }

    }
