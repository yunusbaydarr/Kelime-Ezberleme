namespace KelimeEzberlemeSistemi
{
    partial class frm_SifremiUnuttum
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
            txtYenilemeCevabi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cmbYenilemeSorusu = new ComboBox();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            btnSifremiDegistir = new Button();
            SuspendLayout();
            // 
            // txtYenilemeCevabi
            // 
            txtYenilemeCevabi.Location = new Point(25, 260);
            txtYenilemeCevabi.Margin = new Padding(4);
            txtYenilemeCevabi.Name = "txtYenilemeCevabi";
            txtYenilemeCevabi.Size = new Size(272, 23);
            txtYenilemeCevabi.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(25, 235);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(171, 21);
            label7.TabIndex = 20;
            label7.Text = "Şifre Yenileme Cevabı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(25, 161);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(172, 21);
            label6.TabIndex = 19;
            label6.Text = "Şifre Yenileme Sorusu:";
            // 
            // cmbYenilemeSorusu
            // 
            cmbYenilemeSorusu.FormattingEnabled = true;
            cmbYenilemeSorusu.Items.AddRange(new object[] { "İlk evcil hayvanınızın adı neydi?", "İlk okulunuzun adı nedir?", "En sevdiğiniz renk nedir?", "Annenizin kızlık soyadı nedir?", "En sevdiğiniz film veya kitap nedir?", "Doğum yeri neresiydi?", "En sevdiğiniz spor dalı nedir?", "En sevdiğiniz yemek nedir?", "En iyi arkadaşınızın adı nedir?", "Hangi ülkede en çok seyahat etmek istersiniz?" });
            cmbYenilemeSorusu.Location = new Point(25, 185);
            cmbYenilemeSorusu.Name = "cmbYenilemeSorusu";
            cmbYenilemeSorusu.Size = new Size(272, 23);
            cmbYenilemeSorusu.TabIndex = 18;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(25, 334);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(272, 23);
            txtSifre.TabIndex = 25;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(25, 119);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(272, 23);
            txtKullaniciAdi.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 309);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 23;
            label4.Text = "Yeni Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 94);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 22;
            label5.Text = "Kullanıcı Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(70, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(299, 50);
            label1.TabIndex = 26;
            label1.Text = "Şifremi Unuttum";
            // 
            // btnSifremiDegistir
            // 
            btnSifremiDegistir.BackColor = Color.FromArgb(128, 255, 128);
            btnSifremiDegistir.FlatStyle = FlatStyle.Flat;
            btnSifremiDegistir.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSifremiDegistir.Location = new Point(193, 397);
            btnSifremiDegistir.Margin = new Padding(4);
            btnSifremiDegistir.Name = "btnSifremiDegistir";
            btnSifremiDegistir.Size = new Size(215, 70);
            btnSifremiDegistir.TabIndex = 27;
            btnSifremiDegistir.Text = "Şifremi Değiştir";
            btnSifremiDegistir.UseVisualStyleBackColor = false;
            btnSifremiDegistir.Click += btnSifremiDegistir_Click;
            // 
            // frm_SifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(421, 503);
            Controls.Add(btnSifremiDegistir);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtYenilemeCevabi);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbYenilemeSorusu);
            Name = "frm_SifremiUnuttum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_SifremiUnuttum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtYenilemeCevabi;
        private Label label7;
        private Label label6;
        private ComboBox cmbYenilemeSorusu;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label4;
        private Label label5;
        private Label label1;
        private Button btnSifremiDegistir;
    }
}