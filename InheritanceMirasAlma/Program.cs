using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMirasAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Hayvan Sınıfında tanımladığım fieldları Main Metodunda Kedi sınıfından nesne türeterek işlem yapma 
            // Miras aldığımız için hayvan sınıfında yazmış olduğumuz tüm kodlar artık kedi sınıfında da çağırılabilir çünkü miras aldı..

            Kedi kedi = new Kedi();

            kedi.hayvanRengi = "Beyaz";
            kedi.hayvanIsim = "tekir";
            kedi.hayvanCinsiyet = "Dişi";

            kedi.hayvanBilgisiGoster();

            Console.ReadLine();

        }
    }
}
