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
    public partial class HemsireAtamaFormu : Form
    {
        public HemsireAtamaFormu()
        {
            InitializeComponent();
        }

        private void HemsireAtamaFormu_Load(object sender, EventArgs e)
        {
            foreach (var item in Form1.doktors)
            {

                cmbDoktorlar.Items.Add(item.Adı);

            }
        }


        
        private void btnAta_Click(object sender, EventArgs e)
        {
            string doktor = cmbDoktorlar.Text;
            string atanacakHemşire = "";
            atanacakHemşire = lstHemsireler.Text;
            if (atanacakHemşire != "")
            {
                foreach (var item in Form1.doktors)
                {
                    if (item.Adı == doktor)
                    {
                        item.Hemşeriler.Add(atanacakHemşire);
                        MessageBox.Show("Hemşire Atandı");
                       
                    }
                }

            }

        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string branş = "";

            string doktor = cmbDoktorlar.Text;

            foreach (var item in Form1.doktors)
            {
                if (item.Adı == doktor)
                {
                    branş = item.Branş;

                }

            }

            foreach (var item in Form1.hemşireler)
            {
                if (item.Branş == branş)
                {
                    lstHemsireler.Items.Add(item.Adı);
                }


            }

        }
    }
}
