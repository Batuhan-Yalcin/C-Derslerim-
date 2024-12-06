using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanSayisalDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KULLANICIDAN SAYISAL DEĞER NASIL ALINIR GELİN BİRLİKTE İNCELEYELİM ..
            // CONVERT.TOINT32 METHODUMUZ SAYESİNDE KULLANICIDAN SAYISAL DEĞER ALABİLİRİZ.

            Console.WriteLine("Birinci Sayıyı Giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Girdiğiniz 1. sayı : " + sayi1);
            Console.WriteLine("Girdiğiniz 2. Sayı : " + sayi2);

            Console.ReadLine();


        }
    }
}
