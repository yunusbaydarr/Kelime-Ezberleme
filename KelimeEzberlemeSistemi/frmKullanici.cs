using KelimeEzberlemeSistemi.Model;

namespace KelimeEzberlemeSistemi
{
    public partial class frmKullanici : Form
    {
        User _user { get; set; }
        public frmKullanici(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = "Merhaba " + _user.Ad;
        }

        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
            frmKelimeEklemeModulu frmKelimeEklemeModulu = new frmKelimeEklemeModulu();
            frmKelimeEklemeModulu.ShowDialog();
        }

        private void btnSinavaGir_Click(object sender, EventArgs e)
        {
            frmSinavGirisEkrani frmSinavGirisEkrani = new frmSinavGirisEkrani();
            frmSinavGirisEkrani.ShowDialog();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frmAyarlar = new frmAyarlar();
            frmAyarlar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRapor frmRapor = new frmRapor();
            frmRapor.ShowDialog();
        }
    }
}
