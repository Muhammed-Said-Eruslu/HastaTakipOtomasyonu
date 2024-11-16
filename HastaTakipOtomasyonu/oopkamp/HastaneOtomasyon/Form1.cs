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
        public static List<Ýnsan> insan = new List<Ýnsan>();
        public static List<Hasta> hastalar = new List<Hasta>();
        public static List<Hemþire> hemþireler = new List<Hemþire>();
        public static List<Doctor> doktors = new List<Doctor>();
        public static List<int> maaþ = new List<int>();
        public static List<DateTime> doðum = new List<DateTime>();
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
            lsvKisiler.Columns.Add("Doðum Tarihi", 150);
            lsvKisiler.Columns.Add("Randevu Tarihi", 150);
            lsvKisiler.Columns.Add("Randevu Bölümü", 150);
            lsvKisiler.Columns.Add("Doktor", 150);

            lsvKisiler.Items.Clear();
            foreach (var hasta in hastalar)
            {


                ListViewItem item = new ListViewItem(hasta.Tc);
                item.SubItems.Add(hasta.Adý);
                item.SubItems.Add(hasta.Cinsiyet);
                item.SubItems.Add(hasta.Doðum.ToString());
                item.SubItems.Add(hasta.RandevuTarihi.ToString());
                item.SubItems.Add(hasta.RandevuBölümü);
                item.SubItems.Add(hasta.DoktorÝsmi);
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
            lsvKisiler.Columns.Add("Doðum Tarihi", 150);
            lsvKisiler.Columns.Add("Vardiya", 100);
            lsvKisiler.Columns.Add("Branþ", 100);

            foreach (var item in hemþireler)
            {


                ListViewItem ýtem = new ListViewItem(item.Tc);
                ýtem.SubItems.Add(item.Adý);
                ýtem.SubItems.Add(item.Cinsiyet);
                ýtem.SubItems.Add(item.Doðum.ToString());
                ýtem.SubItems.Add(item.Vardiya);
                ýtem.SubItems.Add(item.Branþ);
                lsvKisiler.Items.Add(ýtem);

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
            lsvKisiler.Columns.Add("Doðum Tarihi", 150);
            lsvKisiler.Columns.Add("Hasta Sayýsý", 100);
            lsvKisiler.Columns.Add("Nöbet Sayýsý", 100);
            lsvKisiler.Columns.Add("Maaþ", 100);
            lsvKisiler.Columns.Add("Ünvan", 100);
            lsvKisiler.Columns.Add("Branþ", 100);
            lsvKisiler.Columns.Add("Randevu Sayýsý", 100);
            foreach (var item in doktors)
            {
                ListViewItem listViewItem = new ListViewItem(item.Tc);
                listViewItem.SubItems.Add(item.Adý);
                listViewItem.SubItems.Add(item.Cinsiyet);
                listViewItem.SubItems.Add(item.Doðum.ToString());
                listViewItem.SubItems.Add(item.GünlükHasta.ToString());
                listViewItem.SubItems.Add(item.AylýkNöbet.ToString());
                listViewItem.SubItems.Add(item.Maaþ.ToString());
                listViewItem.SubItems.Add(item.Ünvan);
                listViewItem.SubItems.Add(item.Branþ);
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
            lsvKisiler.Columns.Add("Doðum Tarihi", 150);
            lsvKisiler.Columns.Add("Hasta Sayýsý", 100);
            lsvKisiler.Columns.Add("Nöbet Sayýsý", 100);
            lsvKisiler.Columns.Add("Maaþ", 100);
            lsvKisiler.Columns.Add("Ünvan", 100);
            lsvKisiler.Columns.Add("Branþ", 100);
            lsvKisiler.Columns.Add("Randevu Sayýsý", 100);
            string ad="", soyad="";

            try
            {
                if (doktors.Count > 0)
                {
                    var item = doktors.FirstOrDefault(x => x.Adý == txtFiltre.Text);
                   
                    if (!(item == null))
                    {
                        ListViewItem listViewItem = new ListViewItem(item.Tc);
                        listViewItem.SubItems.Add(item.Adý);
                        listViewItem.SubItems.Add(item.Cinsiyet);
                        listViewItem.SubItems.Add(item.Doðum.ToString());
                        listViewItem.SubItems.Add(item.GünlükHasta.ToString());
                        listViewItem.SubItems.Add(item.AylýkNöbet.ToString());
                        listViewItem.SubItems.Add(item.Maaþ.ToString());
                        listViewItem.SubItems.Add(item.Ünvan);
                        listViewItem.SubItems.Add(item.Branþ);
                        listViewItem.SubItems.Add(item.Randevular.Count.ToString());
                        lsvKisiler.Items.Add(listViewItem);
                    }

                   

                }
               
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Böyle Bir Doktor Yok");
                return;
            }
             







        }

        private void btnFilteDoktorMaas_Click(object sender, EventArgs e)
        {
            lsvKisiler.Clear();
            lsvKisiler.Columns.Add("Tc", 150);
            lsvKisiler.Columns.Add("Ad Soyad", 150);
            lsvKisiler.Columns.Add("Cinsiyet", 150);
            lsvKisiler.Columns.Add("Doðum Tarihi", 150);
            lsvKisiler.Columns.Add("Hasta Sayýsý", 100);
            lsvKisiler.Columns.Add("Nöbet Sayýsý", 100);
            lsvKisiler.Columns.Add("Maaþ", 100);
            lsvKisiler.Columns.Add("Ünvan", 100);
            lsvKisiler.Columns.Add("Branþ", 100);
            lsvKisiler.Columns.Add("Randevu Sayýsý", 100);

            if (doktors.Count > 0)
            {
                
                var item1 = doktors.FindAll(x => x.Maaþ == int.Parse(txtFiltre.Text));
                foreach (var item in item1)
                {
                    ListViewItem listViewItem = new ListViewItem(item.Tc);
                    listViewItem.SubItems.Add(item.Adý);
                    listViewItem.SubItems.Add(item.Cinsiyet);
                    listViewItem.SubItems.Add(item.Doðum.ToString());
                    listViewItem.SubItems.Add(item.GünlükHasta.ToString());
                    listViewItem.SubItems.Add(item.AylýkNöbet.ToString());
                    listViewItem.SubItems.Add(item.Maaþ.ToString());
                    listViewItem.SubItems.Add(item.Ünvan);
                    listViewItem.SubItems.Add(item.Branþ);
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
            lsvKisiler.Columns.Add("Doðum Tarihi", 150);
            lsvKisiler.Columns.Add("Hasta Sayýsý", 100);
            lsvKisiler.Columns.Add("Nöbet Sayýsý", 100);
            lsvKisiler.Columns.Add("Maaþ", 100);
            lsvKisiler.Columns.Add("Ünvan", 100);
            lsvKisiler.Columns.Add("Branþ", 100);
            lsvKisiler.Columns.Add("Randevu Sayýsý", 100);

            kbb.Sort();

            foreach (var item in kbb)
            {
                foreach (var item1 in doktors)
                {

                    if (item == item1.Adý)
                    {

                        ListViewItem listViewItem = new ListViewItem(item1.Tc);
                        listViewItem.SubItems.Add(item1.Adý);
                        listViewItem.SubItems.Add(item1.Cinsiyet);
                        listViewItem.SubItems.Add(item1.Doðum.ToString());
                        listViewItem.SubItems.Add(item1.GünlükHasta.ToString());
                        listViewItem.SubItems.Add(item1.AylýkNöbet.ToString());
                        listViewItem.SubItems.Add(item1.Maaþ.ToString());
                        listViewItem.SubItems.Add(item1.Ünvan);
                        listViewItem.SubItems.Add(item1.Branþ);
                        listViewItem.SubItems.Add(item1.Randevular.Count.ToString());
                        lsvKisiler.Items.Add(listViewItem);
                    }

                }

            }




        }

        private void btnYasliHasta_Click(object sender, EventArgs e)
        {
            DateTime doðumu = DateTime.Now;
            if (doðum.Count > 0)
            {
                doðumu = doðum.Min(x => x);

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
            lsvKisiler.Columns.Add("Doðum Tarihi", 150);
            lsvKisiler.Columns.Add("Randevu Tarihi", 150);
            lsvKisiler.Columns.Add("Randevu Bölümü", 150);
            lsvKisiler.Columns.Add("Doktor", 150);
            foreach (var hasta in hastalar)
            {
                if (hasta.Doðum == doðumu)
                {


                    ListViewItem item = new ListViewItem(hasta.Tc);
                    item.SubItems.Add(hasta.Adý);
                    item.SubItems.Add(hasta.Cinsiyet);
                    item.SubItems.Add(hasta.Doðum.ToString());
                    item.SubItems.Add(hasta.RandevuTarihi.ToString());
                    item.SubItems.Add(hasta.RandevuBölümü);
                    item.SubItems.Add(hasta.DoktorÝsmi);
                    lsvKisiler.Items.Add(item);

                }
            }




        }

        private void btnYuksekMaaslýDoktor_Click(object sender, EventArgs e)
        {

            lsvKisiler.Clear();
            lsvKisiler.Columns.Add("Tc", 150);
            lsvKisiler.Columns.Add("Ad Soyad", 150);
            lsvKisiler.Columns.Add("Cinsiyet", 150);
            lsvKisiler.Columns.Add("Doðum Tarihi", 150);
            lsvKisiler.Columns.Add("Hasta Sayýsý", 100);
            lsvKisiler.Columns.Add("Nöbet Sayýsý", 100);
            lsvKisiler.Columns.Add("Maaþ", 100);
            lsvKisiler.Columns.Add("Ünvan", 100);
            lsvKisiler.Columns.Add("Branþ", 100);
            lsvKisiler.Columns.Add("Randevu Sayýsý", 100);
            int maaþý = 0;
            if (maaþ.Count > 0)
            {
                maaþý = maaþ.Max(x => x);
            }
            else
            {
                MessageBox.Show("Ekli Doktor Yok");
                return;
            }



            foreach (var item in doktors)
            {
                if (item.Maaþ == maaþý)
                {
                    ListViewItem listViewItem = new ListViewItem(item.Tc);
                    listViewItem.SubItems.Add(item.Adý);
                    listViewItem.SubItems.Add(item.Cinsiyet);
                    listViewItem.SubItems.Add(item.Doðum.ToString());
                    listViewItem.SubItems.Add(item.GünlükHasta.ToString());
                    listViewItem.SubItems.Add(item.AylýkNöbet.ToString());
                    listViewItem.SubItems.Add(item.Maaþ.ToString());
                    listViewItem.SubItems.Add(item.Ünvan);
                    listViewItem.SubItems.Add(item.Branþ);
                    listViewItem.SubItems.Add(item.Randevular.Count.ToString());
                    lsvKisiler.Items.Add(listViewItem);

                }

            }











        }

    }


}







