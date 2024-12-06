using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DahaKolayPropertyKullanimi
{
    internal class Ogrenci
    {
        public int kilo1 { get; set; } // Property Eğerki Property i böyle yazarsak İçindeki Get ve set metodlarını çağırmadan kullanmaya çalışırsak 
        // Değişkenden Hiçbir Farkı Yoktur.. Kapsülleme Yapamaz...

        public int kilo2;   // Degisken 

    }
}
