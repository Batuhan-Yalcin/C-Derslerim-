using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticİleMetotKullanimi
{
    public class Personel
    {

        public static void isimSoyisimYazdir()
        {
            Console.WriteLine("Batuhan Yalçın.");
        }

        public static void Toplama(int sayi1, int sayi2)
        {
            Console.WriteLine("Sayıların Toplamı : " + (sayi1+ sayi2));
        }

    }
}
