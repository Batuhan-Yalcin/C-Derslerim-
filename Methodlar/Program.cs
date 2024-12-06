using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            // Parametresiz - Geriye Değer Döndürmeyen Methot Tanımı : 
            SelamVer();
            adiniYaz();
        }

        static void SelamVer() // Buradaki void herhangi birşey döndürmeyen string olsun int olsun bir değer döndürmeyen sadece çıktı işleminde kullanılır.
        {
            Console.WriteLine("Selamlar..");
            Console.ReadLine();
        }

        static void adiniYaz()
        {
            Console.WriteLine("Batuhan Yalçın");
            Console.ReadLine();
        }

    }
}
