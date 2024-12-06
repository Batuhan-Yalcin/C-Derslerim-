using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeGetAndSETMethodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KAPSÜLLEME : KISITLAMA KOYDUĞUMUZ ERİŞİM BELİRLEYİCİLERİNE ERİŞMEK ANLAMINA GELİR.

            // KAPSÜLLEME YAPABİLMEMİZ İÇİN 2 YÖNTEM VARDIR : 
            // 1 - Geter seter Metodları.
            // 2 - Propert ile..

            // GET METODU NE İŞE YARAR ? : GET Metodunu da Değer Çekmek - Almak İçin kullanırız.
            // SET METODU NE İŞE YARAR ? : SET Metodunu Biz Değer Atamak İçin Kullanırız.

            Ogrenci Ogrenci1 = new Ogrenci();

            Ogrenci1.setIsim("Batu"); // get metodunu mainde çağırma
            Ogrenci1.getIsim();       // set metodunu mainde çağırma

            Ogrenci1.SetTc(21925582156);
        long gelenTC = Ogrenci1.getTc(); // Get Metodunu Kullanarak İşlem Yapmak için bir değişkene atama yaptık.

            if (gelenTC == 21925582156) // gelenTC 21925582156 ya eşitse 
            {
                Console.WriteLine("TC KİMLİK NUMARASI DOĞRUDUR."); // TC KİMLİK NUMARASI DOĞRUDUR YAZDIK.
            }
            else
            {
                Console.WriteLine("TC KİMLİK NUMARASI YANLIŞTIR."); // DEĞİLSE TC KİMLİK NO YANLIŞTIR YAZDIK.
            }

            Console.ReadLine();

        }   
    }
}
