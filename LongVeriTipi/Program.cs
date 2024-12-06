using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Long Veri Tipi -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasında değer alabilen veri tipidir int veri tipinden büyüktür.
            // fakat ram bellekte 8 byte yer kaplar.

            // Neden Long kullanılır örnek tc kimlik kontrolü yapıyorsunuz int veri tipi 10 basamaklı değer alır fakat tc kimlik 11 haneli 
            // bu yüzden long veri tipi kullanmak zorunda kalırız.

            long minDeger = long.MinValue;
            long maxDeger = long.MaxValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);

            Console.ReadLine();
        }
    }
}
