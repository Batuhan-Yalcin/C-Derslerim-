using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DahaKolayPropertyKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Daha Kolay Yani Kod Kalabalığı yapmadan Property Nasıl Kullanılır Birlikte İnceleyelim..


            Ogrenci ogrenci1 = new Ogrenci();   
            ogrenci1.kilo1 = 70;
            ogrenci1.kilo2 = 70;

            Console.WriteLine("Property Olan Kilo : " + ogrenci1.kilo1); 
            Console.WriteLine("Değişken Olan Kilo : " + ogrenci1.kilo2);
             
            // Çıktı : 2 SİNDEDE 85 YAZDI VE 2 SİDE DEĞİŞKEN OLARAK GELDİ HİÇBİR FARKI YOK 

            Console.ReadLine();

        }
    }
}
