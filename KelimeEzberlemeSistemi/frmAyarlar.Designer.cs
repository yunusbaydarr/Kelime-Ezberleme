namespace KelimeEzberlemeSistemi
{
    partial class frmAyarlar
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
            label5 = new Label();
            soruSayisi = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbZaman = new ComboBox();
            btnKayitEt = new Button();
            ((System.ComponentModel.ISupportInitialize)soruSayisi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(21, 132);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Soru Sayısı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(139, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 50);
            label5.TabIndex = 11;
            label5.Text = "Ayarlar";
            // 
            // soruSayisi
            // 
            soruSayisi.Location = new Point(128, 132);
            soruSayisi.Name = "soruSayisi";
            soruSayisi.Size = new Size(260, 23);
            soruSayisi.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(21, 207);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 13;
            label2.Text = "Zamanı Seç:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(21, 102);
            label3.Name = "label3";
            label3.Size = new Size(211, 15);
            label3.TabIndex = 14;
            label3.Text = "Sınavda çıkacak soru sayısını belirleyin.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(21, 177);
            label4.Name = "label4";
            label4.Size = new Size(300, 15);
            label4.TabIndex = 15;
            label4.Text = "Test edebilmek için sistemi sistemin zamanını değiştirin.";
            // 
            // cmbZaman
            // 
            cmbZaman.FormattingEnabled = true;
            cmbZaman.Items.AddRange(new object[] { "1 gün sonra", "1 hafta sonra", "1 ay sonra", "3 ay sonra", "6 ay sonra", "1 yıl sonra" });
            cmbZaman.Location = new Point(128, 207);
            cmbZaman.Name = "cmbZaman";
            cmbZaman.Size = new Size(260, 23);
            cmbZaman.TabIndex = 16;
            // 
            // btnKayitEt
            // 
            btnKayitEt.BackColor = Color.FromArgb(128, 255, 128);
            btnKayitEt.FlatStyle = FlatStyle.Flat;
            btnKayitEt.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKayitEt.Location = new Point(223, 257);
            btnKayitEt.Margin = new Padding(4);
            btnKayitEt.Name = "btnKayitEt";
            btnKayitEt.Size = new Size(165, 70);
            btnKayitEt.TabIndex = 17;
            btnKayitEt.Text = "Kayıt Et";
            btnKayitEt.UseVisualStyleBackColor = false;
            btnKayitEt.Click += btnKayitEt_Click;
            // 
            // frmAyarlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(439, 385);
            Controls.Add(btnKayitEt);
            Controls.Add(cmbZaman);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(soruSayisi);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "frmAyarlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V";
            ((System.ComponentModel.ISupportInitialize)soruSayisi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private NumericUpDown soruSayisi;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbZaman;
        private Button btnKayitEt;
    }
}