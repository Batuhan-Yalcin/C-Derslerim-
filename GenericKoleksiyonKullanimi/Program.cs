using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Generic koleksiyonlar, belirli bir veri tipiyle çalışan, tip güvenliğini sağlayan ve performansı artıran koleksiyonlardır.
            // Amaçları, farklı türlerde verilerle çalışırken kod tekrarını önlemek ve çalışma zamanı hatalarını azaltmaktır. 
            /*
            List<int> rakamlar = new List<int>(); // Generic Koleksiyon Tanımlaması.. 

            rakamlar.Add(1);
            rakamlar.Add(2);
            rakamlar.Add(3);
            rakamlar.Add(4);
            rakamlar.Add(5);
            rakamlar.Add(6);
            rakamlar.Add(7);
            rakamlar.Add(8);

            foreach (int rakam in rakamlar)
            {
                Console.WriteLine(rakam);
            }

            Console.ReadLine();
            */
            // List in içine veri tipi yerine Musteri yazma sebebim Musteri classımda ki değerleri  bana döndür demektir.

            List <Musteri> musteriler = new List <Musteri> ();


            musteriler.Add(new Musteri(1, "Batuhan", "Yalçın", "Batuhan@gmail.com")); // Musteriler referansım ile add metodundan musteri classındaki değerleri ekledim.
            musteriler.Add(new Musteri(2, "Hüseyin", "Boğlu", "Hüseyin@gmail.com"));
            musteriler.Add(new Musteri(3, "Enes", "Taş", "Enestas@gmail.com"));

          bool BoyleBirMusteriVarmı =  musteriler.Contains(new Musteri(3, "Enes", "Taş", "Enestas@gmail.com"));
            Console.WriteLine("Koleksiyon Boyutu : " + musteriler.Count);

            if (BoyleBirMusteriVarmı == false)
            {
                Console.WriteLine("Böyle Bir Müşteri Vardır.");
            }

            foreach (Musteri m in musteriler)
            {
                Console.WriteLine (m); 
            }
            Console.ReadLine();

        }
    }
}
