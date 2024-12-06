using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizininElemanlariniKullanicidanAlmaOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Dizinin Elemanlarını Kullanıcıdan alıp ekrana yazdıralım..

            int[] sayilar = new int[4];

            for (int i = 0; i <sayilar.Length; i++)
            {
                Console.Write("Sayılar Dizisinin" + (i+0) + ".index değerini giriniz : ");

                sayilar [i] = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine("**********************************************************************************");

            for (int i = 0; i <sayilar.Length; i++)
            {
                Console.WriteLine("Girmiş Olduğunuz Değerler : " + sayilar[i]);
            }

            Console.ReadLine();
        }
    }
}
