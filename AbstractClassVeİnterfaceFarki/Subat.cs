using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVeİnterfaceFarki
{
    public class Subat : AbstractAy
    {
        /* İnterFace İle tanımlandı.
        public int gunSaati()
        {
            return 24;
        }

        public int kacGundenOlusur()
        {
            return 28;
        }

        public int yilinKacinciAyi()
        {
            return 2;
        }
        */
        public override int ayKacCekiyor()
        {
            return 28;
        }

        public override int kacinciyil()
        {
            return 2;
        }
    }
}
