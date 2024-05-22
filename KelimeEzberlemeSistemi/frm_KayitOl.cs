using KelimeEzberlemeSistemi.Manager;
using KelimeEzberlemeSistemi.Model;

namespace KelimeEzberlemeSistemi
{
    public partial class frm_KayitOl : Form
    {
        public frm_KayitOl()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            User user = new User()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text,
                SifreSorusu = cmbYenilemeSorusu.SelectedItem?.ToString(),
                SifreCevabi = txtYenilemeCevabi.Text
            };
            var control = userManager.KullaniciKayitEt(user);
            if (control)
            {
                MessageBox.Show("Kullanıcı Kayıt Edildi.");
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
