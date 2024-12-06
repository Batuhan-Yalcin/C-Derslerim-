using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedErisimBelirleyicisiİleMirasAlma
{
    public class Papatya : Bitki // Papatya class'ı sub classdır.
    {

        public void papatyaBilgileri()
        {
            bitkiID = 1;
            bitkiIsmi = "Papatya";
            bitkiRengi = "Beyaz";    

            Console.WriteLine("Bitki ID : " +bitkiID);
            Console.WriteLine("Bitki İsmi : " +bitkiIsmi);
            Console.WriteLine("Bitki Rengi : " +bitkiRengi);
        }

    }
}
