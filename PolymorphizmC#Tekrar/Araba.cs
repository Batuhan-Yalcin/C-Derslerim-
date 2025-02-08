using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class Araba
    {

        public virtual void arabaSesi()
        {
            Console.WriteLine("Araba Classı Ses çıkarıyor.");
        }

        public virtual void arabaKm()
        {
            Console.WriteLine("Araba Classının Kmsidir.");
        }

        public virtual void arabaRengi()
        {
            Console.WriteLine("bu Araba Classının Renk Methodu");
        }

    }
}
