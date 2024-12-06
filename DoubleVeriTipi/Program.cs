using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 15 BASAMAKLI ONDALIKLI SAYILIRDA KULLANILAN VERİ TİPİDİR .
            // FLOATTA 7 DEN SONRASINA ÇIKAMIYORDUK. 
            // RAM BELLEKTE 8BYTE YER KAPLAR.

            double ondaliklisayi = 1.55;
            double ondaliklisayi2 = 5555.2222;

            double maxDeger = double.MaxValue; 
            double minDeger = double.MinValue;

            Console.WriteLine(ondaliklisayi);
            Console.WriteLine(ondaliklisayi2);
            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);

            Console.ReadLine();
        }
    }
}
