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
            groupBox1 = new GroupBox();
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
            groupBox1.SuspendLayout();
            grpKisi.SuspendLayout();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(482, 506);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(507, 68);
            btnEkle.TabIndex = 69;
            btnEkle.Text = "Randevu Oluştur";
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
            groupBox1.Location = new Point(482, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 381);
            groupBox1.TabIndex = 68;
            groupBox1.TabStop = false;
            groupBox1.Text = "Randevu Almak İstediği Bolum";
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
            rdbKBB.CheckedChanged += rdbKBB_CheckedChanged;
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
            rdbCocuk.CheckedChanged += rdbCocuk_CheckedChanged;
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
            rdbEnfeksiyon.CheckedChanged += rdbEnfeksiyon_CheckedChanged;
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
            rdbDermatoloji.CheckedChanged += rdbDermatoloji_CheckedChanged;
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
            rdbDahiliye.CheckedChanged += rdbDahiliye_CheckedChanged;
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
            rdbPsikiyatri.CheckedChanged += rdbPsikiyatri_CheckedChanged;
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
            rdbOrtopedi.CheckedChanged += rdbOrtopedi_CheckedChanged;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(166, 182);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(215, 27);
            txtTc.TabIndex = 75;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 181);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 74;
            label3.Text = "TC :";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(166, 116);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(215, 27);
            txtSoyad.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 115);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 72;
            label2.Text = "SOYAD :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(166, 55);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(215, 27);
            txtAd.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 61);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 70;
            label1.Text = "AD :";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(219, 74);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(215, 27);
            txtArama.TabIndex = 77;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 81);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 76;
            label4.Text = "TC  ARAMA :";
            // 
            // btnAra
            // 
            btnAra.Location = new Point(219, 131);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(215, 52);
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
            grpKisi.Location = new Point(28, 258);
            grpKisi.Name = "grpKisi";
            grpKisi.Size = new Size(406, 316);
            grpKisi.TabIndex = 79;
            grpKisi.TabStop = false;
            grpKisi.Text = "Hasta Bilgileri";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(191, 250);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(190, 27);
            dateTimePicker2.TabIndex = 78;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 255);
            label5.Name = "label5";
            label5.Size = new Size(177, 20);
            label5.TabIndex = 77;
            label5.Text = "RANDEVU TALEP TARİHİ :";
            // 
            // lstDoktorlar
            // 
            lstDoktorlar.FormattingEnabled = true;
            lstDoktorlar.Location = new Point(742, 74);
            lstDoktorlar.Name = "lstDoktorlar";
            lstDoktorlar.Size = new Size(247, 364);
            lstDoktorlar.TabIndex = 80;
            // 
            // HastaRandevuFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 613);
            Controls.Add(lstDoktorlar);
            Controls.Add(grpKisi);
            Controls.Add(btnAra);
            Controls.Add(txtArama);
            Controls.Add(label4);
            Controls.Add(btnEkle);
            Controls.Add(groupBox1);
            Name = "HastaRandevuFormu";
            Text = "HastaRandevuFormu";
            Load += HastaRandevuFormu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpKisi.ResumeLayout(false);
            grpKisi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private GroupBox groupBox1;
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