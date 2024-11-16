namespace HastaneOtomasyon
{
    partial class DoktorEkleFormu
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
            groupBox1 = new GroupBox();
            rdbKBB = new RadioButton();
            rdbCocuk = new RadioButton();
            rdbEnfeksiyon = new RadioButton();
            rdbDermatoloji = new RadioButton();
            rdbDahiliye = new RadioButton();
            rdbPsikiyatri = new RadioButton();
            rdbOrtopedi = new RadioButton();
            label10 = new Label();
            txtMaas = new TextBox();
            label9 = new Label();
            cmbCinsiyet = new ComboBox();
            label8 = new Label();
            txtNobetSayısı = new TextBox();
            label6 = new Label();
            txtHastaSayısı = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtTc = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            cmbBrans = new ComboBox();
            cmbUnvan = new ComboBox();
            txtUnvan = new TextBox();
            label11 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(396, 360);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(217, 43);
            btnEkle.TabIndex = 47;
            btnEkle.Text = "Doktor Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbKBB);
            groupBox1.Controls.Add(rdbCocuk);
            groupBox1.Controls.Add(rdbEnfeksiyon);
            groupBox1.Controls.Add(rdbDermatoloji);
            groupBox1.Controls.Add(rdbDahiliye);
            groupBox1.Controls.Add(rdbPsikiyatri);
            groupBox1.Controls.Add(rdbOrtopedi);
            groupBox1.Location = new Point(396, 52);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(217, 286);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eklenecek Doktor Tipi";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 396);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 42;
            label10.Text = "ÜNVAN :";
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(186, 355);
            txtMaas.Margin = new Padding(3, 2, 3, 2);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(160, 23);
            txtMaas.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 360);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 40;
            label9.Text = "MAAŞ :";
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(186, 317);
            cmbCinsiyet.Margin = new Padding(3, 2, 3, 2);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(160, 23);
            cmbCinsiyet.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 317);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 38;
            label8.Text = "CİNSİYET :";
            // 
            // txtNobetSayısı
            // 
            txtNobetSayısı.Location = new Point(186, 274);
            txtNobetSayısı.Margin = new Padding(3, 2, 3, 2);
            txtNobetSayısı.Name = "txtNobetSayısı";
            txtNobetSayısı.Size = new Size(160, 23);
            txtNobetSayısı.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 279);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 34;
            label6.Text = "AYLIK NÖBET SAYISI :";
            // 
            // txtHastaSayısı
            // 
            txtHastaSayısı.Location = new Point(186, 235);
            txtHastaSayısı.Margin = new Padding(3, 2, 3, 2);
            txtHastaSayısı.Name = "txtHastaSayısı";
            txtHastaSayısı.Size = new Size(160, 23);
            txtHastaSayısı.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 240);
            label5.Name = "label5";
            label5.Size = new Size(133, 15);
            label5.TabIndex = 32;
            label5.Text = "GUNLUK HASTA SAYISI :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 190);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 30;
            label4.Text = "DOGUM TARİHİ :";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(186, 148);
            txtTc.Margin = new Padding(3, 2, 3, 2);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(160, 23);
            txtTc.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 148);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 28;
            label3.Text = "TC :";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(186, 98);
            txtSoyad.Margin = new Padding(3, 2, 3, 2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(160, 23);
            txtSoyad.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 98);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 26;
            label2.Text = "SOYAD :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(186, 52);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(160, 23);
            txtAd.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 52);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 24;
            label1.Text = "AD :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(186, 190);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(160, 23);
            dateTimePicker1.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 433);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 49;
            label7.Text = "BRANŞ :";
            // 
            // cmbBrans
            // 
            cmbBrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(186, 427);
            cmbBrans.Margin = new Padding(3, 2, 3, 2);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(160, 23);
            cmbBrans.TabIndex = 50;
            // 
            // cmbUnvan
            // 
            cmbUnvan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnvan.FormattingEnabled = true;
            cmbUnvan.Location = new Point(186, 473);
            cmbUnvan.Margin = new Padding(3, 2, 3, 2);
            cmbUnvan.Name = "cmbUnvan";
            cmbUnvan.Size = new Size(160, 23);
            cmbUnvan.TabIndex = 51;
            // 
            // txtUnvan
            // 
            txtUnvan.Location = new Point(186, 388);
            txtUnvan.Name = "txtUnvan";
            txtUnvan.Size = new Size(160, 23);
            txtUnvan.TabIndex = 52;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 476);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 53;
            label11.Text = "Bölümü";
            // 
            // DoktorEkleFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 517);
            Controls.Add(label11);
            Controls.Add(txtUnvan);
            Controls.Add(cmbUnvan);
            Controls.Add(cmbBrans);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnEkle);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(txtMaas);
            Controls.Add(label9);
            Controls.Add(cmbCinsiyet);
            Controls.Add(label8);
            Controls.Add(txtNobetSayısı);
            Controls.Add(label6);
            Controls.Add(txtHastaSayısı);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTc);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DoktorEkleFormu";
            Text = "DoktorEkleFormu";
            Load += DoktorEkleFormu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private GroupBox groupBox1;
        private RadioButton rdbPsikiyatri;
        private RadioButton rdbOrtopedi;
        private Label label10;
        private TextBox txtMaas;
        private Label label9;
        private ComboBox cmbCinsiyet;
        private Label label8;
        private TextBox txtNobetSayısı;
        private Label label6;
        private TextBox txtHastaSayısı;
        private Label label5;
        private Label label4;
        private TextBox txtTc;
        private Label label3;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
        private RadioButton rdbKBB;
        private RadioButton rdbCocuk;
        private RadioButton rdbEnfeksiyon;
        private RadioButton rdbDermatoloji;
        private RadioButton rdbDahiliye;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox cmbBrans;
        private ComboBox cmbUnvan;
        private TextBox txtUnvan;
        private Label label11;
    }
}