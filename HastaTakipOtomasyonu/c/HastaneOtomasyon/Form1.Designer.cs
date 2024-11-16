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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnHastaEkle
            // 
            btnHastaEkle.BackColor = SystemColors.ActiveCaption;
            btnHastaEkle.Location = new Point(28, 337);
            btnHastaEkle.Margin = new Padding(3, 2, 3, 2);
            btnHastaEkle.Name = "btnHastaEkle";
            btnHastaEkle.Size = new Size(141, 36);
            btnHastaEkle.TabIndex = 1;
            btnHastaEkle.Text = "Hasta Ekle";
            btnHastaEkle.UseVisualStyleBackColor = false;
            btnHastaEkle.Click += btnHastaEkle_Click;
            // 
            // btnHastaListesi
            // 
            btnHastaListesi.BackColor = SystemColors.ActiveCaption;
            btnHastaListesi.Location = new Point(200, 337);
            btnHastaListesi.Margin = new Padding(3, 2, 3, 2);
            btnHastaListesi.Name = "btnHastaListesi";
            btnHastaListesi.Size = new Size(141, 36);
            btnHastaListesi.TabIndex = 2;
            btnHastaListesi.Text = "Hasta Listesi";
            btnHastaListesi.UseVisualStyleBackColor = false;
            btnHastaListesi.Click += btnHastaListesi_Click;
            // 
            // btnHemsireListele
            // 
            btnHemsireListele.BackColor = Color.LightCoral;
            btnHemsireListele.Location = new Point(200, 397);
            btnHemsireListele.Margin = new Padding(3, 2, 3, 2);
            btnHemsireListele.Name = "btnHemsireListele";
            btnHemsireListele.Size = new Size(141, 36);
            btnHemsireListele.TabIndex = 4;
            btnHemsireListele.Text = "Hemşire Listesi";
            btnHemsireListele.UseVisualStyleBackColor = false;
            btnHemsireListele.Click += btnHemsireListele_Click;
            // 
            // btnHemsire
            // 
            btnHemsire.BackColor = Color.LightCoral;
            btnHemsire.Location = new Point(28, 397);
            btnHemsire.Margin = new Padding(3, 2, 3, 2);
            btnHemsire.Name = "btnHemsire";
            btnHemsire.Size = new Size(141, 36);
            btnHemsire.TabIndex = 3;
            btnHemsire.Text = "Hemşire Ekle";
            btnHemsire.UseVisualStyleBackColor = false;
            btnHemsire.Click += btnHemsire_Click;
            // 
            // btnDoktorListele
            // 
            btnDoktorListele.BackColor = Color.MediumSeaGreen;
            btnDoktorListele.Location = new Point(200, 459);
            btnDoktorListele.Margin = new Padding(3, 2, 3, 2);
            btnDoktorListele.Name = "btnDoktorListele";
            btnDoktorListele.Size = new Size(141, 36);
            btnDoktorListele.TabIndex = 6;
            btnDoktorListele.Text = "Doktor Listesi";
            btnDoktorListele.UseVisualStyleBackColor = false;
            btnDoktorListele.Click += btnDoktorListele_Click;
            // 
            // btnDoktorEkle
            // 
            btnDoktorEkle.BackColor = Color.MediumSeaGreen;
            btnDoktorEkle.Location = new Point(28, 459);
            btnDoktorEkle.Margin = new Padding(3, 2, 3, 2);
            btnDoktorEkle.Name = "btnDoktorEkle";
            btnDoktorEkle.Size = new Size(141, 36);
            btnDoktorEkle.TabIndex = 5;
            btnDoktorEkle.Text = "Doktor Ekle";
            btnDoktorEkle.UseVisualStyleBackColor = false;
            btnDoktorEkle.Click += btnDoktorEkle_Click;
            // 
            // btnKbbGetir
            // 
            btnKbbGetir.Location = new Point(557, 344);
            btnKbbGetir.Margin = new Padding(3, 2, 3, 2);
            btnKbbGetir.Name = "btnKbbGetir";
            btnKbbGetir.Size = new Size(141, 36);
            btnKbbGetir.TabIndex = 7;
            btnKbbGetir.Text = "isme göre kbb doktorlarını sırala";
            btnKbbGetir.UseVisualStyleBackColor = true;
            // 
            // btnYasliHasta
            // 
            btnYasliHasta.Location = new Point(557, 296);
            btnYasliHasta.Margin = new Padding(3, 2, 3, 2);
            btnYasliHasta.Name = "btnYasliHasta";
            btnYasliHasta.Size = new Size(141, 36);
            btnYasliHasta.TabIndex = 8;
            btnYasliHasta.Text = "en yaslı hastayı getir";
            btnYasliHasta.UseVisualStyleBackColor = true;
            // 
            // btnYuksekMaaslıDoktor
            // 
            btnYuksekMaaslıDoktor.Location = new Point(557, 244);
            btnYuksekMaaslıDoktor.Margin = new Padding(3, 2, 3, 2);
            btnYuksekMaaslıDoktor.Name = "btnYuksekMaaslıDoktor";
            btnYuksekMaaslıDoktor.Size = new Size(141, 36);
            btnYuksekMaaslıDoktor.TabIndex = 9;
            btnYuksekMaaslıDoktor.Text = "en yüksek maaslı doktoru getir";
            btnYuksekMaaslıDoktor.UseVisualStyleBackColor = true;
            // 
            // btnFilterDoktor
            // 
            btnFilterDoktor.Location = new Point(557, 432);
            btnFilterDoktor.Margin = new Padding(3, 2, 3, 2);
            btnFilterDoktor.Name = "btnFilterDoktor";
            btnFilterDoktor.Size = new Size(141, 36);
            btnFilterDoktor.TabIndex = 10;
            btnFilterDoktor.Text = "Doktorları isme göre filtrele";
            btnFilterDoktor.UseVisualStyleBackColor = true;
            // 
            // btnFilteDoktorMaas
            // 
            btnFilteDoktorMaas.Location = new Point(557, 486);
            btnFilteDoktorMaas.Margin = new Padding(3, 2, 3, 2);
            btnFilteDoktorMaas.Name = "btnFilteDoktorMaas";
            btnFilteDoktorMaas.Size = new Size(141, 36);
            btnFilteDoktorMaas.TabIndex = 11;
            btnFilteDoktorMaas.Text = "Doktorları maasına göre filtrele";
            btnFilteDoktorMaas.UseVisualStyleBackColor = true;
            // 
            // txtFiltre
            // 
            txtFiltre.Location = new Point(557, 398);
            txtFiltre.Margin = new Padding(3, 2, 3, 2);
            txtFiltre.Name = "txtFiltre";
            txtFiltre.Size = new Size(141, 23);
            txtFiltre.TabIndex = 12;
            // 
            // btnHemsireAta
            // 
            btnHemsireAta.BackColor = Color.LightCoral;
            btnHemsireAta.Location = new Point(362, 397);
            btnHemsireAta.Margin = new Padding(3, 2, 3, 2);
            btnHemsireAta.Name = "btnHemsireAta";
            btnHemsireAta.Size = new Size(123, 36);
            btnHemsireAta.TabIndex = 13;
            btnHemsireAta.Text = "Hemşire Ata";
            btnHemsireAta.UseVisualStyleBackColor = false;
            // 
            // btnHastaRandevu
            // 
            btnHastaRandevu.BackColor = SystemColors.ActiveCaption;
            btnHastaRandevu.Location = new Point(362, 337);
            btnHastaRandevu.Margin = new Padding(3, 2, 3, 2);
            btnHastaRandevu.Name = "btnHastaRandevu";
            btnHastaRandevu.Size = new Size(123, 36);
            btnHastaRandevu.TabIndex = 14;
            btnHastaRandevu.Text = "HastaRandevu";
            btnHastaRandevu.UseVisualStyleBackColor = false;
            btnHastaRandevu.Click += btnHastaRandevu_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 239);
            dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(734, 529);
            Controls.Add(dataGridView1);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}
