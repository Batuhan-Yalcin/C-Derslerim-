using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class Kopek : Hayvan
    {


        public override void sesCikar()
        {
            Console.WriteLine("Köpek Havlıyor");
        }

        public override void yemekYe()
        {
            Console.WriteLine("Köpek Mama Yiyor.");
        }
    }
}
