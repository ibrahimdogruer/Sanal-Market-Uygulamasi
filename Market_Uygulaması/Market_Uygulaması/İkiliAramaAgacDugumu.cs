using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Uygulaması
{
     public class İkiliAramaAgacDugumu
    {
        public string Adı { get; set; }
        public int Id { get; set; }

        public int UrunIdSayac = 0;
        public List<Urun> veri;
        public İkiliAramaAgacDugumu sol { get; set; }
        public İkiliAramaAgacDugumu sag { get; set; }

        public İkiliAramaAgacDugumu(List<Urun> value, int id)
        {
            this.veri = value;
            this.Id =id;
        }

        public İkiliAramaAgacDugumu()
        {

        }

        public void UrunEkle(Urun urun)
        {
            urun.Id = UrunIdSayac;
            veri.Add(urun);
            UrunIdSayac++;
        }


    }
}
