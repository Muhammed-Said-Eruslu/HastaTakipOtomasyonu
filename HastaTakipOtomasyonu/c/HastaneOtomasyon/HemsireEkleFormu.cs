using HastaneOtomasyon.Class;
using HastaneOtomasyon.Context;
using HastaneOtomasyon.Enums;
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
    public partial class HemsireEkleFormu : Form
    {
        public HemsireEkleFormu()
        {
            InitializeComponent();
        }

        private void HemsireEkleFormu_Load(object sender, EventArgs e)
        {
            foreach (GenderEnums genderEnums in Enum.GetValues(typeof(GenderEnums)))
            {
                cmbCinsiyet.Items.Add(genderEnums);
            }
            foreach (BranchEnums branchEnums in Enum.GetValues(typeof(BranchEnums)))
            {
                cmbBrans.Items.Add(branchEnums);
            }
            foreach (StaffEnums staffEnums in Enum.GetValues(typeof(StaffEnums)))
            {
                cmbVardiya.Items.Add(staffEnums);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyAd = txtSoyad.Text;
            string tc = txtTc.Text; // tc numarasını tutar
            DateTime dogumTarihi = dateTimePicker1.Value; // dateTimePicker1'in degerini alır
            string cinsiyet = cmbCinsiyet.SelectedItem?.ToString(); // cmbCinsiyet den secılen cınsıyetı strınge cevirir
            string brans = cmbBrans.SelectedItem?.ToString();
            string vardiya = cmbVardiya.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(soyAd))
            {
                MessageBox.Show("Ad Alanı Boş Bırakılamaz");
            }
            if (string.IsNullOrWhiteSpace(ad))
            {
                MessageBox.Show("soyad Alanı Boş Bırakılamaz");
            }
            if (string.IsNullOrWhiteSpace(tc))
            {
                MessageBox.Show("TCKNO Boş Bırakılamaz");
            }
            if (dogumTarihi == null)
            {
                MessageBox.Show("Dogum Tarihi Boş Bırakılamaz Boş Bırakılamaz");
            }
            if (cmbCinsiyet.SelectedItem == null)
            {
                MessageBox.Show("Cinsiyet Boş Bırakılamaz");
            }
            if (cmbBrans.SelectedItem == null)
            {
                MessageBox.Show("Branş Boş Bırakılamaz");
            }
            if (cmbVardiya.SelectedItem == null)
            {
                MessageBox.Show("Vardiya Boş Bırakılamaz");
            }
            if (tc.Length == 11 && long.TryParse(tc, out _)) // _ bu işaretin kullanılmasıının sebebi geri donus degerı ıstmedıım ıcın
            {
                using (var context = new AppDbContext())
                {
                    var hemsireZaten = context.Nurses.FirstOrDefault(x => x.Tc == tc);
                    if (hemsireZaten != null)
                    {
                        MessageBox.Show("Hemşire Sistemde Mevcut");
                    }
                    else
                    {
                        if (dogumTarihi >= DateTime.Now)
                        {
                            MessageBox.Show("Hemşirenin Yaşı İleri Tarih Olamaz");
                        }
                        int yas = DateTime.Now.Year - dogumTarihi.Year;
                        if (yas < 24)
                        {
                            MessageBox.Show("Hemşirenin Yaşı 24'ten Küçük Olamaz");
                        }
                        Nurse nurse = new Nurse()
                        {
                            Name = ad,
                            SurName = soyAd,
                            Tc = tc,
                            Gender = cinsiyet,
                            BirthDate = dogumTarihi,
                            Shift = vardiya,
                            Branch = brans
                        };
                        context.Nurses.Add(nurse);
                        context.SaveChanges();
                        MessageBox.Show("Hemşire Başarılı Bir Şekilde Eklendi");
                    }
                }
            }
            else
            {
                MessageBox.Show("TCKNO 11 Karakter Olmadılır ve Sadece Sayı İçermelidir");
            }

        }
    }
}
