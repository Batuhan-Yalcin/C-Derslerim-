using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_1
{
    public class Araba
    {
        private string arabaModeli;
        private string arabaMarka;
        private int arabaFiyat;


        public string getarabaModeli()
        {
            return arabaModeli;
        }

        public string getarabaMarka()
        {
            return arabaMarka;
        }
        public int getarabaFiyat()
        {
            return arabaFiyat;
        }

        public void setarabaModeli(string arabaModeli)
        {
            this.arabaModeli = arabaModeli; 
        }

        public void setarabaMarka(string arabaMarka)
        {
            this.arabaMarka = arabaMarka;
        }

        public void setarabaFiyat(int arabaFiyat)
        {
            this.arabaFiyat = arabaFiyat;
        }

  


    }
}
