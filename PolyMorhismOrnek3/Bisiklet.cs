using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorhismOrnek3
{
   public class Bisiklet : Arac
    {

        public override void Hizlan(int hizlan)
        {
            Hiz += 5;
            Console.WriteLine("Bisiklet Hızlanıyor : +5 km/s");
        }

        public override void Yavasla()
        {
            Hiz -= 3;
            if (Hiz < 0) Hiz = 0;
            Console.WriteLine("Bisiklet Yavaşlıyor : -3 km/s");
        }

    }
}
