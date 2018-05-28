using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Uygulaması
{
    public class HashMap
    {
        int TABLE_SIZE ;
        HashEntry[] table;
        public HashMap(int value)
        {
            this.TABLE_SIZE = value;
            table = new HashEntry[TABLE_SIZE];
            for (int i = 0; i < value; i++)
                table[i] = null;

        }
        public void AddUrun(Urun urun,int key)
        {
            int hash = (key % TABLE_SIZE);
            while (table[hash] != null && table[hash].Anahtar != key)
                hash = (hash + 1) % TABLE_SIZE;
            table[hash] = new HashEntry(urun.Marka + "   " + urun.Model,key);
        }

        public string GetUrun(int key)
        {
            int hash = (key % TABLE_SIZE);
            while (table[hash] != null && table[hash].Anahtar != key)
                hash = (hash + 1) % TABLE_SIZE;
            if (table[hash] == null)
                return null;
            else
                return table[hash].Deger;
        }
        
    }
}
