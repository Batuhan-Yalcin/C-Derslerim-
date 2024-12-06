using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsitDegildirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EŞİT DEĞİLDİR OPERATÖRÜ :    !=

            int sayi1 = 10;
            int sayi2 = 10;

            bool EsitMi = sayi1 != sayi2; // BURADA SAYI 1 SAYI 2 YE EŞİT Mİ DEDİK ASLINDA EŞİT FAKAT 
            // EŞİT DEĞİLDİR OPERATÖRÜ KOYDUĞUMUZ İÇİN FALSE YANITINI ALMIŞ OLDUK.. 

            Console.WriteLine(EsitMi);

            Console.ReadLine();
        }
    }
}
