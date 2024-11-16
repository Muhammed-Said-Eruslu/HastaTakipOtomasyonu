using HastaneOtomasyon.Context;

namespace HastaneOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorEkleFormu doktorEkleFormu = new DoktorEkleFormu();
            doktorEkleFormu.Show();
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaEkleFormu hastaEkleFormu = new HastaEkleFormu();
            hastaEkleFormu.Show();
        }

        private void btnHemsire_Click(object sender, EventArgs e)
        {
            this.Hide();
            HemsireEkleFormu hemsireEkleFormu = new HemsireEkleFormu();
            hemsireEkleFormu.Show();
        }

        private void btnHastaListesi_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var hastaListesi = context.Patients.ToList(); // tabloyu lýsteye cevirir
                dataGridView1.DataSource = hastaListesi;
            }
        }

        private void btnHemsireListele_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var hemsireListesi = context.Nurses.ToList();
                dataGridView1.DataSource = hemsireListesi;
            }
        }

        private void btnDoktorListele_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var doktorListesi = context.Doctors
            .Select(d => new
            {
                Id = d.Id,
                Name = d.Name ?? "Bilinmiyor", // Null olabýlýr
                SurName = d.SurName ?? "Bilinmiyor", 
                Tc = d.Tc ?? "Bilinmiyor", 
                BirthDate = d.BirthDate != null ? d.BirthDate.ToString("yyyy-MM-dd") : "Bilinmiyor", 
                Salary = d.Salary != null ? d.Salary : 0, 
                Gender = d.Gender ?? "Bilinmiyor", 
                PatientsPerDay = d.PatientsPerDay != null ? d.PatientsPerDay : 0,
                SeizuresPerMonth = d.SeizuresPerMonth != null ? d.SeizuresPerMonth : 0, 
                Title = d.Title ?? "Bilinmiyor", 
                Branch = d.Branch ?? "Bilinmiyor", 
                SpecializationId = d.SpecializationId != null ? d.SpecializationId.ToString() : "Bilinmiyor",
                Specialization = d.Specialization != null ? d.Specialization.SpecializationName : "Bilinmiyor" 
            })
            .ToList();

               
                dataGridView1.DataSource = doktorListesi;
            }
        }

        private void btnHastaRandevu_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaRandevuFormu hastaRandevuFormu = new HastaRandevuFormu();
            hastaRandevuFormu.Show();
        }
    }
}
