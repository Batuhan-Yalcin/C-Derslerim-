using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorhismOrnek3
{
    public class Arac
    {
        public int Hiz { get; set; } = 0;
        public virtual void Hizlan(int hizlan)
        {
            
            Console.WriteLine("Hızlandım.");
        }

      

        public virtual void Yavasla()
        {
            Console.WriteLine("Yavaşladım.");
        }

        public void HiziGoster()
        {
            Console.WriteLine("Mevcut Hız : " + Hiz + " KM/S");
        }

    }
}
