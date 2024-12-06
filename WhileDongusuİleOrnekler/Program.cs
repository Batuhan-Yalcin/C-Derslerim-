using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusuİleOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // While Döngüsü İle 1'den 10 ' a kadar olan sayıları ekrana yazdıralım 
            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }
            
            // 100'den 0'a kadar olan sayıların çift olanlarını büyükten küçüğe yazdıralım..

            int i = 100; // i değişkeni 100'den başlasın

            while (i >= 0) // i değişkeni 0 a gelene kadar dönmeye devam etsin.
            {
                Console.WriteLine(i); // i değişkenini ekrana yazdır.
                i -= 2; // i yi her defasında 2 azalt.

            }



            Console.ReadLine();
        }
    }
}
    