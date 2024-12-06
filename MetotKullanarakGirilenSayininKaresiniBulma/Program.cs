using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotKullanarakGirilenSayininKaresiniBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // KULLANICIDAN ALDIĞIMIZ SAYININ KARESİNİ ALALIM EĞER KARESİ 25' TEN BÜYÜKSE 
            // KARESİ 25' TEN BÜYÜKTÜR 
            //  DEĞİLSE KARESİ 25'TEN KÜÇÜKTÜR YAZALIM..


            Console.Write("Birinci Sayıyı Giriniz : "); // Kullanıcının Sayı girmesini istedim
            int girilenSayi = int.Parse(Console.ReadLine()); // Kullanıcının girdiği sayıyı int veri tipinde aldım.

          int kareDegeri =  kareAl(girilenSayi); // kareAl metodumu çağırıp parantezin içine kullanıcının girdiği sayıyı koydum girilensayi değişkenini yani.
             
            if(kareDegeri > 25) // eğer kare değeri 25 ten büyükse büyüktür yaz dedim
            {
                Console.WriteLine("Karesi 25'ten büyüktür.");
            }
            else
            {
                Console.WriteLine("Karesi 25'ten Küçüktür."); // değilse 25 ten küçüktür yaz dedim
            }
            Console.ReadLine(); // konsolumu ekranda tutmak için readline kullandım

        }

        static int kareAl (int sayi ) // int veri tipinde kareAl ismiinde degisken oluşturdum ve içine int sayi adında değişken ekledim
        {
            return sayi * sayi; // Girilen Sayının karesini bulan formül 2 sayıyı birbiriyle çarptım .
        }


    }
}
