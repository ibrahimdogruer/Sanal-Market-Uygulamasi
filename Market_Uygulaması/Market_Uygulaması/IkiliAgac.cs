using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Uygulaması
{
    public class IkiliAgac
    {
        private İkiliAramaAgacDugumu kok;
        public List<İkiliAramaAgacDugumu> Dugumler = new List<İkiliAramaAgacDugumu>();
        private string dugumler;
        public string Isim { get; set; }
        public int AltKategoriIdSayac = 0;

        public IkiliAgac(İkiliAramaAgacDugumu dugum)
        {
            this.kok = dugum;
        }
        
        public IkiliAgac(string value)
        {
            this.Isim = value;
        }
        public IkiliAgac()
        {
                
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }
        private void ListeOLustur(İkiliAramaAgacDugumu Dugum)
        {
            Dugumler.Add(Dugum);
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            ListeOLustur(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);

        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            ListeOLustur(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAramaAgacDugumu dugum)
        {
            dugumler += dugum.Adı + " ";
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
            ListeOLustur(dugum);
        }

        public void Ekle(İkiliAramaAgacDugumu deger)
        {
            İkiliAramaAgacDugumu tempparent = new İkiliAramaAgacDugumu();
            İkiliAramaAgacDugumu tempsearch = kok;
            deger.Id = AltKategoriIdSayac;
            while (tempsearch != null)
            {
                tempparent = tempsearch;
                if (deger.Id < tempsearch.Id)
                    tempsearch = tempsearch.sol;
                else if (deger.Id == tempsearch.Id)
                    return;
                else
                    tempsearch = tempsearch.sag;

            }
            
            if (kok == null)
            {
                kok = deger;
            }
            if (deger.Id < tempparent.Id)
                tempparent.sol = deger;
            else
            {
                tempparent.sag = deger;
            }


            AltKategoriIdSayac++;//Altkategori ıd sini otomatik vermesi için agaca idsayac ekledim her ekleme yaptığında 1 arttıracak
        }

        public İkiliAramaAgacDugumu AraImp(int Aranan)
        {
            return Ara(Aranan, kok);

        }
        private İkiliAramaAgacDugumu Ara(int Aranan, İkiliAramaAgacDugumu dugum)
        {

            if (dugum == null)
                return null;
            if (Aranan < dugum.Id)
                return Ara(Aranan, dugum.sol);
            else if (Aranan > dugum.Id)
                return Ara(Aranan, dugum.sag);
            else
                return dugum;


        }
      
    }

}

