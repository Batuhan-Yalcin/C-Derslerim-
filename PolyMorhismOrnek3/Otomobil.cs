using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorhismOrnek3
{
    public class Otomobil : Arac 
    {

        public override void Hizlan(int hizlan)
        {
            Hiz += 20;
            Console.WriteLine("Otomobil hızlanıyor: +20 km/s");
        }

        public override void Yavasla()
        {
            Hiz -= 15;
            if (Hiz < 0) Hiz = 0;
            Console.WriteLine("Otomobil yavaşlıyor: -15 km/s");
        }
    }
}
