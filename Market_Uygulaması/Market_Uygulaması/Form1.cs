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
    public partial class Form1 : Form
    {
        Market market = new Market();
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            Urun urun1 = new Urun(ran.Next(0,100).ToString());
            urun1.Kategori = "Bilgisayar";
            urun1.AltKategori = "LAPTOP";
            urun1.Maliyet = 2000;
            urun1.SatisFiyati = 3000;
            urun1.Model = "X550V";
            urun1.Marka = "ASUS";
            urun1.UrunAciklamasi = "USB GİRİŞİ VARDIR.";

            Urun urun2 = new Urun(ran.Next(0, 100).ToString());
            urun2.Kategori = "Bilgisayar";
            urun2.AltKategori = "LAPTOP";
            urun2.Maliyet = 2000;
            urun2.SatisFiyati = 5000;
            urun2.Model = "Excalibur";
            urun2.Marka = "CASPER";
            urun2.UrunAciklamasi = "USB GİRİŞİ VARDIR.";

            Urun urun3 = new Urun(ran.Next(0, 100).ToString());
            urun3.Kategori = "Bilgisayar";
            urun3.AltKategori = "LAPTOP";
            urun3.Maliyet = 1500;
            urun3.SatisFiyati = 2000;
            urun3.Model = "ABC";
            urun3.Marka = "LENOVO";
            urun3.UrunAciklamasi = "USB GİRİŞİ VARDIR.";

            Urun urun4 = new Urun(ran.Next(0, 100).ToString());
            urun4.Kategori = "Bilgisayar";
            urun4.AltKategori = "LAPTOP";
            urun4.Maliyet = 1500;
            urun4.SatisFiyati = 1200;
            urun4.Model = "YTU";
            urun4.Marka = "SAMSUNG";
            urun4.UrunAciklamasi = "USB GİRİŞİ VARDIR.";

            Urun urun5 = new Urun(ran.Next(0, 100).ToString());
            urun5.Kategori = "Bilgisayar";
            urun5.AltKategori = "LAPTOP";
            urun5.Maliyet = 1500;
            urun5.SatisFiyati = 4000;
            urun5.Model = "PAVİLLİON";
            urun5.Marka = "HP";
            urun5.UrunAciklamasi = "USB GİRİŞİ VARDIR.";

            market.UrunEkle(urun1);
            market.UrunEkle(urun2);
            market.UrunEkle(urun3);
            market.UrunEkle(urun4);
            market.UrunEkle(urun5);
            
             //market.Bilgisayar.PreOrder();
           // MessageBox.Show(market.Bilgisayar.DugumleriYazdir());
            //MessageBox.Show(urun3.SeriNo);
        
            foreach (IkiliAgac tree in market.Kategoriler)
            {
                tree.PreOrder();
            }
        }
          
        private void btnPersonel_Click(object sender, EventArgs e)
        {
            FormPersonel fp = new FormPersonel();

            fp.m = this.market;
            fp.Show();
          //this.Hide();

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FormMusteri frmMüsteri = new FormMusteri();
            frmMüsteri.market = this.market;
            frmMüsteri.Show();
            //this.Hide();
        }
    }
}
