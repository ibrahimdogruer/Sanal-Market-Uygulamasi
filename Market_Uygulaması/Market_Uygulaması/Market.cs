using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Uygulaması
{
    public class Market
    {
        public decimal Gelir { get; set; }
        public decimal Gider { get; set; }
        public decimal Kar { get; set; }
        public Market()
        {
            GomlekDugum.veri = Gomleklist;
            GomlekDugum.Adı = "GÖMLEK";

            PantolonDugum.veri = Pantolonlist;
            PantolonDugum.Adı = "PANTOLON";

            TshirtDugum.veri = Tshirtlist;
            TshirtDugum.Adı = "TSHİRT";


            LaptopDugum.veri = Laptoplist;
            LaptopDugum.Adı = "LAPTOP";

            MasaustuDugum.veri = Masaustulist;
            MasaustuDugum.Adı = "Masaüstü";

            NotebookDugum.veri = Notebooklist;
            NotebookDugum.Adı = "Notebook";

            FırınDugum.veri = Fırınlist;
            FırınDugum.Adı = "FIRIN";

            BuzdolabıDugum.veri = Buzdolabılist;
            BuzdolabıDugum.Adı = "BUZDOLABI";

            CamasirMakinasiDugum.veri = CamasirMakinasilist;
            CamasirMakinasiDugum.Adı = "ÇAMAŞIR MAKİNASI";
            // yukarıda düğümlerin verilerinin(listelerinin) ve isimlerinin atanması yapılmıştır..

            // kategorileri(agaçları)  Kategori listesine ekliyorum
            Kategoriler.Add(Bilgisayar);
            Kategoriler.Add(BeyazEsya);
            Kategoriler.Add(GiyimUrunleri);
           
            //Altkategorileri kategorilerimize ekliyoruz..
            Bilgisayar.Ekle(MasaustuDugum);
            Bilgisayar.Ekle(LaptopDugum);
            Bilgisayar.Ekle(NotebookDugum);


            BeyazEsya.Ekle(FırınDugum);
            BeyazEsya.Ekle(BuzdolabıDugum);
            BeyazEsya.Ekle(CamasirMakinasiDugum);

            GiyimUrunleri.Ekle(GomlekDugum);
            GiyimUrunleri.Ekle(PantolonDugum);
            GiyimUrunleri.Ekle(TshirtDugum);

            // altkategorileri agaçlarla beraber özel oluşturduğumuz altkategori listesini ekliyorum
            AltKategoriler.Add(MasaustuDugum);
            AltKategoriler.Add(LaptopDugum);
            AltKategoriler.Add(NotebookDugum);
            AltKategoriler.Add(FırınDugum);
            AltKategoriler.Add(BuzdolabıDugum);
            AltKategoriler.Add(CamasirMakinasiDugum);
            AltKategoriler.Add(GomlekDugum);
            AltKategoriler.Add(PantolonDugum);
            AltKategoriler.Add(TshirtDugum);
        }
        public List<IkiliAgac> Kategoriler = new List<IkiliAgac>();
        // Agaclardan oluşan bir liste yarattık kategorileri temsil eden!

        public List<İkiliAramaAgacDugumu> AltKategoriler = new List<İkiliAramaAgacDugumu>();
        

        public IkiliAgac Bilgisayar = new IkiliAgac("Bilgisayar");
        public IkiliAgac BeyazEsya = new IkiliAgac("Beyaz Eşya");
        public IkiliAgac GiyimUrunleri = new IkiliAgac("Giyim Ürünleri");

        List<Urun> Laptoplist = new List<Urun>();
        List<Urun> Masaustulist = new List<Urun>();
        List<Urun> Notebooklist = new List<Urun>();

        // Bilgisayar Kategorisinin Dugumleri(Listeleri).

        List<Urun> Fırınlist = new List<Urun>();
        List<Urun> Buzdolabılist = new List<Urun>();
        List<Urun> CamasirMakinasilist = new List<Urun>();
        // BeyazEsya kategorisinin Dugumleri(Listeleri).

        List<Urun> Gomleklist = new List<Urun>();
        List<Urun> Pantolonlist = new List<Urun>();
        List<Urun> Tshirtlist = new List<Urun>();

        İkiliAramaAgacDugumu GomlekDugum = new İkiliAramaAgacDugumu();
        İkiliAramaAgacDugumu PantolonDugum = new İkiliAramaAgacDugumu();
        İkiliAramaAgacDugumu TshirtDugum = new İkiliAramaAgacDugumu();

        İkiliAramaAgacDugumu LaptopDugum = new İkiliAramaAgacDugumu();
        İkiliAramaAgacDugumu MasaustuDugum = new İkiliAramaAgacDugumu();
        İkiliAramaAgacDugumu NotebookDugum = new İkiliAramaAgacDugumu();


        İkiliAramaAgacDugumu FırınDugum = new İkiliAramaAgacDugumu();
        İkiliAramaAgacDugumu BuzdolabıDugum = new İkiliAramaAgacDugumu();
        İkiliAramaAgacDugumu CamasirMakinasiDugum = new İkiliAramaAgacDugumu();
                        

        public void KategoriEkle(string isim)
        {
             Kategoriler.Add(new IkiliAgac(isim));

        }
        
        public void UrunEkle(Urun urun)
        {
            İkiliAramaAgacDugumu node= new İkiliAramaAgacDugumu();
          

            foreach (IkiliAgac tree in Kategoriler)
            {  
                if (tree.Isim == urun.Kategori)// İF'E KATEGORİYİ BULDUGUNDA GİRECEK!!
                {   
                      foreach(İkiliAramaAgacDugumu temp in AltKategoriler)
                    {   if (temp.Adı == urun.AltKategori)
                        {
                            node = temp;
                            break;
                        }
                    }
                  
                      // urunlere id atanacak
                    tree.AraImp(node.Id).UrunEkle(urun);
                    break;
                }

            }

        }
        public void UrunSil(Urun urun)
        {
            İkiliAramaAgacDugumu temp= new İkiliAramaAgacDugumu();
            List<Urun> Gecici;
          
            foreach (IkiliAgac tree in Kategoriler)
            {
                if (tree.Isim == urun.Kategori)
                {
                    foreach (İkiliAramaAgacDugumu node in AltKategoriler)
                    {
                        if (node.Adı == urun.AltKategori)
                            temp = node;

                    }
                    Gecici= tree.AraImp(temp.Id).veri;
                    foreach (Urun urun1 in Gecici)
                    {
                        if (urun1.SeriNo == urun.SeriNo)
                        {
                            Gecici.Remove(urun1);
                            break;
                        }
                    }
                }
            }

        }
        public void UrunGuncelle(Urun EskiUrun, Urun YeniUrun)
        {
            İkiliAramaAgacDugumu temp = new İkiliAramaAgacDugumu();
            foreach (IkiliAgac tree in Kategoriler)
            {
                if (tree.Isim == EskiUrun.Kategori)
                {   
                     foreach (İkiliAramaAgacDugumu dugum in AltKategoriler)
                    {
                        if (EskiUrun.AltKategori == dugum.Adı)
                            temp = dugum;

                    }
                     
                    List<Urun> GeciciListe = tree.AraImp(temp.Id).veri;
                    foreach (Urun urun1 in GeciciListe)
                    {
                        if (urun1.AltKategori == EskiUrun.AltKategori)
                        {// GÜNCElleme de yeni ıd atanmayacağı için direk listeye ulaşarak işlemleri burada gerçekleştiriyoruz.
                            int keeper;
                            keeper = urun1.Id;
                            GeciciListe.Remove(urun1);
                            YeniUrun.Id = keeper;
                            GeciciListe.Add(YeniUrun);
                            break;
                        }
                    }
                }
            }
        }
        public List<IkiliAgac> KategoriListele()
        {
            return this.Kategoriler;

        }
        public List<İkiliAramaAgacDugumu> AltKategoriListele(string isim)
        {
            List<İkiliAramaAgacDugumu> AltKategoriler = new List<İkiliAramaAgacDugumu>();
            foreach (IkiliAgac tree in Kategoriler)
            {
                if (tree.Isim == isim)
                {
                   
                    AltKategoriler=tree.Dugumler;
                }

            }
            return AltKategoriler;
        }

       public Urun UrunAra(string seri, string kategori, string altkategori)
        {
            Urun tempurun = new Urun() ;
            İkiliAramaAgacDugumu Node = new İkiliAramaAgacDugumu();
            foreach (IkiliAgac tree in Kategoriler)
            {   if(tree.Isim==kategori)
                {
                     foreach(İkiliAramaAgacDugumu dugum in AltKategoriler)
                    {  if (altkategori == dugum.Adı)
                            Node = dugum;
                    }


                    foreach ( Urun  urun in tree.AraImp(Node.Id).veri)
                    {
                        if (seri == urun.SeriNo)
                        {
                            tempurun = urun;
                            
                        }
                          
                    }
                }


            }
            return tempurun;
         }

        public IkiliAgac KategoriBul(string isim)
        {
            IkiliAgac temptree = new IkiliAgac();
            foreach (IkiliAgac tree in Kategoriler)
            {   if(tree.Isim==isim)
                {
                    temptree = tree;
                }
            }
            return temptree;
        }

        public İkiliAramaAgacDugumu AltKategoriBul(string isim)
        {
            İkiliAramaAgacDugumu node = new İkiliAramaAgacDugumu();
            foreach (İkiliAramaAgacDugumu temp in AltKategoriler)
            {
                if (temp.Adı == isim)
                {
                    node = temp;
                }
            }
            return node;
        }



    }


}
