using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotKullanarakGirilen2sayininBolumuBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // METOT KULLANARAK KULLANICININ GİRMİŞ OLDUĞU 2 SAYIYI ÖNCE ÇARPIP SONRA 2 YE BÖLEN 
            // VE ÇIKAN SONUÇ 30 TAN BÜYÜKSE BÜYÜKTÜR 
            // DEĞİLSE KÜÇÜKTÜR YAZAN PROGRAMI KODLAYALIM..

            Console.WriteLine("Lütfen Sayıyı Giriniz : ");
            int girilenSayi = int.Parse(Console.ReadLine());

            int MetottanGelenDeger = islem (girilenSayi);

            if (MetottanGelenDeger > 30)
            {
                Console.WriteLine("Girdiğiniz Sayının Sonucu 30'dan büyüktür.");
            }

            else
            {
                Console.WriteLine("Girdiğiniz Sayının Sonucu 30'dan küçüktür.");
            }
            Console.ReadLine();


        }

        static int islem (int sayi)
            {
                return sayi* sayi /2;
            }
    }

}
