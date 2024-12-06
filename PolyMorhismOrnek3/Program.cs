using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorhismOrnek3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             "Bir Arac temel sınıfı oluştur. Bu sınıfın içinde Hizlan ve Yavasla adında iki adet virtual metot tanımla.
            Daha sonra Arac sınıfından türeyen bir Otomobil ve bir Bisiklet sınıfı oluştur.
            Otomobil sınıfında Hizlan, hız değerini her çağrıldığında 20 artırırken, Bisiklet sınıfında bu değer 5 olsun.
            Aynı şekilde Yavasla, Otomobil için 15 azaltırken, Bisiklet için 3 azaltsın.
            Son olarak : 
            bir Arac listesi oluştur ve bu listeye hem Otomobil hem de Bisiklet nesnelerini ekleyerek döngü içinde her bir aracın hızlanma ve yavaşlama davranışını test et.
              */

            List<Arac> araclar = new List<Arac>
                  {
            new Otomobil(),
            new Bisiklet()
                 };

            foreach (var arac in araclar)
            {
                Console.WriteLine($"Şimdi bir {arac.GetType().Name} ile işlem yapılıyor:");
                arac.Hizlan(50);
                arac.HiziGoster();
                arac.Yavasla();
                arac.HiziGoster();
                Console.WriteLine();
            }

        }
    }
}
