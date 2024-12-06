using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Short veri tipi -32768 ile 32767 arasında değerleri döndürebilen bir veri tipidir.

            short birincidegisken = -50;
            short ikincidegisken = 50;
            short minDeger = short.MinValue;
            short maxDeger = short.MaxValue;

            Console.WriteLine(minDeger);
            Console.WriteLine(maxDeger);

            Console.WriteLine(birincidegisken);
            Console.WriteLine(ikincidegisken);

            Console.ReadLine();
        }
    }
}
