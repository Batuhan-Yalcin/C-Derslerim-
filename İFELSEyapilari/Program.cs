using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İFELSEyapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Öğrencinin Sınav Notu 50 den Büyükse Başarılı 50'den Küçükse Başarısız Yazdıran Program İF Else.
            /*
            int not = 58;

            if (not <50)
            {
                Console.WriteLine("Dersten Başarı İle Geçtiniz.");
            }
            else
            {
                Console.WriteLine("Dersten Kaldınız.");
            }
            */

        // Öğrencinin Klavyeden Girdiği Sınav Notu 50 den büyükse başarılı küçükse Başarısız Yazdıran İf Else Programı

            
            
            Console.WriteLine("Sınavdan Almış Olduğunuz Notu Giriniz : ");


            int not = Convert.ToInt32(Console.ReadLine());

            if (not > 50)
            {
                Console.WriteLine("Dersten Başarı İle Geçtiniz.");
            }
            else
            {
                Console.WriteLine("Dersten Kaldınız.");
            }


            Console.ReadLine();

        }
    }
}
