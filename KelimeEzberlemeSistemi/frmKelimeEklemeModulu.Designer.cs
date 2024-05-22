namespace KelimeEzberlemeSistemi
{
    partial class frmKelimeEklemeModulu
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
            label3 = new Label();
            label2 = new Label();
            txtIngilizceKelime = new TextBox();
            txtTurkceKarsligi = new TextBox();
            rchCumleIcindeKullanimi = new RichTextBox();
            picBox = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            label4 = new Label();
            label5 = new Label();
            btnKelimeEkle = new Button();
            linkLblResimSec = new LinkLabel();
            txtKonu = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(61, 129);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 0;
            label1.Text = "İngilizce Kelime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(64, 171);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 2;
            label3.Text = "Türkçe Karşılığı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(8, 207);
            label2.Name = "label2";
            label2.Size = new Size(182, 21);
            label2.TabIndex = 3;
            label2.Text = "Cümle İçinde Kullanımı:";
            // 
            // txtIngilizceKelime
            // 
            txtIngilizceKelime.Location = new Point(196, 129);
            txtIngilizceKelime.Name = "txtIngilizceKelime";
            txtIngilizceKelime.Size = new Size(292, 23);
            txtIngilizceKelime.TabIndex = 4;
            // 
            // txtTurkceKarsligi
            // 
            txtTurkceKarsligi.Location = new Point(196, 169);
            txtTurkceKarsligi.Name = "txtTurkceKarsligi";
            txtTurkceKarsligi.Size = new Size(292, 23);
            txtTurkceKarsligi.TabIndex = 5;
            // 
            // rchCumleIcindeKullanimi
            // 
            rchCumleIcindeKullanimi.Location = new Point(196, 209);
            rchCumleIcindeKullanimi.Name = "rchCumleIcindeKullanimi";
            rchCumleIcindeKullanimi.Size = new Size(292, 150);
            rchCumleIcindeKullanimi.TabIndex = 6;
            rchCumleIcindeKullanimi.Text = "";
            // 
            // picBox
            // 
            picBox.BackColor = Color.FromArgb(255, 255, 192);
            picBox.Location = new Point(606, 90);
            picBox.Name = "picBox";
            picBox.Size = new Size(443, 230);
            picBox.TabIndex = 7;
            picBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(542, 90);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 8;
            label4.Text = "Resim:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(286, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(404, 50);
            label5.TabIndex = 9;
            label5.Text = "Kelime Ekleme Modülü";
            // 
            // btnKelimeEkle
            // 
            btnKelimeEkle.BackColor = Color.FromArgb(128, 255, 128);
            btnKelimeEkle.FlatStyle = FlatStyle.Flat;
            btnKelimeEkle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKelimeEkle.Location = new Point(228, 386);
            btnKelimeEkle.Margin = new Padding(4);
            btnKelimeEkle.Name = "btnKelimeEkle";
            btnKelimeEkle.Size = new Size(626, 70);
            btnKelimeEkle.TabIndex = 10;
            btnKelimeEkle.Text = "Kelimeyi Ekle";
            btnKelimeEkle.UseVisualStyleBackColor = false;
            btnKelimeEkle.Click += btnKelimeEkle_Click;
            // 
            // linkLblResimSec
            // 
            linkLblResimSec.AutoSize = true;
            linkLblResimSec.Location = new Point(989, 332);
            linkLblResimSec.Margin = new Padding(4, 0, 4, 0);
            linkLblResimSec.Name = "linkLblResimSec";
            linkLblResimSec.Size = new Size(60, 15);
            linkLblResimSec.TabIndex = 11;
            linkLblResimSec.TabStop = true;
            linkLblResimSec.Text = "Resim Seç";
            linkLblResimSec.LinkClicked += linkLblResimSec_LinkClicked;
            // 
            // txtKonu
            // 
            txtKonu.Location = new Point(196, 92);
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(292, 23);
            txtKonu.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(139, 94);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 12;
            label6.Text = "Konu:";
            // 
            // frmKelimeEklemeModulu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1093, 469);
            Controls.Add(txtKonu);
            Controls.Add(label6);
            Controls.Add(linkLblResimSec);
            Controls.Add(btnKelimeEkle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(picBox);
            Controls.Add(rchCumleIcindeKullanimi);
            Controls.Add(txtTurkceKarsligi);
            Controls.Add(txtIngilizceKelime);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmKelimeEklemeModulu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelime Ekleme Modülü";
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtIngilizceKelime;
        private TextBox txtTurkceKarsligi;
        private RichTextBox rchCumleIcindeKullanimi;
        private PictureBox picBox;
        private OpenFileDialog openFileDialog1;
        private Label label4;
        private Label label5;
        private Button btnKelimeEkle;
        private LinkLabel linkLblResimSec;
        private TextBox txtKonu;
        private Label label6;
    }
}