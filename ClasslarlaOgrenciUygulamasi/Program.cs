using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslarlaOgrenciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;

            // Bir tane öğrencimiz olacak.. öğrencinin öğrenciNo , isim soyisim , vize1 , vize2, final ve okulİsmi adında değişkenlerimiz olacak.
            // ERİŞİM BELİRLEYİCİLERİ PRİVATE YAPACAĞIZ YAPICI METOT KULLANARAK DEĞİŞKENLERE DEĞERLERİ ATAYACAĞIZ.
            // ogrenciBilgileriGoster() metodu olacak öğrencinin bilgilerini göreceğiz.
            // OgrenciOrtalamasiBul() metodu olacak
            // okulGetir() metodu olacak.

            // ÖĞRENCİNİN SEÇİMİNE GÖRE ŞU İŞLEMLERİ YAPACAĞIZ : 
            // 1- ÖĞRENCİ BİLGİLERİ GÖSTER.
            // 2- ÖĞRENCİ ORTALAMASI GÖSTER.
            // 3- ÖĞRENCİNİN OKULUNU ÖĞREN
            // 4- ÇIKIŞ YAP



            ogrenci Ogrenci1 = new ogrenci(190758 , "Batuhan", "Yalçın" , 55, 70, 100,"Nişantaşı Üniversitesi");

            Console.WriteLine("UYGULAMAMIZA HOŞGELDİNİZ.. ");
            Console.WriteLine("YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ : ");
            
            


            while (kontrol)
            {
                islemleriGoster();
                
                string secim = Console.ReadLine();

                switch (secim)
                {

                    case "1":
                        Ogrenci1.ogrenciBilgileriGoster();
                        Console.WriteLine("************************************");
                        break;

                    case "2":
                      double ogrenciOrtalama =  Ogrenci1.ogrenciOrtalamasiBul();
                        Console.WriteLine("Öğrencinin Ortalaması : " +ogrenciOrtalama);
                        Console.WriteLine("************************************");
                        break;

                    case "3":
                        Ogrenci1.okulGetir();
                        Console.WriteLine("************************************");
                        break;

                        case "4":
                        kontrol = false;
                        break;
                }
            }

            


           

           
            


        }
        static void islemleriGoster()
        {
            Console.WriteLine("1 - Öğrenci Bilgileri Göster.");
            Console.WriteLine("2 - Öğrenci Ortalaması Göster.");
            Console.WriteLine("3 - Öğrenci Okulunu Göster.");
            Console.WriteLine("4 - Çıkış Yap.");

            

        }
    }
}
