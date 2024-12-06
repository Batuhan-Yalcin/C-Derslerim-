using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // float ondalıklı sayıları yazmamızı sağlayan veri tipidir sonuna f harfi eklemezsek hata alırız..

            float ondaliklisayi1 = 35.2f;
            float ondaliklisayi2 = 50.2f;

            float maxDeger = float.MaxValue;
            float minDeger = float.MinValue;

            Console.WriteLine(ondaliklisayi1);
            Console.WriteLine(ondaliklisayi2);
            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);

            Console.ReadLine();
        }
    }
}
