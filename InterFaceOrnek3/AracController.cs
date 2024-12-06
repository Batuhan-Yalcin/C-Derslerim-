using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceOrnek3
{
    public class AracController
    {

        public void Aracİslemleri(IArac AracKontrolleri)
        {
            AracKontrolleri.Hizlan();
            AracKontrolleri.yavasla();
        }

    }
}
