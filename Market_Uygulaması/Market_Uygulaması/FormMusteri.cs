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
    public partial class FormMusteri : Form
    {
       public Market market = new Market();
        List<Urun> Urunler = new List<Urun>();
        FormSepet Sepet = new FormSepet();

        Heap HeapTree = new Heap();
        List<HeapDugumu> SepetUrunleri = new List<HeapDugumu>();
        public FormMusteri()
        {
            InitializeComponent();
        }

     

        private void btnListele2_Click(object sender, EventArgs e)
        {

            lboxUrunler.Items.Clear();
            if ((txtFiyat1.Text == "" && txtFiyat2.Text =="") || txtFiyat1.Text == "" || txtFiyat2.Text == "")
            {
                MessageBox.Show("Lütfen fiyat aralıklarını eksiksiz giriniz.");
            }
            else
            {
                string str = "";
                foreach (IkiliAgac tree in market.KategoriListele())
                {
                    foreach (İkiliAramaAgacDugumu node in tree.Dugumler)
                    {
                        foreach (Urun urun in tree.AraImp(node.Id).veri)
                        {
                            if (urun.SatisFiyati >= Convert.ToDecimal(txtFiyat1.Text) && urun.SatisFiyati <= Convert.ToDecimal(txtFiyat2.Text))
                            {
                                if (!(Urunler.Contains(urun)))
                                    Urunler.Add(urun);
                                str = urun.SeriNo + "   " + urun.Kategori + "  " + urun.AltKategori + "  " + urun.Marka + "  " + urun.Model + "  " + urun.SatisFiyati;
                                lboxUrunler.Items.Add(str);

                            }
                        }

                    }
                }

                if (str == "")
                    MessageBox.Show("Bu fiyat aralığında ürün bulunamadı");
            }

        }

        private void btnListele1_Click(object sender, EventArgs e)
        {

            lboxUrunler.Items.Clear();
            if (txtUrunAdı.Text == null)
            { MessageBox.Show("Lütfen ürün adı giriniz"); }
            else
            {


                string str = "";
                foreach (IkiliAgac tree in market.KategoriListele())// TÜM AGAÇLARI(KATEGORİLERİ) GEZİYOR.
                {
                    foreach (İkiliAramaAgacDugumu node in tree.Dugumler)// AGAÇDAKİ ALTKATEGORİ LİSTESİNİ GEZİYOR
                    {
                        if (node.Adı == txtUrunAdı.Text)
                        {
                            foreach (Urun urun in tree.AraImp(node.Id).veri)//BULUNAN ALTKATEGORİYE DİRE ULAŞAN METOD ÇAĞRILIYOR
                            {
                                if (!(Urunler.Contains(urun)))
                                    Urunler.Add(urun);
                                str = urun.SeriNo + "   " + urun.Kategori + "  " + urun.AltKategori + "  " + urun.Marka + "  " + urun.Model;
                                lboxUrunler.Items.Add(str);
                            }
                        }
                    }
                }

                if (str == "")
                    MessageBox.Show("Aradığınız Alt kategori Bulunamadı");

            }
        }

        private void btnListele3_Click(object sender, EventArgs e)
        {
            IkiliAgac Kategori=market.KategoriBul(txtKategori.Text);
            lboxUrunler.Items.Clear();
            if (txtKategori.Text == "")
            {
                MessageBox.Show("Lütfen Kategori Adı giriniz");
            }
            else
            {
                string str = "";

                foreach (İkiliAramaAgacDugumu dugum in Kategori.Dugumler)
                {
                    foreach (Urun urun in dugum.veri)
                    {
                        if (!(Urunler.Contains(urun)))
                            Urunler.Add(urun);
                        str = urun.SeriNo + "   " + urun.Kategori + "  " + urun.AltKategori + "  " + urun.Marka + "  " + urun.Model;
                        lboxUrunler.Items.Add(str);

                    }

                }
                if (str == "")
                    MessageBox.Show("Böyle bir kategori bulunamadı.");
            }
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            
                      
        }

        private void lboxUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            if ((txtSepetKategori.Text == "" && txtSepetAltKategori.Text == "" && txtSeriNo.Text == "") || txtSeriNo.Text == ""
                || txtSepetAltKategori.Text == "" || txtSepetKategori.Text == "")
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
            else
            {
                Urun sUrun = market.UrunAra(txtSeriNo.Text, txtSepetKategori.Text, txtSepetAltKategori.Text);
                if (sUrun.Marka == null)
                    MessageBox.Show("Ürün bulunamadı");
                else
                {
                    MessageBox.Show(sUrun.Marka);
                    Sepet.market = this.market;
                    Sepet.Sepet.Add(sUrun);
                }
            }
        }

        private void btnListe4_Click(object sender, EventArgs e)
        {   
          
        }


        private void btnSepeteGit_Click(object sender, EventArgs e)
        {
            
            Sepet.Show();
            


        }

        private void btnAra_Click(object sender, EventArgs e)
        {  
            
          
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 Anasayfa = new Form1();
            Anasayfa.Show();
            this.Hide();
        }

        private void btnHeapSepet_Click_1(object sender, EventArgs e)
        {
            if ((txtHeapAltKategori.Text == "" && txtAdet.Text == "") || txtHeapAltKategori.Text == "" || txtAdet.Text == "")
            {
                MessageBox.Show("Lütfen kategori adını ve adet  giriniz.");
            }
            else
            {
                MessageBox.Show("Sepete eklenmiştir.");
                Sepet.market = this.market;
                foreach (HeapDugumu heapnode in SepetUrunleri)
                {
                    Sepet.Sepet.Add(heapnode.Data);

                }

                lboxUrunler.Items.Clear();
            }
        }

        private void btnListe4_Click_1(object sender, EventArgs e)
        {
            lboxUrunler.Items.Clear();
            if ((txtHeapAltKategori.Text == "" && txtAdet.Text == "") || txtHeapAltKategori.Text == "" || txtAdet.Text == "")
            {
                MessageBox.Show("Lütfen kategori adını ve adet  giriniz.");
            }
            else
            {
                İkiliAramaAgacDugumu temp = market.AltKategoriBul(txtHeapAltKategori.Text);
                if (temp.veri == null)
                    MessageBox.Show("Ürün bulunamamıştır.");
                else
                {
                    HeapTree.DiziOlustur(temp.veri.Count);
                    if (Convert.ToInt16(txtAdet.Text) > temp.veri.Count || Convert.ToInt16(txtAdet.Text) <= 0)
                        MessageBox.Show(" 0 ile " + temp.veri.Count + " arasında adet girebilirsiniz ");
                    else
                    {
                        foreach (Urun prototip in temp.veri)
                        {
                            HeapTree.Insert(prototip);
                        }
                        HeapDugumu Node;
                        string str = "";

                        for (int i = 0; i < Convert.ToInt16((txtAdet.Text)); i++)
                        {
                            Node = HeapTree.RemoveMin();
                            SepetUrunleri.Add(Node);
                            //Sepet.Sepet.Add(Node.Data);
                            str = Node.Data.Marka + " " + Node.Data.Model + " " + Node.Data.SatisFiyati;
                            lboxUrunler.Items.Add(str);

                        }

                    }
                }
            }
        }

        private void btnAra_Click_1(object sender, EventArgs e)
        {
            İkiliAramaAgacDugumu Dugum;
            if (txtUrunAra.Text == "")
                MessageBox.Show("Lütfen alt kategori adı giriniz");
            else
            {
                Dugum = market.AltKategoriBul(txtUrunAra.Text);
                if (Dugum.veri == null)
                    MessageBox.Show("Altkategori bulunamadı");
                else
                {
                    HashMap AltKategoriHash = new HashMap(Dugum.veri.Count);
                    foreach (Urun urun in Dugum.veri)
                    {
                        AltKategoriHash.AddUrun(urun, Convert.ToInt16(urun.SeriNo));

                    }

                    foreach (Urun urun in Dugum.veri)
                    {
                        lboxUrunler.Items.Add(AltKategoriHash.GetUrun(Convert.ToInt16(urun.SeriNo)));
                    }
                }
            }
        }
    }
}
