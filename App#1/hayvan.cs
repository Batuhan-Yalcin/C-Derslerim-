using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_1
{
    public class hayvan
    {
        public void KediSesi()
        {
            Console.WriteLine("Kedi Miyavladı");
        }

        public void KopekSesi()
        {
            Console.WriteLine("Köpek Havladı");
        }

        public void Uyuyor(string isim)
        {
            Console.WriteLine(isim + " " + "Uyuyor..");
        }

        public void hayvanBilgileri(string isim, string cins,int yas)
        {
            Console.WriteLine("Hayvanın İsmi : " + isim + " " + "Hayvanın Cinsi : " + cins + " " + "Hayvanın Yaşı : " +  yas);
        }

    }
}
