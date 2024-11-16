namespace HastaneOtomasyon
{
    partial class HastaEkleFormu
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
            dateTimePicker1 = new DateTimePicker();
            cmbCinsiyet = new ComboBox();
            label8 = new Label();
            label4 = new Label();
            txtTc = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            btnHastaEkle = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(248, 273);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 27);
            dateTimePicker1.TabIndex = 68;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(248, 337);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(215, 28);
            cmbCinsiyet.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 345);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 60;
            label8.Text = "CİNSİYET :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 280);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 55;
            label4.Text = "DOGUM TARİHİ :";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(248, 217);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(215, 27);
            txtTc.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 217);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 53;
            label3.Text = "TC :";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(248, 151);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(215, 27);
            txtSoyad.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 151);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 51;
            label2.Text = "SOYAD :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(248, 90);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(215, 27);
            txtAd.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 90);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 49;
            label1.Text = "AD :";
            // 
            // btnHastaEkle
            // 
            btnHastaEkle.Location = new Point(248, 417);
            btnHastaEkle.Name = "btnHastaEkle";
            btnHastaEkle.Size = new Size(215, 67);
            btnHastaEkle.TabIndex = 69;
            btnHastaEkle.Text = "HASTA OLUŞTUR";
            btnHastaEkle.UseVisualStyleBackColor = true;
            btnHastaEkle.Click += btnHastaEkle_Click;
            // 
            // HastaEkleFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 554);
            Controls.Add(btnHastaEkle);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbCinsiyet);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txtTc);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Name = "HastaEkleFormu";
            Text = "HastaEkleFormu";
            Load += HastaEkleFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnHastaEkle;
        public DateTimePicker dateTimePicker1;
        public ComboBox cmbCinsiyet;
        public TextBox txtTc;
        public TextBox txtSoyad;
        public TextBox txtAd;
    }
}