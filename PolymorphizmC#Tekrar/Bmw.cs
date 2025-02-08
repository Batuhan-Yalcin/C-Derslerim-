using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class Bmw : Araba
    {

        public override void arabaSesi()
        {
            Console.WriteLine("Bmw nin Egzozundan Ses Çıktı..");
        }

        public override void arabaKm()
        {
            Console.WriteLine("Bmw'nin Km'si  : 50.000");
        }

        public override void arabaRengi()
        {
            Console.WriteLine("Bmw'nin Rengi Siyah");
        }

    }
}
