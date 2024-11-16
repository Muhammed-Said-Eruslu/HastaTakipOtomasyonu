namespace HastaneOtomasyon
{
    partial class HemsireEkleFormu
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
            label4 = new Label();
            txtTc = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            label5 = new Label();
            cmbVardiya = new ComboBox();
            cmbCinsiyet = new ComboBox();
            label8 = new Label();
            cmbBrans = new ComboBox();
            label7 = new Label();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(200, 199);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(160, 23);
            dateTimePicker1.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 199);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 55;
            label4.Text = "DOGUM TARİHİ :";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(200, 157);
            txtTc.Margin = new Padding(3, 2, 3, 2);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(160, 23);
            txtTc.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 157);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 53;
            label3.Text = "TC :";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(200, 107);
            txtSoyad.Margin = new Padding(3, 2, 3, 2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(160, 23);
            txtSoyad.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 107);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 51;
            label2.Text = "SOYAD :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(200, 62);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(160, 23);
            txtAd.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 62);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 49;
            label1.Text = "AD :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 250);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 57;
            label5.Text = "VARDİYA :";
            // 
            // cmbVardiya
            // 
            cmbVardiya.FormattingEnabled = true;
            cmbVardiya.Location = new Point(200, 250);
            cmbVardiya.Margin = new Padding(3, 2, 3, 2);
            cmbVardiya.Name = "cmbVardiya";
            cmbVardiya.Size = new Size(160, 23);
            cmbVardiya.TabIndex = 58;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(200, 298);
            cmbCinsiyet.Margin = new Padding(3, 2, 3, 2);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(160, 23);
            cmbCinsiyet.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 304);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 62;
            label8.Text = "CİNSİYET :";
            // 
            // cmbBrans
            // 
            cmbBrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(200, 344);
            cmbBrans.Margin = new Padding(3, 2, 3, 2);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(160, 23);
            cmbBrans.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 350);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 65;
            label7.Text = "BRANŞ :";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(231, 386);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(107, 23);
            btnEkle.TabIndex = 66;
            btnEkle.Text = "Hemşire Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // HemsireEkleFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 421);
            Controls.Add(btnEkle);
            Controls.Add(label7);
            Controls.Add(cmbBrans);
            Controls.Add(cmbCinsiyet);
            Controls.Add(label8);
            Controls.Add(cmbVardiya);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(txtTc);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HemsireEkleFormu";
            Text = "HemsireEkleFormu";
            Load += HemsireEkleFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox txtTc;
        private Label label3;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
        private Label label5;
        private ComboBox cmbVardiya;
        private ComboBox cmbCinsiyet;
        private Label label8;
        private ComboBox cmbBrans;
        private Label label7;
        private Button btnEkle;
    }
}