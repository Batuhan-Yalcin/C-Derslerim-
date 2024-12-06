using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsittirOperatöru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EŞİTTİR OPERATÖRÜ :    ==

            int sayi1 = 4;
            int sayi2 = 4;

            bool kontrolEt = sayi1 == sayi2; // BURADA SAYI 1 SAYI 2 YE EŞİT Mİ DİYE SORDUK 

            Console.WriteLine(kontrolEt); // VE ÇIKTI DA BİZE TRUE DÖNDÜ EŞİTTİR OPERATÖRÜMÜZ 2 ŞEYİN EŞİT OLMA DURUMUDUR.

            Console.ReadLine();
        }
    }
}
