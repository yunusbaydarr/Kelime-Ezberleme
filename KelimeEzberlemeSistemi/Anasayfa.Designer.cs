namespace KelimeEzberlemeSistemi
{
    partial class frm_Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnGirisYap = new Button();
            btnKayitOl = new Button();
            linkLabelSifremiUnuttum = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(85, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(451, 50);
            label1.TabIndex = 0;
            label1.Text = "Kelime Ezberleme Sistemi";
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(128, 255, 128);
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(160, 242);
            btnGirisYap.Margin = new Padding(4);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(165, 70);
            btnGirisYap.TabIndex = 5;
            btnGirisYap.Text = "Giriş";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.FromArgb(255, 255, 192);
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(389, 242);
            btnKayitOl.Margin = new Padding(4);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(165, 70);
            btnKayitOl.TabIndex = 6;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // linkLabelSifremiUnuttum
            // 
            linkLabelSifremiUnuttum.AutoSize = true;
            linkLabelSifremiUnuttum.Location = new Point(431, 343);
            linkLabelSifremiUnuttum.Margin = new Padding(4, 0, 4, 0);
            linkLabelSifremiUnuttum.Name = "linkLabelSifremiUnuttum";
            linkLabelSifremiUnuttum.Size = new Size(130, 21);
            linkLabelSifremiUnuttum.TabIndex = 7;
            linkLabelSifremiUnuttum.TabStop = true;
            linkLabelSifremiUnuttum.Text = "Şifremi Unuttum";
            linkLabelSifremiUnuttum.LinkClicked += linkLabelSifremiUnuttum_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(55, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(110, 168);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 2;
            label3.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(160, 115);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(392, 29);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(160, 164);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(392, 29);
            txtSifre.TabIndex = 4;
            // 
            // frm_Anasayfa
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(614, 407);
            Controls.Add(linkLabelSifremiUnuttum);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frm_Anasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGirisYap;
        private Button btnKayitOl;
        private LinkLabel linkLabelSifremiUnuttum;
        private Label label2;
        private Label label3;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
    }
}
