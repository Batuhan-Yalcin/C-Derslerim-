using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class Audi : Araba
    {

        public override void arabaSesi()
        {
            Console.WriteLine("Audi nin Egzozundan Ses Çıktı..");
        }

        public override void arabaKm()
        {
            Console.WriteLine("Audi'nin Km'si  : 70.000");
        }

        public override void arabaRengi()
        {
            Console.WriteLine("Audi'nin Rengi Beyaz");
        }

    }
}
