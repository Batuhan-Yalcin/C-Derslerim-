using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSealedAnahtarKelimesininOnemi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // sealed anahtar kelimesi nedir ? 

            Musteri musteri = new Musteri();

            musteri.personel_id = 1;
            musteri.personel_ismi = "Batuhan";
            musteri.personel_soyisim = "Yalçın";
            musteri.personel_maas = 2000;

            musteri.PersonelBilgileriGoster();

            Console.ReadLine();


        }
    }
}
