using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleVeriTipiİLeDiziOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] ondalikliSayi = { 1.44, 7.55, 8.31, 9.25 };

            for (int i = 0; i< ondalikliSayi.Length; i++)
            {
                Console.WriteLine(ondalikliSayi[i]);
            }
            Console.ReadLine();
        }
    }
}
