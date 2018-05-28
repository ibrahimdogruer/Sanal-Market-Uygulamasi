using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Uygulaması
{
    public class Urun
    {
        public string Kategori { get; set; }
        public string AltKategori { get; set; }
        public int Id { get; set; }

        public string SeriNo { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Miktar { get; set; }
        public decimal Maliyet { get; set; }
        public decimal SatisFiyati { get; set; }
        public string UrunAciklamasi { get; set; }



        public Urun(string value)
        {
            this.SeriNo =this.Kategori+value;
        }
        public Urun()
        {

        }

    }
}
