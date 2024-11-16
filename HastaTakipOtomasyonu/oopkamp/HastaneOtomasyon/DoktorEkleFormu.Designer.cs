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
            txtUnvan = new TextBox();
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
            cmbbranş = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(453, 480);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(248, 57);
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
            groupBox1.Location = new Point(453, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 381);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eklenecek Doktor Tipi";
            // 
            // rdbKBB
            // 
            rdbKBB.AutoSize = true;
            rdbKBB.Location = new Point(33, 300);
            rdbKBB.Name = "rdbKBB";
            rdbKBB.Size = new Size(57, 24);
            rdbKBB.TabIndex = 6;
            rdbKBB.TabStop = true;
            rdbKBB.Text = "KBB";
            rdbKBB.UseVisualStyleBackColor = true;
            // 
            // rdbCocuk
            // 
            rdbCocuk.AutoSize = true;
            rdbCocuk.Location = new Point(33, 260);
            rdbCocuk.Name = "rdbCocuk";
            rdbCocuk.Size = new Size(70, 24);
            rdbCocuk.TabIndex = 5;
            rdbCocuk.TabStop = true;
            rdbCocuk.Text = "Cocuk";
            rdbCocuk.UseVisualStyleBackColor = true;
            // 
            // rdbEnfeksiyon
            // 
            rdbEnfeksiyon.AutoSize = true;
            rdbEnfeksiyon.Location = new Point(33, 219);
            rdbEnfeksiyon.Name = "rdbEnfeksiyon";
            rdbEnfeksiyon.Size = new Size(100, 24);
            rdbEnfeksiyon.TabIndex = 4;
            rdbEnfeksiyon.TabStop = true;
            rdbEnfeksiyon.Text = "Enfeksiyon";
            rdbEnfeksiyon.UseVisualStyleBackColor = true;
            // 
            // rdbDermatoloji
            // 
            rdbDermatoloji.AutoSize = true;
            rdbDermatoloji.Location = new Point(33, 179);
            rdbDermatoloji.Name = "rdbDermatoloji";
            rdbDermatoloji.Size = new Size(110, 24);
            rdbDermatoloji.TabIndex = 3;
            rdbDermatoloji.TabStop = true;
            rdbDermatoloji.Text = "Dermatoloji";
            rdbDermatoloji.UseVisualStyleBackColor = true;
            // 
            // rdbDahiliye
            // 
            rdbDahiliye.AutoSize = true;
            rdbDahiliye.Location = new Point(33, 141);
            rdbDahiliye.Name = "rdbDahiliye";
            rdbDahiliye.Size = new Size(84, 24);
            rdbDahiliye.TabIndex = 2;
            rdbDahiliye.TabStop = true;
            rdbDahiliye.Text = "Dahiliye";
            rdbDahiliye.UseVisualStyleBackColor = true;
            // 
            // rdbPsikiyatri
            // 
            rdbPsikiyatri.AutoSize = true;
            rdbPsikiyatri.Location = new Point(33, 102);
            rdbPsikiyatri.Name = "rdbPsikiyatri";
            rdbPsikiyatri.Size = new Size(88, 24);
            rdbPsikiyatri.TabIndex = 1;
            rdbPsikiyatri.TabStop = true;
            rdbPsikiyatri.Text = "Psikiyatri";
            rdbPsikiyatri.UseVisualStyleBackColor = true;
            // 
            // rdbOrtopedi
            // 
            rdbOrtopedi.AutoSize = true;
            rdbOrtopedi.Location = new Point(33, 59);
            rdbOrtopedi.Name = "rdbOrtopedi";
            rdbOrtopedi.Size = new Size(90, 24);
            rdbOrtopedi.TabIndex = 0;
            rdbOrtopedi.TabStop = true;
            rdbOrtopedi.Text = "Ortopedi";
            rdbOrtopedi.UseVisualStyleBackColor = true;
            // 
            // txtUnvan
            // 
            txtUnvan.Location = new Point(213, 521);
            txtUnvan.Name = "txtUnvan";
            txtUnvan.Size = new Size(182, 27);
            txtUnvan.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 528);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 42;
            label10.Text = "ÜNVAN :";
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(213, 473);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(182, 27);
            txtMaas.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 480);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 40;
            label9.Text = "MAAŞ :";
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(213, 423);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(182, 28);
            cmbCinsiyet.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 423);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 38;
            label8.Text = "CİNSİYET :";
            // 
            // txtNobetSayısı
            // 
            txtNobetSayısı.Location = new Point(213, 365);
            txtNobetSayısı.Name = "txtNobetSayısı";
            txtNobetSayısı.Size = new Size(182, 27);
            txtNobetSayısı.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 372);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 34;
            label6.Text = "AYLIK NÖBET SAYISI :";
            // 
            // txtHastaSayısı
            // 
            txtHastaSayısı.Location = new Point(213, 313);
            txtHastaSayısı.Name = "txtHastaSayısı";
            txtHastaSayısı.Size = new Size(182, 27);
            txtHastaSayısı.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 320);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 32;
            label5.Text = "GUNLUK HASTA SAYISI :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 253);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 30;
            label4.Text = "DOGUM TARİHİ :";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(213, 197);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(182, 27);
            txtTc.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 197);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 28;
            label3.Text = "TC :";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(213, 131);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(182, 27);
            txtSoyad.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 131);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 26;
            label2.Text = "SOYAD :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(213, 70);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(182, 27);
            txtAd.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 70);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 24;
            label1.Text = "AD :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(213, 253);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(182, 27);
            dateTimePicker1.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 577);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 49;
            label7.Text = "BRANŞ :";
            // 
            // cmbbranş
            // 
            cmbbranş.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbbranş.FormattingEnabled = true;
            cmbbranş.Location = new Point(213, 569);
            cmbbranş.Name = "cmbbranş";
            cmbbranş.Size = new Size(182, 28);
            cmbbranş.TabIndex = 50;
            // 
            // DoktorEkleFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 627);
            Controls.Add(cmbbranş);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnEkle);
            Controls.Add(groupBox1);
            Controls.Add(txtUnvan);
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
        private TextBox txtUnvan;
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
        private ComboBox cmbbranş;
    }
}