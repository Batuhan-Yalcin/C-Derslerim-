using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismOrnek4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             "Bir Personel isimli temel sınıfı oluştur ve içinde Calis adında bir metot tanımla.
            Bu metodu virtual olarak işaretle.
            Daha sonra Personel sınıfından türeyen bir Ogrenci ve bir Ogretmen sınıfı oluştur.

            Ogrenci sınıfında Calis metodu, öğrencinin derse çalıştığını yazdırsın.
            Ogretmen sınıfında Calis metodu, öğretmenin ders anlattığını yazdırsın.

            Son olarak, bir Personel listesi oluştur ve bu listeye hem Ogrenci hem de Ogretmen nesnelerini ekleyerek döngü içinde her iki nesnenin de Calis metodunu çağır. 
            Listeyi kullanarak polymorphism'i gözlemle."
             */

            Personel personel = new Personel();

            personel = new Ogrenci();
            personel.calis();
            personel = new Ogretmen();
            personel.calis();   
            Console.ReadLine();

        }
    }
}
