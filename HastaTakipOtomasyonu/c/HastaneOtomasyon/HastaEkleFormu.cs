using HastaneOtomasyon.Class;
using HastaneOtomasyon.Context;
using HastaneOtomasyon.Enums;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class HastaEkleFormu : Form
    {
        public HastaEkleFormu()
        {
            InitializeComponent();
        }

        private void HastaEkleFormu_Load(object sender, EventArgs e)
        {
            foreach (GenderEnums genderEnums in Enum.GetValues(typeof(GenderEnums)))
            {
                cmbCinsiyet.Items.Add(genderEnums);
            }
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text; // kullanıcının gırdıgı ad degerını tutan degısken 
            string soyAd = txtSoyad.Text; // soyAdı tutar
            string tc = txtTc.Text; // tc numarasını tutar
            DateTime dogumTarihi = dateTimePicker1.Value; // dateTimePicker1'in degerini alır
            string cinsiyet = cmbCinsiyet.SelectedItem?.ToString(); // cmbCinsiyet den secılen cınsıyetı strınge ceviri null da gelebilir
            if (string.IsNullOrEmpty(cinsiyet))
            {
                MessageBox.Show("Cinsiyet Boş Geçilemez");

            }
            else if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Ad Boş Geçilemez");

            }
            else if (string.IsNullOrEmpty(soyAd))
            {
                MessageBox.Show("Soyad Boş Geçilemez");

            }
            else if (dogumTarihi == null)
            {
                MessageBox.Show("Dogum Tarihi Geçilemez");

            }
            else if (tc.Length == 11 && long.TryParse(tc, out _))
            {
                using (var context = new AppDbContext())
                {
                    var hastaZaten = context.Patients.FirstOrDefault(x => x.TCKN == tc);
                    if (hastaZaten != null)
                    {
                        MessageBox.Show("Hasta Sistemde Mevcut");
                        return;
                    }
                    else
                    {
                        if (dogumTarihi >= DateTime.Now)
                        {
                            MessageBox.Show("Hastanın Yaşı İleri Tarih Olamaz");
                        }
                        int yas = DateTime.Now.Year - dogumTarihi.Year;
                        if (yas < 18)
                        {
                            MessageBox.Show("Hastanın Yaşı 18'den Küçük Olamaz");
                        }
                        Patient patient = new Patient()
                        {
                            Name = ad,
                            Surname = soyAd,
                            TCKN = tc,
                            DateOfBirth = dogumTarihi,
                            Gender = cinsiyet,

                        };
                        context.Add(patient);
                        context.SaveChanges();
                        MessageBox.Show("Hasta Başarılı Bir Şekilde Eklendi");
                    }
                }
            }
            else
            {
                MessageBox.Show("TCKNO 11 Karakter Olmalıdır ve Sadece Sayı İçermelidir");
            }

        }
    }
}
