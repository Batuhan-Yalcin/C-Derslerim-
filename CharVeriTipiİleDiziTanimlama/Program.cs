using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharVeriTipiİleDiziTanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[] karakterler = {'a', 'b' , 'c' , 'd' , 'e'};

            for (int i = 0; i < karakterler.Length; i++)
            {
                Console.WriteLine(karakterler[i]);
            }
            Console.ReadLine();
        }
    }
}
