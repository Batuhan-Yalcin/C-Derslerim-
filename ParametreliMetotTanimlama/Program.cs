using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliMetotTanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametre alan - Geriye değer döndürmeyen metot tanımlama 

            Topla(5, 10); // Parametre aldığı için çağırdığımızda içeriye 2 adet int değer girmemiz gerekir girmezsek hata alırız.
            carp(5, 10, 10); // burada da hangi sayıları çarpmak istediğimizi girdik 
            AdiYazdir("Batu", "Ahmet", "Mehmet");
            ondalikliSayi(1.55, 2.69, 3.1);

        }

        static void Topla(int x, int y) // Topla'dan sonraki parantezdeki int x , int y int veri tipinde parametre almasını istediğimizi belirttik buna parametre denir
        {
            Console.WriteLine("Gönderilen Sayıların toplamı : " + (x+y));
            Console.ReadLine();
        }

        static void carp (int x , int y , int z) // 3 adet sayının çarpımını veren metotu yazalım 
        {
            Console.WriteLine("Gönderilen Sayıların Çarpımı : " + (x * y * z)); // x * y * z yaptık 
            Console.ReadLine();
        }

        static void AdiYazdir (string a, string b  , string c)
        {
            Console.WriteLine("Gönderilen İsimler : " + (a + b + c));
            Console.ReadLine(); 
        }

        static void ondalikliSayi (double a , double b , double c)
        {
            Console.WriteLine("Gönderilen Ondalıklı Sayılar : " + (a + b - c));
            Console.ReadLine();
        }
    }
}
