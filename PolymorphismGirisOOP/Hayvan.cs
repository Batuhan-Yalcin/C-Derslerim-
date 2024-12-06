using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGirisOOP
{
    public class Hayvan
    {

        public string isim;

        public Hayvan (string isim)
        {
            this.isim = isim;
        }

        public string getIsim()
        {
            return isim;
        }

        public void SetIsim(string isim)
        {
            this.isim = isim;
        }

        public virtual void konus()
        {
            Console.WriteLine("Hayvan Konuşuyor..");
        }

    }
}
