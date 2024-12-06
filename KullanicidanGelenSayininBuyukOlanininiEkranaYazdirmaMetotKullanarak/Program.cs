using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanGelenSayininBuyukOlanininiEkranaYazdirmaMetotKullanarak
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. adım - Kullanıcıdan 2 adet sayı alalım. 
            // 2. adım - Hangi sayı büyükse Büyük olanı ekrana yazdıralım.

            Console.Write("Lütfen 1. Sayıyı Giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. sayıyı Giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());

             HangisiBuyuk(sayi1, sayi2);

            Console.ReadLine();
        }

        static void HangisiBuyuk(int x, int y)
        {
            int sonuc = 0;

            if (x > y)
            {
                Console.WriteLine("1. Sayı Daha Büyüktür : " +x);
            }

            else if (x==y)
            {
                Console.WriteLine("İki sayı birbirine eşitttir..");
            }

            else
            {
                Console.WriteLine("2. Sayı Daha Büyüktür : " +y);
            }


          
            
        }
    }
}
