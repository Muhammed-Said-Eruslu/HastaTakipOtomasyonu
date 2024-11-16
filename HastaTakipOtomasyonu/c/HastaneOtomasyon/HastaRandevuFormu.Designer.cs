namespace HastaneOtomasyon
{
    partial class HastaRandevuFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEkle = new Button();
            grpBranch = new GroupBox();
            rdbKBB = new RadioButton();
            rdbCocuk = new RadioButton();
            rdbEnfeksiyon = new RadioButton();
            rdbDermatoloji = new RadioButton();
            rdbDahiliye = new RadioButton();
            rdbPsikiyatri = new RadioButton();
            rdbOrtopedi = new RadioButton();
            txtTc = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            txtArama = new TextBox();
            label4 = new Label();
            btnAra = new Button();
            grpKisi = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            lstDoktorlar = new ListBox();
            grpBranch.SuspendLayout();
            grpKisi.SuspendLayout();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(422, 380);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(444, 51);
            btnEkle.TabIndex = 69;
            btnEkle.Text = "Randevu Oluştur";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // grpBranch
            // 
            grpBranch.Controls.Add(rdbKBB);
            grpBranch.Controls.Add(rdbCocuk);
            grpBranch.Controls.Add(rdbEnfeksiyon);
            grpBranch.Controls.Add(rdbDermatoloji);
            grpBranch.Controls.Add(rdbDahiliye);
            grpBranch.Controls.Add(rdbPsikiyatri);
            grpBranch.Controls.Add(rdbOrtopedi);
            grpBranch.Location = new Point(422, 43);
            grpBranch.Margin = new Padding(3, 2, 3, 2);
            grpBranch.Name = "grpBranch";
            grpBranch.Padding = new Padding(3, 2, 3, 2);
            grpBranch.Size = new Size(208, 286);
            grpBranch.TabIndex = 68;
            grpBranch.TabStop = false;
            grpBranch.Text = "Randevu Almak İstediği Bolum";
            // 
            // rdbKBB
            // 
            rdbKBB.AutoSize = true;
            rdbKBB.Location = new Point(29, 225);
            rdbKBB.Margin = new Padding(3, 2, 3, 2);
            rdbKBB.Name = "rdbKBB";
            rdbKBB.Size = new Size(46, 19);
            rdbKBB.TabIndex = 6;
            rdbKBB.TabStop = true;
            rdbKBB.Text = "KBB";
            rdbKBB.UseVisualStyleBackColor = true;
            // 
            // rdbCocuk
            // 
            rdbCocuk.AutoSize = true;
            rdbCocuk.Location = new Point(29, 195);
            rdbCocuk.Margin = new Padding(3, 2, 3, 2);
            rdbCocuk.Name = "rdbCocuk";
            rdbCocuk.Size = new Size(59, 19);
            rdbCocuk.TabIndex = 5;
            rdbCocuk.TabStop = true;
            rdbCocuk.Text = "Cocuk";
            rdbCocuk.UseVisualStyleBackColor = true;
            // 
            // rdbEnfeksiyon
            // 
            rdbEnfeksiyon.AutoSize = true;
            rdbEnfeksiyon.Location = new Point(29, 164);
            rdbEnfeksiyon.Margin = new Padding(3, 2, 3, 2);
            rdbEnfeksiyon.Name = "rdbEnfeksiyon";
            rdbEnfeksiyon.Size = new Size(82, 19);
            rdbEnfeksiyon.TabIndex = 4;
            rdbEnfeksiyon.TabStop = true;
            rdbEnfeksiyon.Text = "Enfeksiyon";
            rdbEnfeksiyon.UseVisualStyleBackColor = true;
            // 
            // rdbDermatoloji
            // 
            rdbDermatoloji.AutoSize = true;
            rdbDermatoloji.Location = new Point(29, 134);
            rdbDermatoloji.Margin = new Padding(3, 2, 3, 2);
            rdbDermatoloji.Name = "rdbDermatoloji";
            rdbDermatoloji.Size = new Size(87, 19);
            rdbDermatoloji.TabIndex = 3;
            rdbDermatoloji.TabStop = true;
            rdbDermatoloji.Text = "Dermatoloji";
            rdbDermatoloji.UseVisualStyleBackColor = true;
            // 
            // rdbDahiliye
            // 
            rdbDahiliye.AutoSize = true;
            rdbDahiliye.Location = new Point(29, 106);
            rdbDahiliye.Margin = new Padding(3, 2, 3, 2);
            rdbDahiliye.Name = "rdbDahiliye";
            rdbDahiliye.Size = new Size(67, 19);
            rdbDahiliye.TabIndex = 2;
            rdbDahiliye.TabStop = true;
            rdbDahiliye.Text = "Dahiliye";
            rdbDahiliye.UseVisualStyleBackColor = true;
            // 
            // rdbPsikiyatri
            // 
            rdbPsikiyatri.AutoSize = true;
            rdbPsikiyatri.Location = new Point(29, 76);
            rdbPsikiyatri.Margin = new Padding(3, 2, 3, 2);
            rdbPsikiyatri.Name = "rdbPsikiyatri";
            rdbPsikiyatri.Size = new Size(72, 19);
            rdbPsikiyatri.TabIndex = 1;
            rdbPsikiyatri.TabStop = true;
            rdbPsikiyatri.Text = "Psikiyatri";
            rdbPsikiyatri.UseVisualStyleBackColor = true;
            // 
            // rdbOrtopedi
            // 
            rdbOrtopedi.AutoSize = true;
            rdbOrtopedi.Location = new Point(29, 44);
            rdbOrtopedi.Margin = new Padding(3, 2, 3, 2);
            rdbOrtopedi.Name = "rdbOrtopedi";
            rdbOrtopedi.Size = new Size(72, 19);
            rdbOrtopedi.TabIndex = 0;
            rdbOrtopedi.TabStop = true;
            rdbOrtopedi.Text = "Ortopedi";
            rdbOrtopedi.UseVisualStyleBackColor = true;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(145, 136);
            txtTc.Margin = new Padding(3, 2, 3, 2);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(189, 23);
            txtTc.TabIndex = 75;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 136);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 74;
            label3.Text = "TC :";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(145, 87);
            txtSoyad.Margin = new Padding(3, 2, 3, 2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(189, 23);
            txtSoyad.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 86);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 72;
            label2.Text = "SOYAD :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(145, 41);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(189, 23);
            txtAd.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 46);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 70;
            label1.Text = "AD :";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(192, 56);
            txtArama.Margin = new Padding(3, 2, 3, 2);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(189, 23);
            txtArama.TabIndex = 77;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 61);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 76;
            label4.Text = "TC  ARAMA :";
            // 
            // btnAra
            // 
            btnAra.Location = new Point(191, 99);
            btnAra.Margin = new Padding(3, 2, 3, 2);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(188, 39);
            btnAra.TabIndex = 78;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // grpKisi
            // 
            grpKisi.Controls.Add(dateTimePicker2);
            grpKisi.Controls.Add(label5);
            grpKisi.Controls.Add(txtAd);
            grpKisi.Controls.Add(label1);
            grpKisi.Controls.Add(label2);
            grpKisi.Controls.Add(txtSoyad);
            grpKisi.Controls.Add(txtTc);
            grpKisi.Controls.Add(label3);
            grpKisi.Location = new Point(24, 194);
            grpKisi.Margin = new Padding(3, 2, 3, 2);
            grpKisi.Name = "grpKisi";
            grpKisi.Padding = new Padding(3, 2, 3, 2);
            grpKisi.Size = new Size(355, 237);
            grpKisi.TabIndex = 79;
            grpKisi.TabStop = false;
            grpKisi.Text = "Hasta Bilgileri";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(167, 188);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(167, 23);
            dateTimePicker2.TabIndex = 78;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 191);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 77;
            label5.Text = "RANDEVU TALEP TARİHİ :";
            // 
            // lstDoktorlar
            // 
            lstDoktorlar.FormattingEnabled = true;
            lstDoktorlar.ItemHeight = 15;
            lstDoktorlar.Location = new Point(649, 56);
            lstDoktorlar.Margin = new Padding(3, 2, 3, 2);
            lstDoktorlar.Name = "lstDoktorlar";
            lstDoktorlar.Size = new Size(217, 274);
            lstDoktorlar.TabIndex = 80;
            // 
            // HastaRandevuFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 460);
            Controls.Add(lstDoktorlar);
            Controls.Add(grpKisi);
            Controls.Add(btnAra);
            Controls.Add(txtArama);
            Controls.Add(label4);
            Controls.Add(btnEkle);
            Controls.Add(grpBranch);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HastaRandevuFormu";
            Text = "HastaRandevuFormu";
            Load += HastaRandevuFormu_Load;
            grpBranch.ResumeLayout(false);
            grpBranch.PerformLayout();
            grpKisi.ResumeLayout(false);
            grpKisi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private GroupBox grpBranch;
        private RadioButton rdbKBB;
        private RadioButton rdbCocuk;
        private RadioButton rdbEnfeksiyon;
        private RadioButton rdbDermatoloji;
        private RadioButton rdbDahiliye;
        private RadioButton rdbPsikiyatri;
        private RadioButton rdbOrtopedi;
        private TextBox txtTc;
        private Label label3;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
        private TextBox txtArama;
        private Label label4;
        private Button btnAra;
        private GroupBox grpKisi;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private ListBox lstDoktorlar;
    }
}