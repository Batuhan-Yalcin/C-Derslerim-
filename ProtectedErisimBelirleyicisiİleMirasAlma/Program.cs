using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedErisimBelirleyicisiİleMirasAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Super Class , Base Class == Mirası Veren Class.
            // Sub Class == Alt Class = Mirası Alan Class'a denir.

            Papatya papatya = new Papatya();
            
            papatya.papatyaBilgileri();

            Console.ReadLine();

        }
    }
}
