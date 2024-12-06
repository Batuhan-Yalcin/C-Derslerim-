using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1'den 10'a kadar olan sayıları Ekrana Yazdıralım (Do - while döngüsü ile )

            int a = 1; // a değişkenine 1 değerini atadık.

            do   //    do yazıp 2 kere tab a bastık ve do while iskeletimiz oluştu 
            {
                Console.WriteLine(a); // a değişkenini ekrana yazdırdık.
                a++;                  // a yı her defasında 1 arttır dedik.
            } while (a<=10);          // while' ın içine koşulumuzu belirttik 10 a kadar dönmesini istedik..


            


            // 1' den 100'e kadar olan sayıların toplamını ekrana yazdıralım. (Do - while Döngüsü ile)

            int b = 1; // b değişkenine 1 değerini atadık.
            int toplam = 0; // toplam diye değişken oluşturduk ve 0 değerini atadık
            do
            {
                toplam += b; // toplam += b yaparak b değişkenini her defasında 1 topla toplam değişkenine ata dedik
                b++;         // b değişkenini her defasında 1 arttırdık.
                
            }
            while (b <= 100);   // b değişkeninin 100 ' e kadar dönmesini belirttik koşulda
            Console.WriteLine("1'den 100'e kadar olan sayıların toplamı : " +toplam); // toplam değişkenini ekrana yazdırdık.
            Console.ReadLine();
        }
    }
}
