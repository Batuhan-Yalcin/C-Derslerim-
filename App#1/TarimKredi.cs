using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_1
{
    public class TarimKredi : KrediManager
    {

        private int tarimFaizi;

        public int gettarimFaizi()
        {
            return tarimFaizi;
        }

        public void settarimFaizi(int tarimFaizi)
        {
            this.tarimFaizi = tarimFaizi;
        }

    }
}
