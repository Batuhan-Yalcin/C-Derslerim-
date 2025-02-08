using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class Mercedes : Araba
    {


        public override void arabaSesi()
        {
            Console.WriteLine("Mercedesin Egzozundan Ses Çıktı..");
        }

        public override void arabaKm()
        {
            Console.WriteLine("Mercedes'in Km'si  : 20.000");
        }

        public override void arabaRengi()
        {
            Console.WriteLine("Mercedes'in Rengi Gri");
        }

    }
}
