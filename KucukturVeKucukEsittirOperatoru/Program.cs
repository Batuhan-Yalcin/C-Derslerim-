using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucukturVeKucukEsittirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KÜÇÜKTÜR OPERATÖRÜ  = <
            // KÜÇÜK EŞİT OPERATÖRÜ = <=
            
            int yas = 22;
            bool kontrolEt = yas < 18; // YAŞIM 18 DEN KÜÇÜK MÜ DİYE SORDUM
            bool kontrolEt2 = yas <= 22; // YAŞIM 22 DEN KÜÇÜK VEYA EŞİT Mİ DİYE SORDUM.

            Console.WriteLine(kontrolEt);
            Console.WriteLine(kontrolEt2);

            Console.ReadLine();
        }
    }
}
