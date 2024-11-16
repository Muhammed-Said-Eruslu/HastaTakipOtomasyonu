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
            cmbbranş = new ComboBox();
            label7 = new Label();
            btnekle = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(240, 230);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(182, 27);
            dateTimePicker1.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 230);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 55;
            label4.Text = "DOGUM TARİHİ :";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(240, 174);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(182, 27);
            txtTc.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 174);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 53;
            label3.Text = "TC :";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(240, 108);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(182, 27);
            txtSoyad.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 108);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 51;
            label2.Text = "SOYAD :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(240, 47);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(182, 27);
            txtAd.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 47);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 49;
            label1.Text = "AD :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 299);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 57;
            label5.Text = "VARDİYA :";
            // 
            // cmbVardiya
            // 
            cmbVardiya.FormattingEnabled = true;
            cmbVardiya.Location = new Point(240, 299);
            cmbVardiya.Name = "cmbVardiya";
            cmbVardiya.Size = new Size(182, 28);
            cmbVardiya.TabIndex = 58;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(240, 363);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(182, 28);
            cmbCinsiyet.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 371);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 62;
            label8.Text = "CİNSİYET :";
            // 
            // cmbbranş
            // 
            cmbbranş.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbbranş.FormattingEnabled = true;
            cmbbranş.Location = new Point(240, 423);
            cmbbranş.Name = "cmbbranş";
            cmbbranş.Size = new Size(182, 28);
            cmbbranş.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 431);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 65;
            label7.Text = "BRANŞ :";
            // 
            // btnekle
            // 
            btnekle.Location = new Point(161, 487);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(158, 45);
            btnekle.TabIndex = 66;
            btnekle.Text = "Ekle";
            btnekle.UseVisualStyleBackColor = true;
            btnekle.Click += btnekle_Click;
            // 
            // HemsireEkleFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 561);
            Controls.Add(btnekle);
            Controls.Add(label7);
            Controls.Add(cmbbranş);
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
        private ComboBox cmbbranş;
        private Label label7;
        private Button btnekle;
    }
}