using KelimeEzberlemeSistemi.Manager;
using KelimeEzberlemeSistemi.Model;

namespace KelimeEzberlemeSistemi
{
    public partial class frmSinavGirisEkrani : Form
    {
        List<Word> words = new List<Word>();
        int sayac = 0;
        public frmSinavGirisEkrani()
        {
            InitializeComponent();
        }

        private void frmSinavGirisEkrani_Load(object sender, EventArgs e)
        {
            ExamManager examManager = new ExamManager();
            words = examManager.KelimeleriGetir();
            if (words.Count > 0)
            {
                lblIngiliceKelime.Text = words[0].IngilizceKelime;
                richTextBox1.Text = words[0].CumleIcinde;
                pcbSoruResmi.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbSoruResmi.Image = Image.FromStream(new MemoryStream(words[0].Resim));
            }
            else
            {
                label5.Text = "Sınava ait uygun soru bulunamadı.";
            }
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (btnIleri.Text == "Sınavı Bitir")
            {
                this.Close();
            }

            if (sayac != words.Count)
            {
                sayac = sayac + 1;
                if (sayac != words.Count)
                {
                    lblIngiliceKelime.Text = words[sayac].IngilizceKelime;
                    richTextBox1.Text = words[sayac].CumleIcinde;
                    pcbSoruResmi.Image = Image.FromStream(new MemoryStream(words[sayac].Resim));
                }

                ExamManager examManager = new ExamManager();
                examManager.SoruCevaplariniKayitEt(words[sayac - 1].Id, txtCevap.Text);
                if (sayac == words.Count)
                {
                    MessageBox.Show("Sorular bitti");
                    btnIleri.Text = "Sınavı Bitir";
                }
                txtCevap.Text = "";
            }
            else
            {
                MessageBox.Show("Sorular bitti");
                btnIleri.Text = "Sınavı Bitir";

            }
        }
    }
}



