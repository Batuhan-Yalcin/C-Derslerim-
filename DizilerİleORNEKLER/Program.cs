using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerİleORNEKLER
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[4];
            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 30;
            sayilar[3] = 40;

            for (int i = 0; i < sayilar.Length; i++) // Length uzunluk demek yani burada yaptığımız şudur ;
                // int i 0 değerini atadık i değişkeni sayilar değişkeninin uzunluğu kadar dönsün ve i hep 1 artsın dedik
            {
                Console.WriteLine(sayilar[i]);  // dizilerin yazdırma işlemi..
            }
            Console.ReadLine();
        }
    }
}
