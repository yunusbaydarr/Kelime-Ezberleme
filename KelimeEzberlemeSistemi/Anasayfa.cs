using KelimeEzberlemeSistemi.Manager;
using KelimeEzberlemeSistemi.Model;

namespace KelimeEzberlemeSistemi
{
    public partial class frm_Anasayfa : Form
    {
        public frm_Anasayfa()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frm_KayitOl frm_KayitOl = new frm_KayitOl();
            frm_KayitOl.ShowDialog();
        }

        private void linkLabelSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_SifremiUnuttum frm_SifremiUnuttum = new frm_SifremiUnuttum();
            frm_SifremiUnuttum.ShowDialog();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            UserManager userManager = new UserManager();
            var user = new User()
            {
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text
            };
            var _user = userManager.GirisYap(user);
            if (_user != null)
            {
                StaticVeriables.userId = _user.Id;
                frmKullanici frmKullanici = new frmKullanici(_user);
                frmKullanici.ShowDialog();
            }
            else
            {
                MessageBox.Show("Giriþ Baþarýsýz");
            }
        }
    }
}
