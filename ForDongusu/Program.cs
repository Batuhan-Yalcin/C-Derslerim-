using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Döngünün Çalışma Mantığı Şu Şekildedir ; 
            // for ( int degiskenadi = baslangicDegeri ; koşul ; arttırma- azaltma)
            // {
            // Çalışacak Kodlar
            // }

            // 1 den 15'e kadar olan sayıları alt alta yazdıran Programı Kodlayalım..

            for(int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Döngüde Dönen Sayılar : " +i);
            }

            // 1 den 10' a kadar olan sayıların çift olanlarını ekrana yazdıran programı kodlayalım..

            for (int b = 0; b <= 10; b += 2)
            {
                Console.WriteLine("1 İle 10 arasında olan Çift Sayılar Şunlardır : " +b);
            }

            // 1 den 10'a kadar olan tek sayıları ekrana yazdıran programı kodlayalım..
            for(int c = 1; c <= 10; c+=2)
            {
                Console.WriteLine("1 ile 10 arasında olan tek sayılar şunlardır : " +c );
            }

            // 1 den 10 ' a kadar olan sayıları toplayan programı kodlayalım..

            int toplam = 0;

            for ( int d = 1; d <= 10; d++)
            {
                toplam += d ;
            }
            Console.WriteLine("1'den 10'a kadar olan sayıların toplamı : " +toplam);

            Console.ReadLine();
            

        }
    }
}
