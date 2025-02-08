using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_1
{
    public class AskerKredi : KrediManager
    {

        private int askerFaizi;

        public string isim = "Batuhan";



        public int getaskerFaizi()
        {
            return askerFaizi;
        }

        public void setaskerFaizi(int askerFaizi)
        {
            this.askerFaizi = askerFaizi;
        }

    }
}
