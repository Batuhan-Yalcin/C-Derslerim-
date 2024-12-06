using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticİleMetotKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // static metot kullanımı ve Çalışma Mantığu şu şekildedir..

           

            Personel.isimSoyisimYazdir(); // Static Kullandığım İçin Obje Oluşturmama gerek kalmadan sadece class ismi ve metod ismi ile çağırabildim.
            Personel.Toplama(50,75);




            Console.ReadLine();

        }
    }
}
