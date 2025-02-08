using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class Hayvan
    {
        
        public virtual void sesCikar()
        {
            Console.WriteLine("Hayvan Classı Ses çıkarıyor");
        }
        public virtual void yemekYe()
        {
            Console.WriteLine("Hayvan Yemek yiyor.");
        }

    }
}
