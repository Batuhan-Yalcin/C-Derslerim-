using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ToString();
            // Convert.ToINT32();
            // int.parse();
            // double.parse();
            // (byte) (int) (char) (long) vs. vs. gibi methodlar ile dönüşüm yapılır


            // TÜR DÖNÜŞÜMLERİ ŞU ŞEKİLDE ÇALIŞIR ; İNT VERİ TİPİNİ DOUBLE A VS ÇEVİRMEMİZE YARAR.

            /* İNT VERİ TİPİNİ BYTE VERİ TİPİNE DÖNÜŞTÜRME 
             * 
            int a = 5; // int veri tipinde 5 değeri atadım.

            byte b = (byte)a; // burada ise görmüş olduğun a değerini al byte veri tipine dönüştür dedim.
            Console.WriteLine(b.GetType()); // GETTYPE İSE BENİM B DEĞİŞKENİMİN TÜRÜ NEDİR DİYE SORARIM VE TÜRÜNÜ VERİR.
            Console.WriteLine(b);


           // LONG VERİ TİPİNİ İNT VERİ TİPİNE DÖNÜŞTÜRME 
             * 
            long c = (int)b;
            Console.WriteLine(c.GetType());
            Console.WriteLine(c);


          //  STRİNG VERİ TİPİNİ CHAR VERİ TİPİNE DÖNÜŞTÜRME 
            String ad = "B";
            char k = (char)a;
            Console.WriteLine(k.GetType());
            Console.WriteLine(k);
            

            // STRİNG VERİ TİPİNİ İNT VERİ TİPİNE DÖNÜŞTÜRME.
            string sayi1 = "1";
            string sayi2 = "2";

            // STRİNG İ İNT VERİ TİPİNE DÖNÜŞTÜRMENİN 1. YOLU 

            // int a = int.Parse(sayi1); // parse dönüştürmek demek sayi1 değerini al integer a dönüştür dedim.
            // int b = int.Parse(sayi2); // parse ile sayi 2 değerini al int veri tipine dönüştür dedim.

            // Console.WriteLine(a + b); // a + b yi topla ve ekrana sonucu ver dedim.

            //  Console.WriteLine(sayi1+sayi2); // String 2 ifade toplanmaz 1+2 istemiştim fakat çıktı 12 oldu 

            // STRİNG İ İNT VERİ TİPİNE DÖNÜŞTÜRMENİN 2. YOLU 

            int a = Convert.ToInt32(sayi1); // CONVERT METHODU DA DÖNÜŞTÜRMEK ANLAMINA GELİR 
            int b = Convert.ToInt32(sayi2); // SAYİ 2 Yİ AL İNT VERİ TİPİNE DÖNÜŞTÜR B NİN İÇİNE KOY DEDİM
            Console.WriteLine(a+b);
            

            // İNT VERİ TİPİNDEN STRİNG VERİ TİPİNE DÖNÜŞTÜRME 
            
            int sayi = 5;

            int sayi1 = 10;

            string a = sayi1.ToString(); // Sayi1 i al tostring methodu ile string e dönüştür dedim
            string b = sayi.ToString();  // Sayi2 yi al tostring methodu ile string e dönüştür dedim
            Console.WriteLine(a + b); // Çıktıda 105 cevabını bulduk.

            



            // DOUBLE VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞTÜRME 

            double sayi = 5.22;

            int a = Convert.ToInt32(sayi); // Double ' ı İnt veri tipine dönüştüren method.

            Console.WriteLine(a); // Çıktı'nın Methodu

            Console.WriteLine(a.GetType().Name); // Hangi Veri Tipinde Çıktı Verdiğini Gösteren Gettype Methodu.
            

            // KULLANICIDAN GELEN STRİNG DEĞERİ İNT VERİ TİPİNE DÖNDÜRME . 

            Console.WriteLine("Lütfen Yaşınızı Giriniz : ");

            string kullaniciYasi = Console.ReadLine();
            Console.WriteLine(kullaniciYasi.GetType()); // İLK GELEN GİRİLEN YAŞ DEĞERİNİN HANGİ VERİ TİPİ OLDUĞUNU
            // GÖSTERİR.

            int kullaniciYasiInt = int.Parse(kullaniciYasi); // 1. Yöntem
            int kullaniciYasi2 = Convert.ToInt32(kullaniciYasi); // 2. Yöntem 

            Console.WriteLine(kullaniciYasiInt); // 1. Yöntem'in Çıktısı
            Console.WriteLine(kullaniciYasi2);   // 2. Yöntem'in Çıktısı

            */

            //  KULLANICININ GİRDİĞİ İKİ SAYIYI İNT VERİ TİPİNDE TOPLAYAN METHOD. 

            Console.WriteLine("Lütfen 1. sayıyı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            


            Console.WriteLine("İki sayının Toplamı : "+ (sayi1 +sayi2));

            Console.ReadLine(); //  Consolun Daha Temiz Görülmesini Sağlayan Method.

        }
    }
}
