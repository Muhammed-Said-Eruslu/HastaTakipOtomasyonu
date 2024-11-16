using HastaneOtomasyon.Elemanlar;
using HastaneOtomasyon.Elemanlar.DoktorTipleri;
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
    public partial class DoktorEkleFormu : Form
    {
        public DoktorEkleFormu()
        {
            InitializeComponent();
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text + " " + txtSoyad.Text,
            tc = txtTc.Text, cinsiyet = cmbCinsiyet.Text ,unvan = txtUnvan.Text,
            branş = cmbbranş.Text;
            int günlükHasta=0, aylıkNöbet=0, maaş=0;
            bool tcOk = true;

            try
            {
                 
                 günlükHasta = Convert.ToInt32(txtHastaSayısı.Text);
                 aylıkNöbet = Convert.ToInt32(txtNobetSayısı.Text);
                
                 maaş = Convert.ToInt32(txtMaas.Text);
               
                
            }
            catch (Exception)
            {

                MessageBox.Show("Kutucuklar Boş Bırakılamaz");
                return;
            }
           

            int mevcutYıl = DateTime.Now.Year;
            int doğum = dateTimePicker1.Value.Year;

            if (txtAd.Text == "")
            {
                MessageBox.Show("Ad Boş Geçilemez");
                return;

            }
            if (txtSoyad.Text == "")
            {
                MessageBox.Show("Soyad Boş Geçilemez");
                return;
            }

            if (txtTc.Text == "")
            {
                MessageBox.Show("Tc Boş Geçilemez");
                return;
            }
            if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Cinsiyet Boş Geçilemez");
                return;
            }
            if (txtTc.Text.Length == 11)
            {
                bool tcMi = int.TryParse(txtTc.Text, out int tc1);
                if (tcMi == true)
                {
                    MessageBox.Show("Hatalı Tc");
                    tcOk = false;
                    return;
                }
            }
            if (mevcutYıl - doğum < 18)
            {
                MessageBox.Show("Yaş 18den Küçük Olamaz");
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

            if (cmbbranş.Text == "")
            {
                MessageBox.Show("Branş Boş Geçilemez");
                return;
            }
            if (txtMaas.Text == "")
            {
                MessageBox.Show("Maaş Boş Geçilemez");
                return;

            }
            else
            {
                if (maaş < 20000)
                {
                    maaş = 25000;
                }
            }
            if (txtHastaSayısı.Text == "")
            {
                MessageBox.Show("Hasta Sayısı Boş Geçilemez");
                return;
            }
            else
            {
                if (günlükHasta > 40)
                {
                    MessageBox.Show("Günlük Hasta Sayısı 40 Geçemez");
                    return;
                }
            }
            if (txtUnvan.Text == "")
            {
                MessageBox.Show("Ünvan Boş Geçilemez");
                return;
            }
            if (txtNobetSayısı.Text == "")
            {
                MessageBox.Show("Nöbet Sayısı Boş Geçilemez");
                return;
            }
            else
            {
                if (aylıkNöbet > 5)
                {
                    MessageBox.Show("Aylık Nöbet 5 i geçemez");
                    return;
                }
            }

            foreach (var item in Form1.doktors)
            {
                if (tc == item.Tc)
                {
                    MessageBox.Show("Doktor Zaten Mevcut");
                    return;
                }

            }




            if (branş == ItemsEnums.Cocuk.ToString())
            {
                Cocuk çocuk = new Cocuk(ad, tc)
                {
                    AylıkNöbet = aylıkNöbet,
                    Branş = branş,
                    Cinsiyet = cinsiyet,
                    Doğum = dateTimePicker1.Value,
                    GünlükHasta = günlükHasta,
                    Maaş = maaş,
                    Tc = tc,
                    Ünvan = unvan,
                    Hemşeriler = new List<string>(),
                    Randevular = new List<string>()
                };

                Form1.doktors.Add(çocuk);
                Form1.maaş.Add(çocuk.Maaş);
                Form1.insan.Add(çocuk);
              
            }
            if (branş == ItemsEnums.Ortopedi.ToString())
            {
                Ortopedi ortopedi = new Ortopedi(ad, tc)
                {
                    AylıkNöbet = aylıkNöbet,
                    Branş = branş,
                    Cinsiyet = cinsiyet,
                    Doğum = dateTimePicker1.Value,
                    GünlükHasta = günlükHasta,
                    Maaş = maaş,
                    Tc = tc,
                    Ünvan = unvan,
                    Hemşeriler = new List<string>(),
                    Randevular = new List<string>()

                };
                Form1.doktors.Add(ortopedi);
                Form1.maaş.Add(ortopedi.Maaş);
                Form1.insan.Add(ortopedi);
               

            }
            if (branş == ItemsEnums.Psikiyatri.ToString())
            {
                Psikiyatri psikiyatri=new Psikiyatri(ad, tc)
                {
                    AylıkNöbet = aylıkNöbet,
                    Branş = branş,
                    Cinsiyet = cinsiyet,
                    Doğum = dateTimePicker1.Value,
                    GünlükHasta = günlükHasta,
                    Maaş = maaş,
                    Tc = tc,
                    Ünvan = unvan,
                    Hemşeriler = new List<string>(),
                    Randevular = new List<string>()

                };
                Form1.doktors.Add(psikiyatri);
                Form1.maaş.Add(psikiyatri.Maaş);
                Form1.insan.Add(psikiyatri);
               

            }
            if (branş == ItemsEnums.Dahiliye.ToString())
            {
                Dahiliye dahiliye = new Dahiliye(ad, tc)
                {
                    AylıkNöbet = aylıkNöbet,
                    Branş = branş,
                    Cinsiyet = cinsiyet,
                    Doğum = dateTimePicker1.Value,
                    GünlükHasta = günlükHasta,
                    Maaş = maaş,
                    Tc = tc,
                    Ünvan = unvan,
                    Hemşeriler = new List<string>(),
                    Randevular = new List<string>()

                };
                Form1.doktors.Add(dahiliye);
                Form1.maaş.Add(dahiliye.Maaş);
                Form1.insan.Add(dahiliye);
               

            }
            if (branş == ItemsEnums.Dermatoloji.ToString())
            {
                Dermatoloji dermatoloji = new Dermatoloji(ad, tc)
                {
                    AylıkNöbet = aylıkNöbet,
                    Branş = branş,
                    Cinsiyet = cinsiyet,
                    Doğum = dateTimePicker1.Value,
                    GünlükHasta = günlükHasta,
                    Maaş = maaş,
                    Tc = tc,
                    Ünvan = unvan,
                    Hemşeriler = new List<string>(),
                    Randevular = new List<string>()

                };
                Form1.doktors.Add(dermatoloji);
                Form1.maaş.Add(dermatoloji.Maaş);
                Form1.insan.Add(dermatoloji);
               

            }
            if (branş == ItemsEnums.Enfeksiyon.ToString())
            {
                Enfeksiyon enfeksiyon = new Enfeksiyon(ad, tc)
                {
                    AylıkNöbet = aylıkNöbet,
                    Branş = branş,
                    Cinsiyet = cinsiyet,
                    Doğum = dateTimePicker1.Value,
                    GünlükHasta = günlükHasta,
                    Maaş = maaş,
                    Tc = tc,
                    Ünvan = unvan,
                    Hemşeriler = new List<string>(),
                    Randevular = new List<string>()

                };
                Form1.doktors.Add(enfeksiyon);
                Form1.maaş.Add(enfeksiyon.Maaş);
                Form1.insan.Add(enfeksiyon);
               

            }
            if (branş == ItemsEnums.KBB.ToString())
            {
                KBB kbb = new KBB(ad, tc)
                {
                    AylıkNöbet = aylıkNöbet,
                    Branş = branş,
                    Cinsiyet = cinsiyet,
                    Doğum = dateTimePicker1.Value,
                    GünlükHasta = günlükHasta,
                    Maaş = maaş,
                    Tc = tc,
                    Ünvan = unvan,
                    Hemşeriler = new List<string>(),
                    Randevular = new List<string>()


                };
                Form1.doktors.Add(kbb);
                Form1.maaş.Add(kbb.Maaş);
                Form1.insan.Add(kbb);
                Form1.kbb.Add(kbb.Adı);
               
            }
            MessageBox.Show("Doktor Eklendi");
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTc.Text = "";
            txtHastaSayısı.Text = "";
            txtMaas.Text = "";
            txtNobetSayısı.Text = "";
            txtUnvan.Text = "";
            cmbbranş.SelectedItem = null;
            cmbCinsiyet.SelectedItem = null;
            

        }

        private void DoktorEkleFormu_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.Add(ItemsEnums.Erkek);
            cmbCinsiyet.Items.Add(ItemsEnums.Kadın);

            cmbbranş.Items.Add(ItemsEnums.Dahiliye);
            cmbbranş.Items.Add(ItemsEnums.Enfeksiyon);
            cmbbranş.Items.Add(ItemsEnums.Cocuk);
            cmbbranş.Items.Add(ItemsEnums.Ortopedi);
            cmbbranş.Items.Add(ItemsEnums.Dermatoloji);
            cmbbranş.Items.Add(ItemsEnums.Dahiliye);
            cmbbranş.Items.Add(ItemsEnums.KBB);
        }
    }
}
