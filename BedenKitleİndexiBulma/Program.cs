using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleİndexiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beden Kitle İndexi = Kilo / Boy * Boy
            // Beden Kitle İndexi 18'e eşit veya düşükse zayıf
            // 18 - 25 arası ise normal 
            // 25'ten büyükse Obez Yazdıran Programı Kodlayacağız..

            Console.WriteLine("Kilonuzu Giriniz : ");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu Giriniz : ");
            double boy = Convert.ToDouble(Console.ReadLine());

            double BdnKitleEndexi = kilo / (boy * boy); // Boy * boy yapmamızın sebebi boyun karesini bulmak için.

            if (BdnKitleEndexi < 18)
            {
                Console.WriteLine("Zayıfsınız.");
            }

            else if (BdnKitleEndexi > 18 && BdnKitleEndexi < 25)
            {
                Console.WriteLine("Normalsiniz.");
            }
            else if (BdnKitleEndexi >25)
            {
                Console.WriteLine("Obezsiniz.");
            }
            Console.ReadLine();

        }
    }
}
