using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamaVeCikarmaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Toplama Operatörü = + 
            // Çıkarma Operatörü = -

            int sayi1 = 12;
            int sayi2 = 5;

            int sonuc = sayi1 + sayi2;
            int sonuc2 = sayi1 - sayi2;

            Console.WriteLine("Toplama Sorusunun Cevabı : " +sonuc);
            Console.WriteLine("Çıkarma Sorusunun Cevabı : " +sonuc2);

            Console.ReadLine();
        }
    }
}
