using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuİleCARPIMTABLOSU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bu Projemizde For Döngüsü İle Çarpım TABLOSU Yapacağız..

            for (int i = 1; i <= 10; i++) // Buradaki döngü 100 kere çalışır.
            {
                for(int j = 1; j <= 10; j++)    // buradaki döngü 1000 kere..
                {
                Console.WriteLine(i+ " x " + j + " = " +(i * j)); // i yi yazdık x sembolü koyduk j yi yazdık = sembolü
                    // koyduk ve i*j dedik 1 den 10 a kadar olan tüm sayıların hepsini tek tek çarptı 
                }
            }
            Console.ReadLine();
        }
    }
}
