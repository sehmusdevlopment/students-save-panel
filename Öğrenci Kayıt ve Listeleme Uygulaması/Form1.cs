namespace Öğrenci_Kayıt_ve_Listeleme_Uygulaması
{
    public partial class öğrencikayıt : Form
    {
        public öğrencikayıt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string numara = txtNumara.Text.Trim();

            if (ad == "" || soyad == "" || numara == "")
            {
                MessageBox.Show("lütfen tüm alanları doldurunuz", "eksik bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string kayit = $"{numara}-{ad}{soyad}";
            lstOgrenciler.Items.Add(kayit);
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
            txtAd.Focus();
        }

        private void NewMethod()
        {
            txtAd.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstOgrenciler.SelectedIndex != -1)
            {
                lstOgrenciler.Items.RemoveAt(lstOgrenciler.SelectedIndex);

            }
            else
            {
                MessageBox.Show("lütfen silmek için bir öğrenci seQçiniz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
