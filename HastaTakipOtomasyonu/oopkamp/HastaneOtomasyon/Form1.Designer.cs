namespace HastaneOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsvKisiler = new ListView();
            btnHastaEkle = new Button();
            btnHastaListesi = new Button();
            btnHemsireListele = new Button();
            btnHemsire = new Button();
            btnDoktorListele = new Button();
            btnDoktorEkle = new Button();
            btnKbbGetir = new Button();
            btnYasliHasta = new Button();
            btnYuksekMaaslıDoktor = new Button();
            btnFilterDoktor = new Button();
            btnFilteDoktorMaas = new Button();
            txtFiltre = new TextBox();
            btnHemsireAta = new Button();
            btnHastaRandevu = new Button();
            SuspendLayout();
            // 
            // lsvKisiler
            // 
            lsvKisiler.Activation = ItemActivation.OneClick;
            lsvKisiler.CheckBoxes = true;
            lsvKisiler.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lsvKisiler.GridLines = true;
            lsvKisiler.Location = new Point(12, 22);
            lsvKisiler.Name = "lsvKisiler";
            lsvKisiler.Size = new Size(815, 249);
            lsvKisiler.TabIndex = 0;
            lsvKisiler.UseCompatibleStateImageBehavior = false;
            lsvKisiler.View = View.Details;
            // 
            // btnHastaEkle
            // 
            btnHastaEkle.BackColor = SystemColors.ActiveCaption;
            btnHastaEkle.Location = new Point(32, 304);
            btnHastaEkle.Name = "btnHastaEkle";
            btnHastaEkle.Size = new Size(161, 48);
            btnHastaEkle.TabIndex = 1;
            btnHastaEkle.Text = "Hasta Ekle";
            btnHastaEkle.UseVisualStyleBackColor = false;
            btnHastaEkle.Click += btnHastaEkle_Click;
            // 
            // btnHastaListesi
            // 
            btnHastaListesi.BackColor = SystemColors.ActiveCaption;
            btnHastaListesi.Location = new Point(228, 304);
            btnHastaListesi.Name = "btnHastaListesi";
            btnHastaListesi.Size = new Size(161, 48);
            btnHastaListesi.TabIndex = 2;
            btnHastaListesi.Text = "Hasta Listesi";
            btnHastaListesi.UseVisualStyleBackColor = false;
            btnHastaListesi.Click += btnHastaListesi_Click;
            // 
            // btnHemsireListele
            // 
            btnHemsireListele.BackColor = Color.LightCoral;
            btnHemsireListele.Location = new Point(228, 384);
            btnHemsireListele.Name = "btnHemsireListele";
            btnHemsireListele.Size = new Size(161, 48);
            btnHemsireListele.TabIndex = 4;
            btnHemsireListele.Text = "Hemşire Listesi";
            btnHemsireListele.UseVisualStyleBackColor = false;
            btnHemsireListele.Click += btnHemsireListele_Click;
            // 
            // btnHemsire
            // 
            btnHemsire.BackColor = Color.LightCoral;
            btnHemsire.Location = new Point(32, 384);
            btnHemsire.Name = "btnHemsire";
            btnHemsire.Size = new Size(161, 48);
            btnHemsire.TabIndex = 3;
            btnHemsire.Text = "Hemşire Ekle";
            btnHemsire.UseVisualStyleBackColor = false;
            btnHemsire.Click += btnHemsire_Click;
            // 
            // btnDoktorListele
            // 
            btnDoktorListele.BackColor = Color.MediumSeaGreen;
            btnDoktorListele.Location = new Point(228, 466);
            btnDoktorListele.Name = "btnDoktorListele";
            btnDoktorListele.Size = new Size(161, 48);
            btnDoktorListele.TabIndex = 6;
            btnDoktorListele.Text = "Doktor Listesi";
            btnDoktorListele.UseVisualStyleBackColor = false;
            btnDoktorListele.Click += btnDoktorListele_Click;
            // 
            // btnDoktorEkle
            // 
            btnDoktorEkle.BackColor = Color.MediumSeaGreen;
            btnDoktorEkle.Location = new Point(32, 466);
            btnDoktorEkle.Name = "btnDoktorEkle";
            btnDoktorEkle.Size = new Size(161, 48);
            btnDoktorEkle.TabIndex = 5;
            btnDoktorEkle.Text = "Doktor Ekle";
            btnDoktorEkle.UseVisualStyleBackColor = false;
            btnDoktorEkle.Click += btnDoktorEkle_Click;
            // 
            // btnKbbGetir
            // 
            btnKbbGetir.Location = new Point(651, 437);
            btnKbbGetir.Name = "btnKbbGetir";
            btnKbbGetir.Size = new Size(161, 48);
            btnKbbGetir.TabIndex = 7;
            btnKbbGetir.Text = "isme göre kbb doktorlarını sırala";
            btnKbbGetir.UseVisualStyleBackColor = true;
            btnKbbGetir.Click += btnKbbGetir_Click;
            // 
            // btnYasliHasta
            // 
            btnYasliHasta.Location = new Point(651, 373);
            btnYasliHasta.Name = "btnYasliHasta";
            btnYasliHasta.Size = new Size(161, 48);
            btnYasliHasta.TabIndex = 8;
            btnYasliHasta.Text = "en yaslı hastayı getir";
            btnYasliHasta.UseVisualStyleBackColor = true;
            btnYasliHasta.Click += btnYasliHasta_Click;
            // 
            // btnYuksekMaaslıDoktor
            // 
            btnYuksekMaaslıDoktor.Location = new Point(651, 304);
            btnYuksekMaaslıDoktor.Name = "btnYuksekMaaslıDoktor";
            btnYuksekMaaslıDoktor.Size = new Size(161, 48);
            btnYuksekMaaslıDoktor.TabIndex = 9;
            btnYuksekMaaslıDoktor.Text = "en yüksek maaslı doktoru getir";
            btnYuksekMaaslıDoktor.UseVisualStyleBackColor = true;
            btnYuksekMaaslıDoktor.Click += btnYuksekMaaslıDoktor_Click;
            // 
            // btnFilterDoktor
            // 
            btnFilterDoktor.Location = new Point(651, 555);
            btnFilterDoktor.Name = "btnFilterDoktor";
            btnFilterDoktor.Size = new Size(161, 48);
            btnFilterDoktor.TabIndex = 10;
            btnFilterDoktor.Text = "Doktorları isme göre filtrele";
            btnFilterDoktor.UseVisualStyleBackColor = true;
            btnFilterDoktor.Click += btnFilterDoktor_Click;
            // 
            // btnFilteDoktorMaas
            // 
            btnFilteDoktorMaas.Location = new Point(651, 627);
            btnFilteDoktorMaas.Name = "btnFilteDoktorMaas";
            btnFilteDoktorMaas.Size = new Size(161, 48);
            btnFilteDoktorMaas.TabIndex = 11;
            btnFilteDoktorMaas.Text = "Doktorları maasına göre filtrele";
            btnFilteDoktorMaas.UseVisualStyleBackColor = true;
            btnFilteDoktorMaas.Click += btnFilteDoktorMaas_Click;
            // 
            // txtFiltre
            // 
            txtFiltre.Location = new Point(651, 510);
            txtFiltre.Name = "txtFiltre";
            txtFiltre.Size = new Size(161, 27);
            txtFiltre.TabIndex = 12;
            // 
            // btnHemsireAta
            // 
            btnHemsireAta.BackColor = Color.LightCoral;
            btnHemsireAta.Location = new Point(414, 384);
            btnHemsireAta.Name = "btnHemsireAta";
            btnHemsireAta.Size = new Size(141, 48);
            btnHemsireAta.TabIndex = 13;
            btnHemsireAta.Text = "Hemşire Ata";
            btnHemsireAta.UseVisualStyleBackColor = false;
            btnHemsireAta.Click += btnHemsireAta_Click;
            // 
            // btnHastaRandevu
            // 
            btnHastaRandevu.BackColor = SystemColors.ActiveCaption;
            btnHastaRandevu.Location = new Point(414, 304);
            btnHastaRandevu.Name = "btnHastaRandevu";
            btnHastaRandevu.Size = new Size(141, 48);
            btnHastaRandevu.TabIndex = 14;
            btnHastaRandevu.Text = "HastaRandevu";
            btnHastaRandevu.UseVisualStyleBackColor = false;
            btnHastaRandevu.Click += btnHastaRandevu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(839, 705);
            Controls.Add(btnHastaRandevu);
            Controls.Add(btnHemsireAta);
            Controls.Add(txtFiltre);
            Controls.Add(btnFilteDoktorMaas);
            Controls.Add(btnFilterDoktor);
            Controls.Add(btnYuksekMaaslıDoktor);
            Controls.Add(btnYasliHasta);
            Controls.Add(btnKbbGetir);
            Controls.Add(btnDoktorListele);
            Controls.Add(btnDoktorEkle);
            Controls.Add(btnHemsireListele);
            Controls.Add(btnHemsire);
            Controls.Add(btnHastaListesi);
            Controls.Add(btnHastaEkle);
            Controls.Add(lsvKisiler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnHastaEkle;
        private Button btnHastaListesi;
        private Button btnHemsireListele;
        private Button btnHemsire;
        private Button btnDoktorListele;
        private Button btnDoktorEkle;
        private Button btnKbbGetir;
        private Button btnYasliHasta;
        private Button btnYuksekMaaslıDoktor;
        private Button btnFilterDoktor;
        private Button btnFilteDoktorMaas;
        private TextBox txtFiltre;
        private Button btnHemsireAta;
        private Button btnHastaRandevu;
        public ListView lsvKisiler;
    }
}
