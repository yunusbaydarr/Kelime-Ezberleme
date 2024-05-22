namespace KelimeEzberlemeSistemi
{
    partial class frm_KayitOl
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
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtSifre = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtKullaniciAdi = new TextBox();
            cmbYenilemeSorusu = new ComboBox();
            label6 = new Label();
            btnKayitOl = new Button();
            txtYenilemeCevabi = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 50);
            label1.TabIndex = 1;
            label1.Text = "Kayıt Ol";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(92, 182);
            txtSoyad.Margin = new Padding(4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(272, 23);
            txtSoyad.TabIndex = 8;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(92, 122);
            txtAd.Margin = new Padding(4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(272, 23);
            txtAd.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(92, 157);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 6;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(92, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 5;
            label2.Text = "Ad:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(92, 468);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(272, 23);
            txtSifre.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(92, 443);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 10;
            label4.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(92, 374);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 9;
            label5.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(92, 399);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(272, 23);
            txtKullaniciAdi.TabIndex = 11;
            // 
            // cmbYenilemeSorusu
            // 
            cmbYenilemeSorusu.FormattingEnabled = true;
            cmbYenilemeSorusu.Items.AddRange(new object[] { "İlk evcil hayvanınızın adı neydi?", "İlk okulunuzun adı nedir?", "En sevdiğiniz renk nedir?", "Annenizin kızlık soyadı nedir?", "En sevdiğiniz film veya kitap nedir?", "Doğum yeri neresiydi?", "En sevdiğiniz spor dalı nedir?", "En sevdiğiniz yemek nedir?", "En iyi arkadaşınızın adı nedir?", "Hangi ülkede en çok seyahat etmek istersiniz?" });
            cmbYenilemeSorusu.Location = new Point(92, 255);
            cmbYenilemeSorusu.Name = "cmbYenilemeSorusu";
            cmbYenilemeSorusu.Size = new Size(272, 23);
            cmbYenilemeSorusu.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(92, 231);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(172, 21);
            label6.TabIndex = 14;
            label6.Text = "Şifre Yenileme Sorusu:";
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.FromArgb(255, 255, 192);
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(267, 512);
            btnKayitOl.Margin = new Padding(4);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(165, 70);
            btnKayitOl.TabIndex = 15;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // txtYenilemeCevabi
            // 
            txtYenilemeCevabi.Location = new Point(92, 330);
            txtYenilemeCevabi.Margin = new Padding(4);
            txtYenilemeCevabi.Name = "txtYenilemeCevabi";
            txtYenilemeCevabi.Size = new Size(272, 23);
            txtYenilemeCevabi.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(92, 305);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(171, 21);
            label7.TabIndex = 16;
            label7.Text = "Şifre Yenileme Cevabı:";
            // 
            // frm_KayitOl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 595);
            Controls.Add(txtYenilemeCevabi);
            Controls.Add(label7);
            Controls.Add(btnKayitOl);
            Controls.Add(label6);
            Controls.Add(cmbYenilemeSorusu);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_KayitOl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Ol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label3;
        private Label label2;
        private TextBox txtSifre;
        private Label label4;
        private Label label5;
        private TextBox txtKullaniciAdi;
        private ComboBox cmbYenilemeSorusu;
        private Label label6;
        private Button btnKayitOl;
        private TextBox txtYenilemeCevabi;
        private Label label7;
    }
}