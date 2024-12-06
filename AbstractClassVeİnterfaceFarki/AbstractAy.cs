using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVeİnterfaceFarki
{
    public abstract class AbstractAy
    {

        public int gunsaati() // gün saati metodu hepsinde aynı olacağı için direkt metodun içinde 24 ' ü tanımladık.
        {
            return 24;
        }

        public abstract int kacinciyil(); // bunlar değişiklik gösterebileceği için abstract olarak tanımladık.

        public abstract int ayKacCekiyor();

    }
}
