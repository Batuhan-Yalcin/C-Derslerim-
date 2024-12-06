using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdenFazlaClassiMirasAlma
{
    public class Kedi : Kopek
    {

        public void sesCikar()
        {
            Console.WriteLine("Kedi Miyavladı..");
        }

      public void  hayvanBilgileriGoster()
        {
            Console.WriteLine("Hayvanın İsmi : "+ isim);
            Console.WriteLine("Hayvanın Rengi : " +renk);
            Console.WriteLine("Hayvanın Kilosu : " +kilo);
            Console.WriteLine("Köpeğin Ayak Sayısı : " +ayakSayisi);
            Console.WriteLine("Köpeğin Cinsiyeti : " +cinsiyet);
        }

    }
}
