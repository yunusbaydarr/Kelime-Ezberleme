using KelimeEzberlemeSistemi.Manager;
using System.Drawing.Printing;

namespace KelimeEzberlemeSistemi
{
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }

        private void frmRapor_Load(object sender, EventArgs e)
        {
            RaporManager raporManager = new RaporManager();
            richTextBox1.Text = raporManager.RaporuGetir();
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            // Yazıcı olaylarını işleyen bir PrintDocument örneği oluşturun
            PrintDocument pd = new PrintDocument();

            // Yazdırma olayını ele alın
            pd.PrintPage += (sender, e) =>
            {
                // Başlık metnini belirleyin
                string baslik = "Başarı Raporu";

                // Yazdırılacak metni belirleyin
                string textToPrint = richTextBox1.Text;

                // Yazdırmak için bir font oluşturun
                Font baslikFont = new Font("Arial", 16, FontStyle.Bold);
                Font metinFont = new Font("Arial", 12);

                // Başlığı yazdırın
                e.Graphics.DrawString(baslik, baslikFont, Brushes.Black, new PointF(10, 10));

                // Metni yazdırın
                e.Graphics.DrawString(textToPrint, metinFont, Brushes.Black, new PointF(10, 40));
            };

            // Yazdırma işlemini başlatın
            pd.Print();
            MessageBox.Show("Rapor yazdırıldı.");
        }
    }
}
