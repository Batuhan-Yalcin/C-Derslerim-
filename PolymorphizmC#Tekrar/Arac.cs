using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class Arac
    {
        private int hiz;
        public virtual void HareketEt()
        {
            Console.WriteLine("-----------------");
        }

        public int getHiz()
        {
            return hiz;
        }

        public void setHiz(int hiz)
        {
            this.hiz = hiz;
        }



    }
}
