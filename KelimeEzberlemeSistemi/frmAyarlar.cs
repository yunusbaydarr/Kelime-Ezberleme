using KelimeEzberlemeSistemi.Model;

namespace KelimeEzberlemeSistemi
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            StaticVeriables.soruSayisi = Convert.ToInt32(soruSayisi.Value + 1);
            var secilenTarih = cmbZaman.SelectedItem?.ToString();
            DateTime bugun = DateTime.Now; // Şu anki tarih ve saat

            if (secilenTarih == "1 gün sonra")
            {
                DateTime secilenTarihDT = bugun.AddDays(1);
                StaticVeriables.guncelTarih = secilenTarihDT;
                // 1 gün sonra işlemleri
            }
            else if (secilenTarih == "1 hafta sonra")
            {
                DateTime secilenTarihDT = bugun.AddDays(7);
                StaticVeriables.guncelTarih = secilenTarihDT;
                // 1 hafta sonra işlemleri
            }
            else if (secilenTarih == "1 ay sonra")
            {
                DateTime secilenTarihDT = bugun.AddMonths(1);
                StaticVeriables.guncelTarih = secilenTarihDT;
                // 1 ay sonra işlemleri
            }
            else if (secilenTarih == "3 ay sonra")
            {
                DateTime secilenTarihDT = bugun.AddMonths(3);
                StaticVeriables.guncelTarih = secilenTarihDT;
                // 3 ay sonra işlemleri
            }
            else if (secilenTarih == "6 ay sonra")
            {
                DateTime secilenTarihDT = bugun.AddMonths(6);
                StaticVeriables.guncelTarih = secilenTarihDT;
                // 6 ay sonra işlemleri
            }
            else if (secilenTarih == "1 yıl sonra")
            {
                DateTime secilenTarihDT = bugun.AddYears(1);
                StaticVeriables.guncelTarih = secilenTarihDT;
                // 1 yıl sonra işlemleri
            }
            else
            {
                StaticVeriables.guncelTarih = bugun;

            }
            MessageBox.Show("Ayarlarınız Kayıt Edildi.");
            this.Close();
        }
    }
}
