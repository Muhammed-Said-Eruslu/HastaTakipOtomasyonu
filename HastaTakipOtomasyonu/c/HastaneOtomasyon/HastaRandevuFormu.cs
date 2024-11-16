using HastaneOtomasyon.Class;
using HastaneOtomasyon.Context;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class HastaRandevuFormu : Form
    {
        public HastaRandevuFormu()
        {
            InitializeComponent();
        }

        private void HastaRandevuFormu_Load(object sender, EventArgs e)
        {
            grpKisi.Visible = false;
            btnEkle.Visible = false;
            grpBranch.Visible = false;
            lstDoktorlar.Visible = false;

          
            rdbOrtopedi.Tag = 1;    // Ortopedi ID'si
            rdbPsikiyatri.Tag = 2;  
            rdbDahiliye.Tag = 3;   
            rdbDermatoloji.Tag = 4;
            rdbEnfeksiyon.Tag = 5; 
            rdbCocuk.Tag = 6;     
            rdbKBB.Tag = 7;         

           
            rdbOrtopedi.CheckedChanged += rdbBrans_CheckedChanged;
            rdbPsikiyatri.CheckedChanged += rdbBrans_CheckedChanged;
            rdbDahiliye.CheckedChanged += rdbBrans_CheckedChanged;
            rdbDermatoloji.CheckedChanged += rdbBrans_CheckedChanged;
            rdbEnfeksiyon.CheckedChanged += rdbBrans_CheckedChanged;
            rdbCocuk.CheckedChanged += rdbBrans_CheckedChanged;
            rdbKBB.CheckedChanged += rdbBrans_CheckedChanged;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string tc = txtArama.Text.Trim(); 
            // Debugging için TCKN'yi göster
            MessageBox.Show($"Girilen TCKN: '{tc}' (Uzunluk: {tc.Length})");

           
            if (tc.Length != 11)
            {
                MessageBox.Show("TCKN 11 karakter olmalı.");
                return;
            }

            
            if (!long.TryParse(tc, out _) || !tc.All(char.IsDigit))
            {
                MessageBox.Show("TCKN yalnızca sayılardan oluşmalıdır.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var hasta = context.Patients.FirstOrDefault(x => x.TCKN == tc);
                if (hasta == null)
                {
                    MessageBox.Show("Sistemde bu TCKNO sahibi hasta bulunamadı.");
                    return;
                }

                
                txtAd.Text = hasta.Name;
                txtSoyad.Text = hasta.Surname;
                txtTc.Text = hasta.TCKN;

               
                grpKisi.Visible = true;
                btnEkle.Visible = true; 
                grpBranch.Visible = true; 
                lstDoktorlar.Visible = true; 
            }
        }

        private void rdbBrans_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                int bransId = (int)selectedRadioButton.Tag; 
                BranşlarıYükle(bransId); 
            }
        }

        private void BranşlarıYükle(int bransId)
        {
            
            List<Doctor> doktorlar = DoktorSorgula(bransId); 

            lstDoktorlar.Items.Clear(); // ListBox'ı temizle

            if (doktorlar.Count == 0) // Eğer hiç doktor yoksa
            {
                MessageBox.Show("Seçilen branşta doktor bulunamadı.");
                return;
            }

            foreach (var doktor in doktorlar)
            {
                // NULL kontrolü yaparak ekle
                string doktorAdi = doktor.Name ?? "Bilinmiyor";
                string doktorSoyadi = doktor.SurName ?? "Bilinmiyor"; 

                lstDoktorlar.Items.Add($"{doktorAdi} {doktorSoyadi}"); 
            }
        }

        private List<Doctor> DoktorSorgula(int bransId)
        {
            using (var context = new AppDbContext())
            {
               
                var doktorlar = context.Doctors
                    .Where(d => d.SpecializationId == bransId)
                    .Select(d => new Doctor
                    {
                        Id = d.Id,
                        Name = d.Name != null ? d.Name : "Bilinmiyor", 
                        SurName = d.SurName != null ? d.SurName : "Bilinmiyor", 
                    })
                    .ToList();

                if (!doktorlar.Any())
                {
                    Console.WriteLine($"Branş ID: {bransId} için doktor bulunamadı.");
                }

                return doktorlar;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if (lstDoktorlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir doktor seçin.");
                return;
            }

           
            string selectedDoctorName = lstDoktorlar.SelectedItem.ToString();
            string[] doctorParts = selectedDoctorName.Split(' '); // Ad ve soyadı ayır

            
            string selectedDoctorAd = doctorParts[0];
            string selectedDoctorSoyad = doctorParts.Length > 1 ? doctorParts[1] : string.Empty; // Soyadı yoksa boş dizi kontrolü

           
            MessageBox.Show($"Seçilen Doktor: {selectedDoctorAd} {selectedDoctorSoyad}");

           
            DateTime appointmentDate = dateTimePicker2.Value; 

        
            int patientId;
            if (!int.TryParse(txtArama.Text, out patientId))
            {
                MessageBox.Show("Lütfen geçerli bir hasta ID'si girin.");
                return;
            }

            using (var context = new AppDbContext())
            {
                
                var selectedDoctor = context.Doctors.FirstOrDefault(d =>
                    d.Name.ToLower() == selectedDoctorAd.ToLower() &&
                    d.SurName.ToLower() == selectedDoctorSoyad.ToLower());

                if (selectedDoctor == null)
                {
                    MessageBox.Show("Seçilen doktor bulunamadı.");
                    return;
                }

               
                var appointment = new Appointment
                {
                    AppointmentDate = appointmentDate,
                    DoctorId = selectedDoctor.Id,
                    PatientId = patientId 
                };

                
                context.Appointments.Add(appointment);
                context.SaveChanges(); 

                MessageBox.Show("Randevu başarıyla oluşturuldu.");
            }
        }

    }
}
