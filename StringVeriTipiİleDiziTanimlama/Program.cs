using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVeriTipiİleDiziTanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = { "Batuhan", "Enes", "Mehmet", "Kasım" , "Ali" };

            Console.WriteLine(isimler[1]); // isimler dizisinin 1. indexinin çıktısı Çıktı = ENES 
            // 0. index = Batuhan 1. index = enes 2. index = Mehmet 3. index = Kasım 4. index = Ali

            for (int i = 0; i < isimler.Length; i++) // isimler dizisinin uzunluğu kadar dönen for döngüsü 
            {
                Console.WriteLine(isimler[i]); // isimler dizisinin tüm indexlerinin çıktısı..
            }

            Console.ReadLine();
        }
    }
}
