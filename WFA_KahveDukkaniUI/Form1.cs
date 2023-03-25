using KahveDukkaniBLL.Concrete;
using KahveSiparisEntities.Entities;

namespace WFA_KahveDukkaniUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
     
        Calisan _atananCalisan;
        private void Form1_Load(object sender, EventArgs e)
        {
            CalisanDoldur();
            KahveListele();
            EkstraListele();


        }
        CalisanRepository calisanRepository = new CalisanRepository();
        void CalisanDoldur()
        {
            foreach (Calisan calisan in calisanRepository.Calisanlar())
            {

                lstCalisan.Items.Add(calisan);

            }
        }



        public void CalisaniKasayaGonder(int _calisanindex, ListBox.ObjectCollection calisanlar)
        {

            string _seciliCalisan = calisanlar[_calisanindex].ToString();
            lblKasa1.Text = _seciliCalisan;
            calisanlar.RemoveAt(_calisanindex);

        }

        public Calisan CalisaniUretimeGonder(int _calisanindex, ListBox.ObjectCollection calisanlar)
        {

            Calisan _seciliCalisan = (Calisan)calisanlar[_calisanindex];

            calisanlar.RemoveAt(_calisanindex);
            return _seciliCalisan;

        }
        Calisan calisan;
        SiparisRepository siparisRepository = new SiparisRepository();
        private void btnSiparisiYonlendir1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int _calisanindex2 = rnd.Next(0, lstCalisan.Items.Count);
            calisan = CalisaniUretimeGonder(_calisanindex2, lstCalisan.Items);
            uretim1.Text = calisan.AdSoyad.ToString();

            Siparis _yeniSiparis = siparisRepository.SiparisOlustur((Urun)cmbKahveler.SelectedItem, (EkstraMalzeme)cmbEkstralar.SelectedItem);

            lblSure.Text = _yeniSiparis.ToplamSure.ToString();

            DialogResult dr = MessageBox.Show($"Sipariþ yönlendirildi. Bekleme Süresi: {lblSure.Text} Dakika", "Bilgi Ekraný", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSiparisiYonlendir1.Enabled = false;
            timer1.Start();
           


        }

        private void btnSiparisYonlendir2_Click(object sender, EventArgs e)

        {
            Random rnd = new Random();
            int _calisanindex2 = rnd.Next(0, lstCalisan.Items.Count);
            calisan = CalisaniUretimeGonder(_calisanindex2, lstCalisan.Items);
            uretim2.Text = calisan.AdSoyad.ToString();
            Siparis _yeniSiparis = siparisRepository.SiparisOlustur((Urun)cmbKahveler.SelectedItem, (EkstraMalzeme)cmbEkstralar.SelectedItem);

            lblSure.Text = _yeniSiparis.ToplamSure.ToString();

            DialogResult dr = MessageBox.Show($"Sipariþ yönlendirildi. Bekleme Süresi: {lblSure.Text} Dakika", "Bilgi Ekraný", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSiparisYonlendir2.Enabled = false;
            timer2.Start();
        }

        private void btnSiparisiYonlendir3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int _calisanindex2 = rnd.Next(0, lstCalisan.Items.Count);
            calisan = CalisaniUretimeGonder(_calisanindex2, lstCalisan.Items);
            uretimHatti3.Text = calisan.AdSoyad.ToString();

            Siparis _yeniSiparis = siparisRepository.SiparisOlustur((Urun)cmbKahveler.SelectedItem, (EkstraMalzeme)cmbEkstralar.SelectedItem);

            lblSure.Text = _yeniSiparis.ToplamSure.ToString();

            DialogResult dr = MessageBox.Show($"Sipariþ yönlendirildi. Bekleme Süresi: {lblSure.Text} Dakika", "Bilgi Ekraný", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSiparisiYonlendir3.Enabled = false;
            timer3.Start();
        }

        private void btnSiparisiYonlendir4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int _calisanindex2 = rnd.Next(0, lstCalisan.Items.Count);
            calisan = CalisaniUretimeGonder(_calisanindex2, lstCalisan.Items);
            uretimHatti4.Text = calisan.AdSoyad.ToString();
            Siparis _yeniSiparis = siparisRepository.SiparisOlustur((Urun)cmbKahveler.SelectedItem, (EkstraMalzeme)cmbEkstralar.SelectedItem);

            lblSure.Text = _yeniSiparis.ToplamSure.ToString();

            DialogResult dr = MessageBox.Show($"Sipariþ yönlendirildi. Bekleme Süresi: {lblSure.Text} Dakika", "Bilgi Ekraný", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSiparisiYonlendir4.Enabled = false;
            timer4.Start();
        }

        private void btnKasayaGonder_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int _calisanindex = rnd.Next(0, 4);
            CalisaniKasayaGonder(_calisanindex, lstCalisan.Items);
            btnKasayaGonder.Enabled = false;
        }

        KahveRepository kahveRepository = new KahveRepository();
        EkstraRepository ekstraRepository = new EkstraRepository();
        private void KahveListele()
        {
            foreach (Urun kahve in kahveRepository.Urunler())
            {
                cmbKahveler.Items.Add(kahve);
            }
            cmbKahveler.Items.Insert(0, "Lütfen Seçiniz...");
            cmbKahveler.SelectedIndex = 0;
        }

        private void EkstraListele()
        {
            foreach (EkstraMalzeme ekstra in ekstraRepository.EkstraMalzemeler())
            {
                cmbEkstralar.Items.Add(ekstra);
            }
            cmbEkstralar.Items.Insert(0, "Lütfen Seçiniz...");
            cmbEkstralar.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int _durmaSüresi = Convert.ToInt32(lblSure.Text) * 1000 *60;
            timer1.Interval = _durmaSüresi;

            DialogResult dr = MessageBox.Show($"Sipariþ Hazýr", "Bilgi Ekraný", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                timer1.Stop();
                btnSiparisiYonlendir1.Enabled = true;
                lstCalisan.Items.Add(calisan);
                uretim1.Text = string.Empty;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int _durmaSüresi = Convert.ToInt32(lblSure.Text) * 1000 * 60;
            timer2.Interval = _durmaSüresi;

            DialogResult dr = MessageBox.Show($"Sipariþ Hazýr", "Bilgi Ekraný", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                timer2.Stop();
                btnSiparisYonlendir2.Enabled = true;
                lstCalisan.Items.Add(calisan);
                uretim2.Text = string.Empty;

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int _durmaSüresi = Convert.ToInt32(lblSure.Text) * 1000 * 60;
            timer3.Interval = _durmaSüresi;

            DialogResult dr = MessageBox.Show($"Sipariþ Hazýr", "Bilgi Ekraný", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                timer3.Stop();
                btnSiparisiYonlendir3.Enabled = true;
                lstCalisan.Items.Add(calisan);
                uretimHatti3.Text = string.Empty;

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int _durmaSüresi = Convert.ToInt32(lblSure.Text) * 1000 * 60;
            timer4.Interval = _durmaSüresi;

            DialogResult dr = MessageBox.Show($"Sipariþ Hazýr", "Bilgi Ekraný", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                timer4.Stop();
                btnSiparisiYonlendir4.Enabled = true;
                lstCalisan.Items.Add(calisan);
                uretimHatti4.Text = string.Empty;

            }
        }
    }
}