using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VE OPERATÖRÜ = &&
            // VE OPERATÖRÜ MANTIKSAL OPERATÖR OLARAK GEÇER , Gelin Kullanımını inceleyelim..
            // KULLANIMI ŞU ŞEKİLDİR TÜM KOŞULLAR SAĞLANIRSA TRUE DÖNER 1' İSİ BİLE SAĞLANMAZSA FALSE DÖNER.
            // 100 TANE KOŞUL OLSUN 99 U SAĞLANSIN 1 İ SAĞLANMASIN FALSE DÖNER.

            int sayi1 = 5;
            int sayi2 = 5;
            int sayi3 = 10;

            bool kontrolEt = sayi1 == sayi2 & sayi1 < sayi3; // burada sayi1 sayi 2 ye eşit ve sayi 1 sayi 3 den küçük mü diye sorduk
            // BURADA TÜM KOŞULLAR SAĞLANDIĞI İÇİN TRUE DÖNDÜ 
            // FAKAT SAYİ 1 > SAYİ3 DESEYDİK FALSE DÖNERDİ ÇÜNKÜ 2. KOŞUL YANLIŞ OLURDU..

            Console.WriteLine(kontrolEt);

            Console.ReadLine();

        }
    }
}
