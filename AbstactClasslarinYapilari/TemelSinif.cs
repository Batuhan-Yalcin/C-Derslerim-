using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactClasslarinYapilari
{
    public abstract class TemelSinif
    {

        public void metot1()
        {
            Console.WriteLine("Metot 1 Çalıştı..");
        }

        public abstract void metot2(); // abstract şekilde metot böyle tanımlanabilir..
        

    }
}
