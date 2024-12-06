using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İntVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İnt Veri Tipi -2.147.483.648 ile 2.147.483.647 arasındaki değerleri döndürebilen bir veri tipidir ve en sık kullanılan veri tipidir.
            // 4 byte yer kaplar ram bellekte.

            // 8 bit  = 1 byte
            // 1024 byte = 1KB(KiloByte)
            //1024 KB = 1MB (Megabyte)
            //1024 MB = 1GB (Gigabyte)
            //1024GB = 1TB(terabyte)
            //1024 TB = 1PB (Petabyte)


            int birincidegisken = 150000;
            int ikincidegisken = 1999999999;

            int maxDeger = int.MaxValue;
            int minDeger = int.MinValue;

            Console.WriteLine(birincidegisken);
            Console.WriteLine(ikincidegisken);
            Console.WriteLine(minDeger);
            Console.WriteLine(maxDeger);

            Console.ReadLine();
        }
    }
}
