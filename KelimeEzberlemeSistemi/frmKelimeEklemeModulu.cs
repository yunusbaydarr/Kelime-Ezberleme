using KelimeEzberlemeSistemi.Manager;
using KelimeEzberlemeSistemi.Model;

namespace KelimeEzberlemeSistemi
{
    public partial class frmKelimeEklemeModulu : Form
    {
        public frmKelimeEklemeModulu()
        {
            InitializeComponent();
        }

        private void linkLblResimSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Seçilen resmi yükle
                Image image = Image.FromFile(openFileDialog1.FileName);

                // Resmi PictureBox kontrolünün boyutuna uyacak şekilde yeniden boyutlandır
                picBox.SizeMode = PictureBoxSizeMode.StretchImage; // Resmi PictureBox boyutuna göre otomatik olarak yeniden boyutlandırmak için

                // Resmi PictureBox'a ekle
                picBox.Image = image;
            }
        }

        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
            WordManager wordManager = new WordManager();
            Word word = new Word()
            {
                IngilizceKelime = txtIngilizceKelime.Text,
                Konu = txtKonu.Text,
                TurkceKarsiligi = txtTurkceKarsligi.Text,
                CumleIcinde = rchCumleIcindeKullanimi.Text,
                Resim = File.ReadAllBytes(openFileDialog1.FileName)
            };
            var control = wordManager.KelimeEkle(word);
            if (control)
            {
                txtIngilizceKelime.Text = "";
                txtTurkceKarsligi.Text = "";
                rchCumleIcindeKullanimi.Text = "";
                picBox.Image = null;
                MessageBox.Show("Kelime Kayıt Edildi.");
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
