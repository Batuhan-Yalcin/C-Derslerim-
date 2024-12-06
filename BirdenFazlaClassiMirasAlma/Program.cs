using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdenFazlaClassiMirasAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KEDİ CLASSI HEM HAYVAN CLASSINI HEM KOPEK CLASSINI MİRAS ALABİLDİ.
            // BURANIN EN GÜÇLÜ CLASS ' I HAYVAN CLASSIDIR ÇÜNKÜ 2 SİNE BİRDEN MİRAS VERDİ..

            Kedi kedi = new Kedi();

            kedi.renk = "Kahverengi"; // HAYVAN SINIFINDAN GELEN DEĞER

            kedi.ayakSayisi = 4;// KÖPEK SINIFINDAN GELEN DEĞER

            kedi.isim = "İnek"; // HAYVAN SINIFINDAN GELEN DEĞER

            kedi.cinsiyet = "Erkek"; // KÖPEK SINIFINDAN GELEN DEĞER

                kedi.kilo = 75; // HAYVAN SINIFINDAN GELEN DEĞER

            kedi.sesCikar();
            kedi.hayvanBilgileriGoster();

            Console.ReadLine();


        }
    }
}
