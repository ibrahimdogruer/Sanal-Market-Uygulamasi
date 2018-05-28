using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Uygulaması
{
    public partial class FormPersonel : Form
    {
       public  Market m = new Market();
        Random random = new Random();
        public FormPersonel()
        {
            InitializeComponent();
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        { 
            
            foreach (IkiliAgac tree in m.KategoriListele())
            {
                
                cmbKategori.Items.Add(tree.Isim);
                cmbKategoriSec.Items.Add(tree.Isim);
            }

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
                cmbAltKategori.Items.Clear();
                foreach (İkiliAramaAgacDugumu key in m.AltKategoriListele(cmbKategori.Text))
                {
                    cmbAltKategori.Items.Add(key.Adı);

                }
            
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun(random.Next(0, 100).ToString());
            urun.Kategori = cmbKategori.Text;
            urun.AltKategori = cmbAltKategori.Text;
            urun.Marka = txtMarka.Text;
            urun.Model = txtModel.Text;
            urun.Miktar = Convert.ToInt16(txtMiktar.Text);
            urun.Maliyet = Convert.ToDecimal(txtMaliyet.Text);
            urun.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
            urun.UrunAciklamasi = txtAciklama.Text;

            m.UrunEkle(urun);
            MessageBox.Show("Ürün SeriNo: "+urun.SeriNo);

        }

        Urun temp = new Urun();
        private void btnAra_Click(object sender, EventArgs e)
        {
            // yukardaki satıra sadece altkategorinin ıd sine ihtiyacımız olduğu için yazmak zorunda kaldım
            // normalde altkategorilere ağaç üzerinden erişim yapmaktadır..

            temp =m.UrunAra(txtSeriNo.Text, txtKategoriAra.Text,txtAltKategoriAra.Text);
             
            // URUNU BULDUKDAN SONRA TEXTBOXLARA YAZDIRMA İŞLEMİ ALT TARAFDA GEÇİYOR
            txtMarka.Text = temp.Marka;
            txtMiktar.Text = temp.Miktar.ToString();
            txtModel.Text = temp.Model;
            txtMaliyet.Text = temp.Maliyet.ToString();
            txtSatisFiyati.Text = temp.SatisFiyati.ToString();
            txtAciklama.Text = temp.UrunAciklamasi;
            cmbKategori.Text = temp.Kategori;
            cmbAltKategori.Text = temp.AltKategori;

            

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Urun YeniUrun = new Urun();
            YeniUrun = temp;
            YeniUrun.AltKategori = cmbAltKategori.Text;
            YeniUrun.Kategori = cmbKategori.Text;
            YeniUrun.Maliyet = Convert.ToDecimal(txtMaliyet.Text);
            YeniUrun.Marka = txtMarka.Text;
            YeniUrun.Model = txtModel.Text;
            YeniUrun.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
            YeniUrun.Miktar = Convert.ToInt16(txtMiktar.Text);
            YeniUrun.UrunAciklamasi = txtAciklama.Text;

            m.UrunGuncelle(temp, YeniUrun);
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            m.UrunSil(temp);
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            if (m.Gelir == 0)
            {
                txtGelir.Text = "Satış Gerçekleşmedi";
                txtGider.Text = "Satış Gerçekleşmedi";
                txtKar.Text = "Satış Gerçekleşmedi";
            }
            else
            {
                txtGelir.Text = m.Gelir.ToString();
                txtGider.Text = m.Gider.ToString();
                txtKar.Text = m.Kar.ToString();
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 Anasayfa = new Form1();
            Anasayfa.Show();
            this.Hide();

        }

        private void btnKategoriEkle_Click_1(object sender, EventArgs e)
        {
            m.KategoriEkle(txtYeniKategori.Text);

            foreach (IkiliAgac agac in m.KategoriListele())
            {
                if (agac.Isim == txtYeniKategori.Text)
                    agac.PreOrder();
            }

            cmbKategori.Items.Add(txtYeniKategori.Text);
            cmbKategoriSec.Items.Add(txtYeniKategori.Text);
            MessageBox.Show("Kategori Eklenmiştir.");
        }

        private void btnAltKategoriEkle_Click_1(object sender, EventArgs e)
        {
            IkiliAgac temp = m.KategoriBul(cmbKategoriSec.Text);
            İkiliAramaAgacDugumu tempnode = new İkiliAramaAgacDugumu();
            tempnode.Adı = txtYeniAltKategori.Text;
            temp.Ekle(tempnode);
            m.AltKategoriler.Add(tempnode);// BURADA AGAC DAN SONRA LİSTEMİZEDE EKLEME YAPIYORUZ..

            MessageBox.Show("Alt Kategori Eklenmiştir.");
        }

    }
}
