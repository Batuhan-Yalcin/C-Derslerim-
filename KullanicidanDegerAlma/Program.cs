using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // READLİNE KOMUTU KULLANICIDAN DEGER ALMAMIZA YARAR..
            // KULLANICIDAN DEĞER ALMA ŞUDUR ÖRNEK İSMİNİZİ GİRİNİZ : 
            // KULLANICI GİRİŞ YAPAR : BATU GİBİ..


            Console.WriteLine("Lütfen İsminizi Giriniz : ");
            string isim = Console.ReadLine();

            Console.WriteLine("Lütfen Soyisminizi Giriniz : ");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Kullanıcının İsmi : " +isim);
            Console.WriteLine("Kullanıcının Soyİsmi : " +soyisim);



            



            Console.ReadLine();

        }
    }
}
