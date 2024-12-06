using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVeİnterfaceFarki
{
    public class Mart : AbstractAy
    {
        /* Interface ile oluşturuldu..
        public int gunSaati()
        {
            return 24;
        }

        public int kacGundenOlusur()
        {
            return 31;
        }

        public int yilinKacinciAyi()
        {
            return 3;
        }
        */
        public override int ayKacCekiyor()
        {
            return 31;
        }

        public override int kacinciyil()
        {
            return 3;
        }
    }
}
