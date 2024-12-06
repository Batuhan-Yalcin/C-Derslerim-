using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOrnek2
{
    public class Ogrenci
    {

        private string ad;
        private string soyad;
        private int numara;

        public String Ad
        {
            get
            {
                return ad;
            }
           
        }

        public String Soyad
        {
            get
            {
                return soyad;
            }
        }

        public int Numara
        {
            get
            {
                return numara;
            }
            set
            {
                if(value >=0)
                numara = value;
            }
        }

       public Ogrenci(string ad, string soyad)
        {
           this.ad = ad;
            this.soyad = soyad;
        }

        public string TamAd()
        {
            return ad + " " + soyad;
        }
       
    }
}
