using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ForEach Döngüsü :  foreach ( //1. adım Veri tipi 2. adım degisken ismi 3. adım in 4.adım dizi ismi )

            string[] isimler = { "Batu", "Enes", "Aysun", "Şevval", "Eren" };

            foreach (string degisken in isimler) // İsimler dizimin içindeki her bir değeri degisken değerine ata dedim.
            {
                Console.WriteLine(degisken);
            }

            double[] ondalikliSayilar = { 1.2, 1.6, 1.8, 2.10 };

            foreach (double sayilarx in ondalikliSayilar)
            {
                Console.WriteLine("Ondalıklı Sayıları : " + sayilarx);
            }


            Console.ReadLine();
        }
    }
}
