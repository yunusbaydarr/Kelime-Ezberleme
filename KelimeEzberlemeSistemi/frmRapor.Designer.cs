namespace KelimeEzberlemeSistemi
{
    partial class frmRapor
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
            richTextBox1 = new RichTextBox();
            btnYazdır = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(322, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 50);
            label1.TabIndex = 1;
            label1.Text = "Rapor";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(192, 255, 255);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(36, 72);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(730, 266);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnYazdır
            // 
            btnYazdır.BackColor = Color.FromArgb(128, 255, 255);
            btnYazdır.FlatStyle = FlatStyle.Flat;
            btnYazdır.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnYazdır.Location = new Point(622, 375);
            btnYazdır.Margin = new Padding(4);
            btnYazdır.Name = "btnYazdır";
            btnYazdır.Size = new Size(144, 44);
            btnYazdır.TabIndex = 21;
            btnYazdır.Text = "Yazdır";
            btnYazdır.UseVisualStyleBackColor = false;
            btnYazdır.Click += btnYazdır_Click;
            // 
            // frmRapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYazdır);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "frmRapor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rapor";
            Load += frmRapor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Button btnYazdır;
    }
}