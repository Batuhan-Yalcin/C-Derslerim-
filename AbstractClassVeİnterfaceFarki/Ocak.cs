using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVeİnterfaceFarki
{
    public class Ocak : AbstractAy
    {
        /* InterFace ile tanımlandı..
        public int gunSaati()
        {
            return 24;
        }

        public int kacGundenOlusur()
        {
            return 30;
        }

        public int yilinKacinciAyi()
        {
            return 1;
        }
        */
        public override int ayKacCekiyor()
        {
            return 30;
        }

        public override int kacinciyil()
        {
            return 1;
        }
    }
}
