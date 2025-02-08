using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class Kedi : Hayvan
    {
        public override void sesCikar()
        {
            Console.WriteLine("Kedi Miyavlıyor");
        }

        public override void yemekYe()
        {
            Console.WriteLine("Kedi Mama Yiyor.");
        }
    }
}
