using HastaneOtomasyon.Class;
using HastaneOtomasyon.Context;
using HastaneOtomasyon.Enums;
using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class DoktorEkleFormu : Form
    {
        private AppDbContext _context;

        public DoktorEkleFormu()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void LoadSpecializations()
        {
            // Branşları veritabanından al
            cmbBrans.DataSource = _context.Specializations.ToList();
            cmbBrans.DisplayMember = "Name"; // Branş adı alanı
            cmbBrans.ValueMember = "Id"; // Branş ID alanı
        }

        private void ClearForm()
        {
            // Formu temizleme
            txtAd.Clear();
            txtSoyad.Clear();
            txtTc.Clear();
            txtHastaSayısı.Clear();
            txtNobetSayısı.Clear();
            txtMaas.Clear();
            txtUnvan.Clear();
            cmbCinsiyet.SelectedIndex = -1;
            cmbBrans.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void DoktorEkleFormu_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            foreach(BranchEnums branchEnums in  Enum.GetValues(typeof(BranchEnums)))
            {
                cmbUnvan.Items.Add(branchEnums);
            }
            
            LoadSpecializations();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string unvan = cmbUnvan.Text;
            // Ad Kontrolü
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Ad alanı boş olamaz.");
                txtAd.Focus();
                return;
            }

            // Soyad Kontrolü
            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Soyad alanı boş olamaz.");
                txtSoyad.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(cmbUnvan.Text))
            {
                MessageBox.Show("Bölümü Boş Geçilemez");
            }

            // TC Kontrolü
            if (string.IsNullOrWhiteSpace(txtTc.Text) || txtTc.Text.Length != 11 || !long.TryParse(txtTc.Text, out _))
            {
                MessageBox.Show("TC kimlik numarası geçerli olmalıdır (11 rakam).");
                txtTc.Focus();
                return;
            }

            // Doğum Tarihi Kontrolü
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Doğum tarihi geçerli olmalıdır.");
                dateTimePicker1.Focus();
                return;
            }

            // Hasta Sayısı Kontrolü
            if (!int.TryParse(txtHastaSayısı.Text, out int hastaSayisi))
            {
                MessageBox.Show("Hasta sayısı geçerli bir sayı olmalıdır.");
                txtHastaSayısı.Focus();
                return;
            }
            if(hastaSayisi > 40)
            {
                MessageBox.Show("hasta sayısı 40'ı geçmemelidir");
                return;
            }
            // Nöbet Sayısı Kontrolü
            if (!int.TryParse(txtNobetSayısı.Text, out int nobetSayisi))
            {
                MessageBox.Show("Nöbet sayısı geçerli bir sayı olmalıdır.");
                txtNobetSayısı.Focus();
                return;
            }
            if(nobetSayisi > 5)
            {
                MessageBox.Show("nöbet sayısı 5'i geçmemelidir");
            }
            // Cinsiyet Kontrolü
            if (cmbCinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Cinsiyet seçilmelidir.");
                cmbCinsiyet.Focus();
                return;
            }

            // Maaş Kontrolü
            if (!decimal.TryParse(txtMaas.Text, out decimal maas))
            {
                MessageBox.Show("Maaş geçerli bir sayı olmalı.");
                txtMaas.Focus();
                return;
            }
            if(maas <= 20000)
            {
                maas = 25000;
            }
            // Unvan Kontrolü
            if (string.IsNullOrWhiteSpace(txtUnvan.Text))
            {
                MessageBox.Show("Unvan alanı boş olamaz.");
                txtUnvan.Focus();
                return;
            }

            // Branş Kontrolü (ComboBox)
            if (cmbBrans.SelectedIndex == -1)
            {
                MessageBox.Show("Bir branş seçilmelidir.");
                cmbBrans.Focus();
                return;
            }
            if(rdbCocuk.Checked)
            {
                cmbUnvan.Text = "Çocuk Doktoru";
            }

            // Tüm kontroller geçildi
            var doktor = new Doctor
            {
                Name = txtAd.Text,
                SurName = txtSoyad.Text,
                Tc = txtTc.Text,
                BirthDate = dateTimePicker1.Value,
                PatientsPerDay = hastaSayisi,
                SeizuresPerMonth = nobetSayisi,
                Gender = cmbCinsiyet.SelectedItem.ToString(),
                Salary = maas,
                Title = txtUnvan.Text,
                SpecializationId = (int)cmbBrans.SelectedValue, // Seçilen branş ID'sini al
                Unvan = unvan,
                Branch = cmbBrans.SelectedItem.ToString()
            };

            // Doktoru veritabanına ekleme işlemi
            _context.Doctors.Add(doktor);
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Doktor başarıyla eklendi.");
                ClearForm(); // Formu temizle
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.InnerException?.Message}");
            }
        }
    }
    }

