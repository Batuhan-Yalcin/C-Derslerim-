using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanAlinanSayininTekMiCiftMiOldugunuBulanMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan aldığımız sayının tek mi çift mi olduğunu bulan metotu yazalım...

            Console.Write("Lütfen Bir sayı giriniz : ");
            int girilenSayi = int.Parse(Console.ReadLine());

            int MetottanGelenDeger = tekMiCiftMi(girilenSayi);

            if (MetottanGelenDeger %2 ==0)
            {
                Console.WriteLine("Girdiğiniz Sayı Çifttir.");
            }

            else
            {
                Console.WriteLine("Girdiğiniz Sayı Tektir.");
            }
            Console.ReadLine();


        }

        static int tekMiCiftMi (int x)
        {
            return x;
        }

    }
}
