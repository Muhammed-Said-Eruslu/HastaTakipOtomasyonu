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
    public partial class HemsireEkleFormu : Form
    {
        public HemsireEkleFormu()
        {
            InitializeComponent();
        }


        private void HemsireEkleFormu_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.Add(ItemsEnums.Erkek);
            cmbCinsiyet.Items.Add(ItemsEnums.Kadın);
            cmbVardiya.Items.Add(ItemsEnums.Gündüz);
            cmbVardiya.Items.Add(ItemsEnums.Gece);

            cmbbranş.Items.Add(ItemsEnums.Dahiliye);
            cmbbranş.Items.Add(ItemsEnums.Enfeksiyon);
            cmbbranş.Items.Add(ItemsEnums.Cocuk);
            cmbbranş.Items.Add(ItemsEnums.Ortopedi);
            cmbbranş.Items.Add(ItemsEnums.Dermatoloji);
            cmbbranş.Items.Add(ItemsEnums.Dahiliye);
            cmbbranş.Items.Add(ItemsEnums.KBB);

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text + " " + txtSoyad.Text;
            string tc = txtTc.Text;
            string vardiya = cmbVardiya.Text;
            string cinsiyet = cmbCinsiyet.Text;
            string branş = cmbbranş.Text;
            bool tcOk = true;
            DateTime doğumTarihi = dateTimePicker1.Value;

            int mevcutYıl = DateTime.Now.Year;
            int doğum = dateTimePicker1.Value.Year;


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
                bool tcMi = int.TryParse(txtTc.Text, out int tc1);
                if (tcMi == true)
                {
                    MessageBox.Show("Hatalı Tc");
                    tcOk = false;
                    return;
                }
            }

            if (cmbbranş.Text == "")
            {
                MessageBox.Show("Branş Boş Geçilemez");
                return;
            }
            if (cmbVardiya.Text == "")
            {
                MessageBox.Show("Vardiya Boş Geçilemez");
            }
             if (mevcutYıl - doğum < 24)
            {
                MessageBox.Show("Yaş 24 den Küçük Olamaz");
                return;
            }

            if (txtTc.Text.Length != 11)
            {
                MessageBox.Show("Hatalı Tc");
                tcOk = false;
                return;
            }
            if (tcOk == true)
            {
                foreach (var item in Form1.hemşireler)
                {
                    if (item.Tc == tc)
                    {
                        MessageBox.Show("Hemşire Zaten Mevcut");
                        return;
                    }
                }
            }

            Nurses hemşire = new Nurses(ad, tc)
            {
                Adı = ad,
                Tc = tc,
                Doğum = doğumTarihi,
                Branş = branş,
                Cinsiyet = cinsiyet,
                Vardiya = vardiya


            };
            Form1.hemşireler.Add(hemşire);
            Form1.insan.Add(hemşire);

            MessageBox.Show("Hemşire Eklendi");
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTc.Text = "";
            cmbbranş.SelectedItem = null;
            cmbCinsiyet.SelectedItem = null;
            cmbVardiya.SelectedItem = null;
            



        }

    }

}
