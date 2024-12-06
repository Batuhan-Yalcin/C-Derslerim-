using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArttirmaVeAzaltmaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ARTTIRMA OPERATÖRÜ =  ++
            // AZALTMA OPERATÖRÜ  =    --

            int sayi1 = 10;
            int sayi2 = 20;
            sayi1++; // Normalde Çıktı da 10 çıkması gerekirken 11 çıktı çünkü burada arttırma operatörü kullandık.
            sayi2--;   // Normalde çıktıda 20 çıkması gerekirdi fakat 19 çıktı çünkü burada azaltma operatörü kullandık.
            Console.WriteLine("SAYI 1 İN SONUCU : "+sayi1);
            Console.WriteLine("SAYI 2' NİN SONUCU : " + sayi2);



            Console.ReadLine();
        }
    }
}
