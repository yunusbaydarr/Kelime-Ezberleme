namespace KelimeEzberlemeSistemi
{
    partial class frmKullanici
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
            btnKelimeEkle = new Button();
            lblHosgeldin = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSinavaGir = new Button();
            btnAyarlar = new Button();
            button3 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnKelimeEkle
            // 
            btnKelimeEkle.BackColor = Color.FromArgb(128, 255, 128);
            btnKelimeEkle.FlatStyle = FlatStyle.Flat;
            btnKelimeEkle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKelimeEkle.Location = new Point(23, 171);
            btnKelimeEkle.Margin = new Padding(4);
            btnKelimeEkle.Name = "btnKelimeEkle";
            btnKelimeEkle.Size = new Size(144, 44);
            btnKelimeEkle.TabIndex = 12;
            btnKelimeEkle.Text = "Kelime Ekle";
            btnKelimeEkle.UseVisualStyleBackColor = false;
            btnKelimeEkle.Click += btnKelimeEkle_Click;
            // 
            // lblHosgeldin
            // 
            lblHosgeldin.AutoSize = true;
            lblHosgeldin.Font = new Font("Segoe UI Semibold", 14.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHosgeldin.ForeColor = Color.Tomato;
            lblHosgeldin.Location = new Point(23, 78);
            lblHosgeldin.Margin = new Padding(4, 0, 4, 0);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.Size = new Size(0, 28);
            lblHosgeldin.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(323, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 50);
            label1.TabIndex = 14;
            label1.Text = "SAYFAM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 132);
            label2.Name = "label2";
            label2.Size = new Size(644, 20);
            label2.TabIndex = 15;
            label2.Text = "Sisteme yeni bir kelime eklemek için aşağıdaki butona tıklayıp yeni bir kelime ekleyebilirsiniz.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 255);
            label3.Name = "label3";
            label3.Size = new Size(319, 20);
            label3.TabIndex = 16;
            label3.Text = "Sınava girmek için aşağıdaki butonu kullanın.";
            // 
            // btnSinavaGir
            // 
            btnSinavaGir.BackColor = Color.FromArgb(255, 255, 192);
            btnSinavaGir.FlatStyle = FlatStyle.Flat;
            btnSinavaGir.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSinavaGir.Location = new Point(23, 293);
            btnSinavaGir.Margin = new Padding(4);
            btnSinavaGir.Name = "btnSinavaGir";
            btnSinavaGir.Size = new Size(144, 44);
            btnSinavaGir.TabIndex = 17;
            btnSinavaGir.Text = "Sınava Gir";
            btnSinavaGir.UseVisualStyleBackColor = false;
            btnSinavaGir.Click += btnSinavaGir_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.FromArgb(224, 224, 224);
            btnAyarlar.FlatStyle = FlatStyle.Flat;
            btnAyarlar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAyarlar.Location = new Point(664, 9);
            btnAyarlar.Margin = new Padding(4);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(123, 44);
            btnAyarlar.TabIndex = 18;
            btnAyarlar.Text = "Ayarlar";
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(643, 382);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(144, 44);
            button3.TabIndex = 20;
            button3.Text = "Rapor";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(365, 349);
            label4.Name = "label4";
            label4.Size = new Size(422, 20);
            label4.TabIndex = 19;
            label4.Text = "Değerlendirme raporu için aşağıdaki butona tıklayabilirsiniz.";
            // 
            // frmKullanici
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(btnAyarlar);
            Controls.Add(btnSinavaGir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHosgeldin);
            Controls.Add(btnKelimeEkle);
            Name = "frmKullanici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Benim Sayfam";
            Load += frmKullanici_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKelimeEkle;
        private Label lblHosgeldin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSinavaGir;
        private Button btnAyarlar;
        private Button button3;
        private Label label4;
    }
}