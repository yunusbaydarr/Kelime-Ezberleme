namespace KelimeEzberlemeSistemi
{
    partial class frmSinavGirisEkrani
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
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            txtCevap = new TextBox();
            lblIngiliceKelime = new Label();
            label2 = new Label();
            label1 = new Label();
            pcbSoruResmi = new PictureBox();
            btnIleri = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSoruResmi).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCevap);
            panel1.Controls.Add(lblIngiliceKelime);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pcbSoruResmi);
            panel1.Controls.Add(btnIleri);
            panel1.Location = new Point(58, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 451);
            panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(223, 127);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(277, 112);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(24, 168);
            label3.Name = "label3";
            label3.Size = new Size(182, 21);
            label3.TabIndex = 17;
            label3.Text = "Cümle İçinde Kullanımı:";
            // 
            // txtCevap
            // 
            txtCevap.Location = new Point(223, 269);
            txtCevap.Name = "txtCevap";
            txtCevap.Size = new Size(277, 23);
            txtCevap.TabIndex = 16;
            // 
            // lblIngiliceKelime
            // 
            lblIngiliceKelime.AutoSize = true;
            lblIngiliceKelime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblIngiliceKelime.Location = new Point(167, 74);
            lblIngiliceKelime.Name = "lblIngiliceKelime";
            lblIngiliceKelime.Size = new Size(0, 21);
            lblIngiliceKelime.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(26, 267);
            label2.Name = "label2";
            label2.Size = new Size(180, 21);
            label2.TabIndex = 14;
            label2.Text = "Türkçe Karşılığını Girin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(32, 74);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 13;
            label1.Text = "İngilizce Kelime:";
            // 
            // pcbSoruResmi
            // 
            pcbSoruResmi.BackColor = Color.Gainsboro;
            pcbSoruResmi.Location = new Point(531, 36);
            pcbSoruResmi.Name = "pcbSoruResmi";
            pcbSoruResmi.Size = new Size(443, 304);
            pcbSoruResmi.TabIndex = 12;
            pcbSoruResmi.TabStop = false;
            // 
            // btnIleri
            // 
            btnIleri.BackColor = Color.FromArgb(128, 255, 128);
            btnIleri.FlatStyle = FlatStyle.Flat;
            btnIleri.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnIleri.Location = new Point(830, 391);
            btnIleri.Margin = new Padding(4);
            btnIleri.Name = "btnIleri";
            btnIleri.Size = new Size(144, 44);
            btnIleri.TabIndex = 11;
            btnIleri.Text = "İleri";
            btnIleri.UseVisualStyleBackColor = false;
            btnIleri.Click += btnIleri_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(412, 25);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(249, 50);
            label5.TabIndex = 10;
            label5.Text = "Sınav Modülü";
            // 
            // frmSinavGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1117, 575);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "frmSinavGirisEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sınav Modülü";
            Load += frmSinavGirisEkrani_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSoruResmi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button btnIleri;
        private Label label1;
        private PictureBox pcbSoruResmi;
        private RichTextBox richTextBox1;
        private Label label3;
        private TextBox txtCevap;
        private Label lblIngiliceKelime;
        private Label label2;
    }
}