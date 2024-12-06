using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVeİnterfaceFarki
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Abstract class'lar ile İnterface farklını bu örnekle daha iyi anlayalım..

            /* İnterface ile tanımlanan metodları böyle yazdırdık.
            Ocak ocak = new Ocak();
            Console.WriteLine(ocak.gunSaati()); 
            
            Subat subat = new Subat();
            Console.WriteLine(subat.gunSaati()); 

            Mart mart = new Mart();
            Console.WriteLine(mart.gunSaati()); 

            Console.ReadLine();
            */


            // Abstract class da tek bir metot üzerinden gün saatini yazdırdık fakat interface de hepsine tek tek return 24; değerini vermek zorunda kalmıştık..

            // Abstract Class ile tanımlandı..
            Ocak ocak = new Ocak();
            Console.WriteLine("Ocak Gün Saati : " + ocak.gunsaati());

            Subat subat = new Subat();
            Console.WriteLine("Şubat Gün Saati : " + subat.gunsaati());
            Mart mart = new Mart();
            Console.WriteLine("Mart Gün Saati : " + mart.gunsaati());

        }
    }
}
