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
            dateTimePicker1.Location = new Point(217, 205);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(189, 23);
            dateTimePicker1.TabIndex = 68;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(217, 253);
            cmbCinsiyet.Margin = new Padding(3, 2, 3, 2);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(189, 23);
            cmbCinsiyet.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 259);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 60;
            label8.Text = "CİNSİYET :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 210);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 55;
            label4.Text = "DOGUM TARİHİ :";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(217, 163);
            txtTc.Margin = new Padding(3, 2, 3, 2);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(189, 23);
            txtTc.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 163);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 53;
            label3.Text = "TC :";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(217, 113);
            txtSoyad.Margin = new Padding(3, 2, 3, 2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(189, 23);
            txtSoyad.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 113);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 51;
            label2.Text = "SOYAD :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(217, 68);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(189, 23);
            txtAd.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 68);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 49;
            label1.Text = "AD :";
            // 
            // btnHastaEkle
            // 
            btnHastaEkle.Location = new Point(217, 313);
            btnHastaEkle.Margin = new Padding(3, 2, 3, 2);
            btnHastaEkle.Name = "btnHastaEkle";
            btnHastaEkle.Size = new Size(188, 50);
            btnHastaEkle.TabIndex = 69;
            btnHastaEkle.Text = "HASTA OLUŞTUR";
            btnHastaEkle.UseVisualStyleBackColor = true;
            btnHastaEkle.Click += btnHastaEkle_Click;
            // 
            // HastaEkleFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 416);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "HastaEkleFormu";
            Text = "HastaEkleFormu";
            Load += HastaEkleFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ComboBox cmbCinsiyet;
        private Label label8;
        private Label label4;
        private TextBox txtTc;
        private Label label3;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
        private Button btnHastaEkle;
    }
}