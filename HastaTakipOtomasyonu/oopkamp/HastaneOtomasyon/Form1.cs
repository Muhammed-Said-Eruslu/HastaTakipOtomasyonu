using HastaneOtomasyon.Elemanlar;
using HastaneOtomasyon.Elemanlar.DoktorTipleri;
using HastaneOtomasyon.Enumlar;
using System.CodeDom;
using System.Security.Policy;

namespace HastaneOtomasyon
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        public static List<�nsan> insan = new List<�nsan>();
        public static List<Hasta> hastalar = new List<Hasta>();
        public static List<Hem�ire> hem�ireler = new List<Hem�ire>();
        public static List<Doctor> doktors = new List<Doctor>();
        public static List<int> maa� = new List<int>();
        public static List<DateTime> do�um = new List<DateTime>();
        public static List<string> kbb = new List<string>();

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            HastaEkleFormu hastaEkleFormu = new HastaEkleFormu();
            hastaEkleFormu.Owner = form1;
            hastaEkleFormu.ShowDialog();





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsvKisiler.Scrollable = true;



        }



        private void btnHastaListesi_Click(object sender, EventArgs e)
        {
            lsvKisiler.Columns.Clear();
            lsvKisiler.Columns.Add("Tc", 150);
            lsvKisiler.Columns.Add("Ad Soyad", 150);
            lsvKisiler.Columns.Add("Cinsiyet", 150);
            lsvKisiler.Columns.Add("Do�um Tarihi", 150);
            lsvKisiler.Columns.Add("Randevu Tarihi", 150);
            lsvKisiler.Columns.Add("Randevu B�l�m�", 150);
            lsvKisiler.Columns.Add("Doktor", 150);

            lsvKisiler.Items.Clear();
            foreach (var hasta in hastalar)
            {


                ListViewItem item = new ListViewItem(hasta.Tc);
                item.SubItems.Add(hasta.Ad�);
                item.SubItems.Add(hasta.Cinsiyet);
                item.SubItems.Add(hasta.Do�um.ToString());
                item.SubItems.Add(hasta.RandevuTarihi.ToString());
                item.SubItems.Add(hasta.RandevuB�l�m�);
                item.SubItems.Add(hasta.Doktor�smi);
                lsvKisiler.Items.Add(item);

            }




        }



        private void btnHemsire_Click(object sender, EventArgs e)
        {
            HemsireEkleFormu hemsireEkleFormu = new HemsireEkleFormu();
            hemsireEkleFormu.ShowDialog();



        }

        private void btnHastaRandevu_Click(object sender, EventArgs e)
        {
            HastaRandevuFormu hastaRandevuFormu = new HastaRandevuFormu();
            hastaRandevuFormu.ShowDialog();
        }

        private void btnHemsireListele_Click(object sender, EventArgs e)
        {


            lsvKisiler.Clear();
            lsvKisiler.Columns.Add("Tc", 150);
            lsvKisiler.Columns.Add("Ad Soyad", 150);
            lsvKisiler.Columns.Add("Cinsiyet", 150);
            lsvKisiler.Columns.Add("Do�um Tarihi", 150);
            lsvKisiler.Columns.Add("Vardiya", 100);
            lsvKisiler.Columns.Add("Bran�", 100);

            foreach (var item in hem�ireler)
            {


                ListViewItem �tem = new ListViewItem(item.Tc);
                �tem.SubItems.Add(item.Ad�);
                �tem.SubItems.Add(item.Cinsiyet);
                �tem.SubItems.Add(item.Do�um.ToString());
                �tem.SubItems.Add(item.Vardiya);
                �tem.SubItems.Add(item.Bran�);
                lsvKisiler.Items.Add(�tem);

            }

        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {

            DoktorEkleFormu doktorEkleFormu = new DoktorEkleFormu();
            doktorEkleFormu.ShowDialog();


        }

        private void btnDoktorListele_Click(object sender, EventArgs e)
        {
            lsvKisiler.Clear();
            lsvKisiler.Columns.Add("Tc", 150);
            lsvKisiler.Columns.Add("Ad Soyad", 150);
            lsvKisiler.Columns.Add("Cinsiyet", 150);
            lsvKisiler.Columns.Add("Do�um Tarihi", 150);
            lsvKisiler.Columns.Add("Hasta Say�s�", 100);
            lsvKisiler.Columns.Add("N�bet Say�s�", 100);
            lsvKisiler.Columns.Add("Maa�", 100);
            lsvKisiler.Columns.Add("�nvan", 100);
            lsvKisiler.Columns.Add("Bran�", 100);
            lsvKisiler.Columns.Add("Randevu Say�s�", 100);
            foreach (var item in doktors)
            {
                ListViewItem listViewItem = new ListViewItem(item.Tc);
                listViewItem.SubItems.Add(item.Ad�);
                listViewItem.SubItems.Add(item.Cinsiyet);
                listViewItem.SubItems.Add(item.Do�um.ToString());
                listViewItem.SubItems.Add(item.G�nl�kHasta.ToString());
                listViewItem.SubItems.Add(item.Ayl�kN�bet.ToString());
                listViewItem.SubItems.Add(item.Maa�.ToString());
                listViewItem.SubItems.Add(item.�nvan);
                listViewItem.SubItems.Add(item.Bran�);
                listViewItem.SubItems.Add(item.Randevular.Count.ToString());
                lsvKisiler.Items.Add(listViewItem);

              

            }


        }

        private void btnHemsireAta_Click(object sender, EventArgs e)
        {
            HemsireAtamaFormu hemsireAtamaFormu = new HemsireAtamaFormu();
            hemsireAtamaFormu.ShowDialog();

        }

        private void btnFilterDoktor_Click(object sender, EventArgs e)
        {
            lsvKisiler.Clear();
            lsvKisiler.Columns.Add("Tc", 150);
            lsvKisiler.Columns.Add("Ad Soyad", 150);
            lsvKisiler.Columns.Add("Cinsiyet", 150);
            lsvKisiler.Columns.Add("Do�um Tarihi", 150);
            lsvKisiler.Columns.Add("Hasta Say�s�", 100);
            lsvKisiler.Columns.Add("N�bet Say�s�", 100);
            lsvKisiler.Columns.Add("Maa�", 100);
            lsvKisiler.Columns.Add("�nvan", 100);
            lsvKisiler.Columns.Add("Bran�", 100);
            lsvKisiler.Columns.Add("Randevu Say�s�", 100);
            string ad="", soyad="";

            try
            {
                if (doktors.Count > 0)
                {
                    var item = doktors.FirstOrDefault(x => x.Ad� == txtFiltre.Text);
                   
                    if (!(item == null))
                    {
                        ListViewItem listViewItem = new ListViewItem(item.Tc);
                        listViewItem.SubItems.Add(item.Ad�);
                        listViewItem.SubItems.Add(item.Cinsiyet);
                        listViewItem.SubItems.Add(item.Do�um.ToString());
                        listViewItem.SubItems.Add(item.G�nl�kHasta.ToString());
                        listViewItem.SubItems.Add(item.Ayl�kN�bet.ToString());
                        listViewItem.SubItems.Add(item.Maa�.ToString());
                        listViewItem.SubItems.Add(item.�nvan);
                        listViewItem.SubItems.Add(item.Bran�);
                        listViewItem.SubItems.Add(item.Randevular.Count.ToString());
                        lsvKisiler.Items.Add(listViewItem);
                    }

                   

                }
               
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("B�yle Bir Doktor Yok");
                return;
            }
             







        }

        private void btnFilteDoktorMaas_Click(object sender, EventArgs e)
        {
            lsvKisiler.Clear();
            lsvKisiler.Columns.Add("Tc", 150);
            lsvKisiler.Columns.Add("Ad Soyad", 150);
            lsvKisiler.Columns.Add("Cinsiyet", 150);
            lsvKisiler.Columns.Add("Do�um Tarihi", 150);
            lsvKisiler.Columns.Add("Hasta Say�s�", 100);
            lsvKisiler.Columns.Add("N�bet Say�s�", 100);
            lsvKisiler.Columns.Add("Maa�", 100);
            lsvKisiler.Columns.Add("�nvan", 100);
            lsvKisiler.Columns.Add("Bran�", 100);
            lsvKisiler.Columns.Add("Randevu Say�s�", 100);

            if (doktors.Count > 0)
            {
                
                var item1 = doktors.FindAll(x => x.Maa� == int.Parse(txtFiltre.Text));
                foreach (var item in item1)
                {
                    ListViewItem listViewItem = new ListViewItem(item.Tc);
                    listViewItem.SubItems.Add(item.Ad�);
                    listViewItem.SubItems.Add(item.Cinsiyet);
                    listViewItem.SubItems.Add(item.Do�um.ToString());
                    listViewItem.SubItems.Add(item.G�nl�kHasta.ToString());
                    listViewItem.SubItems.Add(item.Ayl�kN�bet.ToString());
                    listViewItem.SubItems.Add(item.Maa�.ToString());
                    listViewItem.SubItems.Add(item.�nvan);
                    listViewItem.SubItems.Add(item.Bran�);
                    listViewItem.SubItems.Add(item.Randevular.Count.ToString());
                    lsvKisiler.Items.Add(listViewItem);
                }
                
            }


        }

        private void btnKbbGetir_Click(object sender, EventArgs e)
        {
            lsvKisiler.Clear();

            lsvKisiler.Columns.Add("Tc", 150);
            lsvKisiler.Columns.Add("Ad Soyad", 150);
            lsvKisiler.Columns.Add("Cinsiyet", 150);
            lsvKisiler.Columns.Add("Do�um Tarihi", 150);
            lsvKisiler.Columns.Add("Hasta Say�s�", 100);
            lsvKisiler.Columns.Add("N�bet Say�s�", 100);
            lsvKisiler.Columns.Add("Maa�", 100);
            lsvKisiler.Columns.Add("�nvan", 100);
            lsvKisiler.Columns.Add("Bran�", 100);
            lsvKisiler.Columns.Add("Randevu Say�s�", 100);

            kbb.Sort();

            foreach (var item in kbb)
            {
                foreach (var item1 in doktors)
                {

                    if (item == item1.Ad�)
                    {

                        ListViewItem listViewItem = new ListViewItem(item1.Tc);
                        listViewItem.SubItems.Add(item1.Ad�);
                        listViewItem.SubItems.Add(item1.Cinsiyet);
                        listViewItem.SubItems.Add(item1.Do�um.ToString());
                        listViewItem.SubItems.Add(item1.G�nl�kHasta.ToString());
                        listViewItem.SubItems.Add(item1.Ayl�kN�bet.ToString());
                        listViewItem.SubItems.Add(item1.Maa�.ToString());
                        listViewItem.SubItems.Add(item1.�nvan);
                        listViewItem.SubItems.Add(item1.Bran�);
                        listViewItem.SubItems.Add(item1.Randevular.Count.ToString());
                        lsvKisiler.Items.Add(listViewItem);
                    }

                }

            }




        }

        private void btnYasliHasta_Click(object sender, EventArgs e)
        {
            DateTime do�umu = DateTime.Now;
            if (do�um.Count > 0)
            {
                do�umu = do�um.Min(x => x);

            }
            else
            {
                MessageBox.Show("Ekli Hasta Yok");
                return;
            }

            lsvKisiler.Clear();

            lsvKisiler.Columns.Add("Tc", 150);
            lsvKisiler.Columns.Add("Ad Soyad", 150);
            lsvKisiler.Columns.Add("Cinsiyet", 150);
            lsvKisiler.Columns.Add("Do�um Tarihi", 150);
            lsvKisiler.Columns.Add("Randevu Tarihi", 150);
            lsvKisiler.Columns.Add("Randevu B�l�m�", 150);
            lsvKisiler.Columns.Add("Doktor", 150);
            foreach (var hasta in hastalar)
            {
                if (hasta.Do�um == do�umu)
                {


                    ListViewItem item = new ListViewItem(hasta.Tc);
                    item.SubItems.Add(hasta.Ad�);
                    item.SubItems.Add(hasta.Cinsiyet);
                    item.SubItems.Add(hasta.Do�um.ToString());
                    item.SubItems.Add(hasta.RandevuTarihi.ToString());
                    item.SubItems.Add(hasta.RandevuB�l�m�);
                    item.SubItems.Add(hasta.Doktor�smi);
                    lsvKisiler.Items.Add(item);

                }
            }




        }

        private void btnYuksekMaasl�Doktor_Click(object sender, EventArgs e)
        {

            lsvKisiler.Clear();
            lsvKisiler.Columns.Add("Tc", 150);
            lsvKisiler.Columns.Add("Ad Soyad", 150);
            lsvKisiler.Columns.Add("Cinsiyet", 150);
            lsvKisiler.Columns.Add("Do�um Tarihi", 150);
            lsvKisiler.Columns.Add("Hasta Say�s�", 100);
            lsvKisiler.Columns.Add("N�bet Say�s�", 100);
            lsvKisiler.Columns.Add("Maa�", 100);
            lsvKisiler.Columns.Add("�nvan", 100);
            lsvKisiler.Columns.Add("Bran�", 100);
            lsvKisiler.Columns.Add("Randevu Say�s�", 100);
            int maa�� = 0;
            if (maa�.Count > 0)
            {
                maa�� = maa�.Max(x => x);
            }
            else
            {
                MessageBox.Show("Ekli Doktor Yok");
                return;
            }



            foreach (var item in doktors)
            {
                if (item.Maa� == maa��)
                {
                    ListViewItem listViewItem = new ListViewItem(item.Tc);
                    listViewItem.SubItems.Add(item.Ad�);
                    listViewItem.SubItems.Add(item.Cinsiyet);
                    listViewItem.SubItems.Add(item.Do�um.ToString());
                    listViewItem.SubItems.Add(item.G�nl�kHasta.ToString());
                    listViewItem.SubItems.Add(item.Ayl�kN�bet.ToString());
                    listViewItem.SubItems.Add(item.Maa�.ToString());
                    listViewItem.SubItems.Add(item.�nvan);
                    listViewItem.SubItems.Add(item.Bran�);
                    listViewItem.SubItems.Add(item.Randevular.Count.ToString());
                    lsvKisiler.Items.Add(listViewItem);

                }

            }











        }

    }


}







