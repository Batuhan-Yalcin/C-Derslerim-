using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_1
{
    public class Ogrenci
    {
        private string ogrenciAdi;
        private int ogrenciYasi;

        public string getOgrenciAdi()
        {
            return ogrenciAdi;
        }

        public void setOgrenciAdi(string ogrenciAdi)
        {
           this.ogrenciAdi = ogrenciAdi;
        }

        public int getOgrenciYasi()
        {
            return ogrenciYasi;
        }

        public void setOgrenciYasi(int ogrenciYasi)
        {
            this.ogrenciYasi = ogrenciYasi;
        }

    }
}
