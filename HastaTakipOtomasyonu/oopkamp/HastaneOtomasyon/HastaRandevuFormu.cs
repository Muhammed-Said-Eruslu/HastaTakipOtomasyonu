using HastaneOtomasyon.Elemanlar;
using HastaneOtomasyon.Enumlar;
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
    public partial class HastaRandevuFormu : Form
    {
        public HastaRandevuFormu()
        {
            InitializeComponent();
        }

        private void HastaRandevuFormu_Load(object sender, EventArgs e)
        {

            grpKisi.Enabled = false;
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtTc.Enabled = false;




        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            foreach (var item in Form1.hastalar)
            {
                if (item.Tc == txtArama.Text)
                {
                    txtAd.Text = item.Adı;
                    txtSoyad.Text = item.Soyad;
                    txtTc.Text = item.Tc;
                    grpKisi.Enabled = true;
                }


            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("Hasta Bilgileri Boş");
                return;
            }

            DateTime mevcutTarih = DateTime.Now;
            DateTime randevuTarihi = mevcutTarih.AddDays(15);
            string bölüm = "";
            if (txtTc.Text == "")
            {
                MessageBox.Show("Arama Kısmı Boş Olamaz");
            }

            if (rdbCocuk.Checked) bölüm = rdbCocuk.Text;
            if (rdbPsikiyatri.Checked) bölüm = rdbPsikiyatri.Text;
            if (rdbOrtopedi.Checked) bölüm = rdbOrtopedi.Text;
            if (rdbKBB.Checked) bölüm = rdbKBB.Text;
            if (rdbEnfeksiyon.Checked) bölüm = rdbEnfeksiyon.Text;
            if (rdbDermatoloji.Checked) bölüm = rdbDermatoloji.Text;
            if (rdbDahiliye.Checked) bölüm = rdbDahiliye.Text;
            if (bölüm == "")
            {
                MessageBox.Show("Randevu Bölümü Seçiniz");
                return;
            }
            if (dateTimePicker2.Value > randevuTarihi)
            {
                MessageBox.Show("15 Gün İlerisi için randevu verilemez");
                return;
            }
            string doktor = "";
            doktor = lstDoktorlar.Text;
            string isim = txtAd.Text + " " + txtSoyad.Text;
            if (doktor =="")
            {
                MessageBox.Show("Doktor Seçiniz");
                return;

            }


            foreach (var item in Form1.hastalar)
            {
                if (item.Tc == txtTc.Text)
                {

                    item.RandevuTarihi = dateTimePicker2.Value.ToString();
                    item.RandevuBölümü = bölüm;
                    item.Doktorİsmi = doktor;
                    foreach (var item1 in Form1.doktors)
                    {

                        item1.Randevular.Add(isim);
                        MessageBox.Show("Randevu Oluşturuldu");
                        txtArama.Text = "";
                        txtAd.Text = "";
                        txtSoyad.Text = "";
                        txtTc.Text = "";
                        return;


                    }


                }

            }


        }

        private void rdbEnfeksiyon_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in Form1.doktors)
            {
                if (item.Branş == ItemsEnums.Enfeksiyon.ToString())
                {

                    lstDoktorlar.Items.Add(item.Adı);

                }
            }

        }

        private void rdbOrtopedi_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in Form1.doktors)
            {

                if (item.Branş == ItemsEnums.Ortopedi.ToString())
                {
                    lstDoktorlar.Items.Add(item.Adı);
                }

            }
        }

        private void rdbPsikiyatri_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in Form1.doktors)
            {

                if (item.Branş == ItemsEnums.Psikiyatri.ToString())
                {
                    lstDoktorlar.Items.Add(item.Adı);
                }

            }
        }

        private void rdbDahiliye_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in Form1.doktors)
            {

                if (item.Branş == ItemsEnums.Dahiliye.ToString())
                {
                    lstDoktorlar.Items.Add(item.Adı);
                }

            }
        }

        private void rdbDermatoloji_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in Form1.doktors)
            {

                if (item.Branş == ItemsEnums.Dermatoloji.ToString())
                {
                    lstDoktorlar.Items.Add(item.Adı);
                }

            }
        }

        private void rdbCocuk_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in Form1.doktors)
            {

                if (item.Branş == ItemsEnums.Cocuk.ToString())
                {
                    lstDoktorlar.Items.Add(item.Adı);
                }

            }
        }

        private void rdbKBB_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in Form1.doktors)
            {

                if (item.Branş == ItemsEnums.KBB.ToString())
                {
                    lstDoktorlar.Items.Add(item.Adı);
                }

            }
        }
    }
}
