using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeyaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VEYA OPERATÖRÜ = || ALT GR TUŞU VE - TUŞUNA 2 KERE BASARAK YAPILIR.
            // VEYA OPERATÖRÜNDE KOŞULLARDAN 1 İSİ BİLE SAĞLANIRSA TRUE DÖNER
            // 99 TANE KOŞUL OLSUN 1 TANESİ DOĞRU İSE TRUE CEVABI DÖNER.

            int sayi1 = 3;
            int sayi2 = 3;
            int sayi3 = 6;

            bool kontrolEt = sayi1 == sayi2 || sayi2 > sayi3; // Burada sayi 1 sayi 2 ye eşit mi veya sayi 2 sayi 3 den büyük mü dedim 
            // ÇIKTI DA TRUE DÖNDÜ NEDEN ÇÜNKÜ SAYİ 1 SAYI 2 İLE EŞİT KOŞULLARDAN 1 İSİ SAĞLANDIĞI İÇİN
            // TRUE DÖNER

            Console.WriteLine(kontrolEt);

            Console.ReadLine();
        }
    }
}
