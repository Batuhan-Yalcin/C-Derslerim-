using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İcİceForDongusuKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1'den 10 ' a kadar olan sayıları piramit halinde yazdıralım iç içe döngü kullanmadan yapılamaz..
            // 1
            // 12
            // 123
            // 1234
            // 12345
            // 123456
            // 1234567
            //12345678
            //123456789
            //12345678910 Bu şekilde Bir Çıktı almak istersen ne yaparız gelin birlikte kodlayalım..

            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }


            Console.ReadLine();

        }
    }
}
