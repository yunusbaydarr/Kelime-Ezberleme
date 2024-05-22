using KelimeEzberlemeSistemi.Manager;
using KelimeEzberlemeSistemi.Model;

namespace KelimeEzberlemeSistemi
{
    public partial class frm_SifremiUnuttum : Form
    {
        public frm_SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnSifremiDegistir_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();

            User user = new User()
            {
                KullaniciAdi = txtKullaniciAdi.Text,
                SifreSorusu = cmbYenilemeSorusu.SelectedItem?.ToString(),
                SifreCevabi = txtYenilemeCevabi.Text,
                Sifre = txtSifre.Text
            };

            var control = userManager.SifremiDegistir(user);

            if (control)
            {
                MessageBox.Show("Şifre Değiştirildi.");
            }
            else
            {
                MessageBox.Show("Hata");
            }

        }
    }
}
