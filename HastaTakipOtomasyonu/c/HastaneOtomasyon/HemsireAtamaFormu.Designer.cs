namespace HastaneOtomasyon
{
    partial class HemsireAtamaFormu
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
            label1 = new Label();
            cmbDoktorlar = new ComboBox();
            label2 = new Label();
            lstHemsireler = new ListBox();
            btnAta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 62);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "DOKTOR :";
            // 
            // cmbDoktorlar
            // 
            cmbDoktorlar.FormattingEnabled = true;
            cmbDoktorlar.Location = new Point(177, 59);
            cmbDoktorlar.Name = "cmbDoktorlar";
            cmbDoktorlar.Size = new Size(217, 28);
            cmbDoktorlar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 135);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 2;
            label2.Text = "HEMŞİRELER :";
            // 
            // lstHemsireler
            // 
            lstHemsireler.FormattingEnabled = true;
            lstHemsireler.Location = new Point(177, 135);
            lstHemsireler.Name = "lstHemsireler";
            lstHemsireler.Size = new Size(217, 364);
            lstHemsireler.TabIndex = 3;
            // 
            // btnAta
            // 
            btnAta.Location = new Point(177, 527);
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(217, 45);
            btnAta.TabIndex = 4;
            btnAta.Text = "ATAMA YAP";
            btnAta.UseVisualStyleBackColor = true;
            // 
            // HemsireAtamaFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 584);
            Controls.Add(btnAta);
            Controls.Add(lstHemsireler);
            Controls.Add(label2);
            Controls.Add(cmbDoktorlar);
            Controls.Add(label1);
            Name = "HemsireAtamaFormu";
            Text = "HemsireAtamaFormu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDoktorlar;
        private Label label2;
        private ListBox lstHemsireler;
        private Button btnAta;
    }
}