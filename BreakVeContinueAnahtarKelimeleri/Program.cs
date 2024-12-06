using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakVeContinueAnahtarKelimeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Break Anahtar Kelimesi = Döngüyü Tamamen Kırar 
            // Continue Anahtar Kelimesi = Döngüyü 1 defaya mahsus Kırar

            // 1'den 10 ' a kadar olan sayıları yazdıracağız fakat A değişkeni 7 olduğunda 8-9-10 u yazdırmayan 
            // Programı kodlayalım..

            for (int a = 1; a <= 10; a++)
            {
                if (a == 8)
                {
                    break;
                }
                Console.WriteLine("A'nın Değeri : " +a); // ÇIKTI = 1-2-3-4-5-6-7 
               
                
            }



            for (int b = 1; b <= 10; b++)
            {
                if (b == 8)
                {
                    continue; // 8 sayısını almaz Çünkü 8 sayısını döngüden kırar ve devam eder 
                }
                Console.WriteLine("B'nin Değeri : "+ b);    // ÇIKTI = 1-2-3-4-5-6-7-9-10
            }

            Console.ReadLine();
        }
    }
}
