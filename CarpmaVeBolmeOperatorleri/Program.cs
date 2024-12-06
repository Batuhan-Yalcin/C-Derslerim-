using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpmaVeBolmeOperatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çarpma Operatörü =   *
            // Bölme Operatörü  =  /

            int sayi1 = 10;
            int sayi2 = 5;

            int carpim = sayi1 * sayi2;
            int bolme = sayi1 / sayi2;

            Console.WriteLine("Çarpma İşleminin Sonucu : "+carpim);
            Console.WriteLine("Bölme İşleminin Sonucu : " +bolme);


            Console.ReadLine();

        }
    }
}
