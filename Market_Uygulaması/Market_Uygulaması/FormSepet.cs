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
    public partial class FormSepet : Form
    {
        public List<Urun> Sepet = new List<Urun>();
        public Market market = new Market();
        public FormSepet()
        {
            InitializeComponent();
        }

        private void FormSepet_Load(object sender, EventArgs e)
        {
            string str = "";
            foreach (Urun Prototip in Sepet)
            { str =Prototip.SeriNo+"   "+Prototip.Kategori + " " + Prototip.AltKategori + " " + Prototip.Marka + "  " + Prototip.Model +
                   Prototip.SatisFiyati;
                lboxSepet.Items.Add(str);
            }
            


        }

        private void btnSepet_Click(object sender, EventArgs e)
        {


            if ((txtSepetKategori.Text == "" && txtSepetAltKategori.Text == "" && txtSeriNo.Text == "") || txtSeriNo.Text == ""
                || txtSepetAltKategori.Text == "" || txtSepetKategori.Text == "")
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
            else
            {

                Urun sUrun = market.UrunAra(txtSeriNo.Text, txtSepetKategori.Text, txtSepetAltKategori.Text);
                Sepet.Remove(sUrun);
                string str = "";
                lboxSepet.Items.Clear();
                foreach (Urun Prototip in Sepet)
                {
                    str = Prototip.SeriNo+"   "+Prototip.Kategori + " " + Prototip.AltKategori + " " + Prototip.Marka + "  " + Prototip.Model +
                         Prototip.SatisFiyati;
                    lboxSepet.Items.Add(str);
                }
                
            }
        }

        private void btnSatınAl_Click(object sender, EventArgs e)
        {
            if (Sepet.Count == 0)
            {
                MessageBox.Show("Sepette ürün bulunmamaktadır.");
            }
            else
            {
                foreach (Urun urun in Sepet)
                {
                    market.AltKategoriBul(urun.AltKategori).veri.Remove(urun);// urun,altkategori bulunup o listeye girilip kaldırıldı
                    market.Kar += (urun.SatisFiyati) - (urun.Maliyet);
                    market.Gelir += urun.SatisFiyati;
                    market.Gider += urun.Maliyet;
                }
                lboxSepet.Items.Clear();
                lboxSepet.Items.Add("Alışveriş Tamamlanmıştır");
            }
        }

    }
}
