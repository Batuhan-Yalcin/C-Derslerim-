using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMirasAlma
{
    public class Hayvan
    {
        public string hayvanIsim;
        public string hayvanCinsiyet;
        public string hayvanRengi;


        public void hayvanBilgisiGoster()
        {
            Console.WriteLine("Hayvan'ın İsmi : "+hayvanIsim);
            Console.WriteLine("Hayvanın Cinsiyeti : " +hayvanCinsiyet);
            Console.WriteLine("Hayvanın Rengi : " +hayvanRengi);
        }

    }
}
