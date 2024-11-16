using HastaneOtomasyon.Elemanlar;
using HastaneOtomasyon.Enumlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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



            cmbCinsiyet.Items.Add(ItemsEnums.Erkek);
            cmbCinsiyet.Items.Add(ItemsEnums.Kadın);



        }



        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            bool tcOk = true;

            int mevcutYıl = DateTime.Now.Year;
            string ad = txtAd.Text + " " + txtSoyad.Text;
            string tcM = txtTc.Text;


            if (txtAd.Text == "")
            {
                MessageBox.Show("Ad Boş Geçilemez");
                return;

            }
            else if (txtSoyad.Text == "")
            {
                MessageBox.Show("Soyad Boş Geçilemez");
                return;
            }

            else if (txtTc.Text == "")
            {
                MessageBox.Show("Tc Boş Geçilemez");
                return;
            }
            else if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Cinsiyet Boş Geçilemez");
                return;
            }
            else if (txtTc.Text.Length == 11)
            {
                bool tcMi = int.TryParse(txtTc.Text, out int tc);
                if (tcMi == true)
                {
                    MessageBox.Show("Hatalı Tc");
                    tcOk = false;
                    return;
                }
            }
            else if (txtTc.Text.Length != 11)
            {

                MessageBox.Show("Hatalı Tc");
                tcOk = false;
                return;
            }

            if (tcOk == true)
            {
                foreach (var item in Form1.hastalar)
                {
                    if (item.Tc == tcM)
                    {
                        MessageBox.Show("Hasta Zaten Mevcut");
                        return;
                    }


                }

            }



            Hasta hasta = new Hasta(ad, txtTc.Text)
            {
                Cinsiyet = cmbCinsiyet.Text,
                Doğum = dateTimePicker1.Value,
                Soyad = txtSoyad.Text,
                RandevuBölümü = "",
                RandevuTarihi = "",
                Doktorİsmi = ""



            };

            Form1.hastalar.Add(hasta);
            Form1.insan.Add(hasta);
            Form1.doğum.Add(hasta.Doğum);

            MessageBox.Show("Hasta Eklendi");
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTc.Text = "";
            cmbCinsiyet.SelectedItem = null;

        }



    }

}

