using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarisikSoruCozme
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CHAT GPT NİN 1. SORUSU CEVABI 

            /*
            int sayi = 5;
            int sonuc = sayi * 2;
            Console.WriteLine("Çarpma işleminin sonucu : " + sonuc);

            // CHAT GPT NİN 2. SORUSU CEVABI 
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int girilenSayi = int.Parse(Console.ReadLine());

            if (girilenSayi < 0)
            {
                Console.WriteLine("Sayı negatiftir");
            }
            else if (girilenSayi == 0)
            {
                Console.WriteLine("Sayı 0 dır.");
            }
            else
            {
                Console.WriteLine("Sayı pozitiftir.");
            }

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            */

            Console.WriteLine("Bir sayı giriniz : ");
            int girilenSayyyii = int.Parse(Console.ReadLine());

            kareBulma(girilenSayyyii);
            Console.ReadLine();

        }

        static int kareBulma (int x)
        {

            int sonuc = x *x;
            return sonuc;
        }

    }
}
