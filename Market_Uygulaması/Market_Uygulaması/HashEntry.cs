using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Uygulaması
{
    public class HashEntry
    {
        private int anahtar;
        private string deger;

        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }

        }
        public string Deger
        {
            get { return deger; }
            set { deger = value; }

        }
        public HashEntry(string deg, int ana)
        {
            anahtar = ana;
            deger = deg;
        }


    }

}
