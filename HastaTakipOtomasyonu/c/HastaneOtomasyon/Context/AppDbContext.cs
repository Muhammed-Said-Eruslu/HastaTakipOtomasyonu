using HastaneOtomasyon.Class;
using Microsoft.EntityFrameworkCore;

namespace HastaneOtomasyon.Context
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-9TTU5F0\\SQLEXPRESS;Database=Hastane4;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Doctor ile Specialization arasındaki ilişki
            modelBuilder.Entity<Doctor>()
                .HasOne(d => d.Specialization)
                .WithMany(s => s.Doctors)
                .HasForeignKey(d => d.SpecializationId)
                .IsRequired(false); // Nullable olarak belirtiyoruz

            // Nurse ile Doctor arasındaki ilişki
            modelBuilder.Entity<Nurse>()
                .HasOne(n => n.Doctor)
                .WithMany(d => d.Nurses)
                .HasForeignKey(n => n.DoctorId)
                .IsRequired(false); // Nullable olarak belirtiyoruz

            // Appointment ile Doctor arasındaki ilişki
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId)
                .IsRequired(false); // Nullable olarak belirtiyoruz
            // Appointment ile Patient arasındaki ilişki
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientId)
                .IsRequired(); // Hasta ile ilişki zorunlu
        }
    }
}
