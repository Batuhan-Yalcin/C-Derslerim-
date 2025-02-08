using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class banka
        
    {
        public virtual void kredihesaplama() 
        {
            Console.WriteLine("Kredi hesaplandı");
        }

        public virtual void krediciktimi()
        {
            Console.WriteLine("Kredi Çıktı");
        }


    }
}
