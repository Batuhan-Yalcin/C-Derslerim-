using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyİleKapsullemeKullanimi
{
    public class Musteri
    {
        

        private int kilo;

        public int PropKilo { 
        

        get
            {
                return kilo;
            }

            set
            {

                kilo = value; // VALUE ANAHTAR KELİMESİ KULLANICININ GİRMİŞ OLDUĞU DEĞERİ TUTAN ANAHTAR KELİMEDİR.
            }
        }

    }
}
