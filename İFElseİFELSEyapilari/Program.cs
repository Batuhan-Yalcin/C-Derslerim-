using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İFElseİFELSEyapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan ve ortalaması
            // eğer 80-100 arası ise A+ yazdıran 
            // 60 - 80 arası ise A yazdıran 
            // 40 -60 arası ise B+ yazdıran
            // 40 dan küçükse F Yazdıran C# Programı 

            Console.WriteLine("Lütfen 1. Notunuzu Giriniz : ");
            int birinciNot = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Notunuzu Giriniz : ");
            int ikinciNot = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 3. Notunuzu Giriniz : ");
            int ücüncüNot = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birinciNot + ikinciNot + ücüncüNot) / 3;

            if (sonuc > 80 && sonuc < 100)
            {
                Console.WriteLine("Aldığınız Not A+");
            }

            else if (sonuc > 60 && sonuc < 80)
            {
                Console.WriteLine("Aldığınız Not A ");
            }

            else if (sonuc > 40 && sonuc < 60)
            {
                Console.WriteLine("Aldığınız Not B+");
            }
            else
            {
                Console.WriteLine("Aldığınız Not F");
            }
            Console.ReadLine();

        }
    }
}
