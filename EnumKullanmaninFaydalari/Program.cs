using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumKullanmaninFaydalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Enum Kullanmadan Oluşturduk bu örneği Hem uzun Hem yorucu şimdi ise enum kullanarak yapacağız..
            Musteri musteri = new Musteri(1,"Batuhan","Yalçın","Erkek", "Batuhanyalcin5834@gmail.com");

         int gelenKod = musteri.musteriEkle(musteri);

            if ( gelenKod == 413444 )
            {
                Console.WriteLine("Müşterili Başarılı Bir Şekilde Eklenmiştir.");
            }

            Console.ReadLine();

            */

            // Enum kullanarak oluşturulan code.
            Musteri musteri = new Musteri(1, "Batuhan", "Yalçın", "Erkek", "Batuhanyalcin5834@gmail.com");

            MusteriDurum donenDurum = musteri.MusteriEkle(musteri);

            if (donenDurum == MusteriDurum.kayitbasarili)
            {
                Console.WriteLine("Müşterili Başarılı Bir Şekilde Eklenmiştir.");
            }

            Console.ReadLine();


        }
    }
}
