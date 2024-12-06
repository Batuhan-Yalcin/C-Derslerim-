using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // Class oluşturmak için mevcut projemize Sağ tık yapıyoruz çözüm gezgini yerinden ekle diyip sınıf yani class ı seçiyoruz aşağıdan class ismii girip oluştur diyoruz.

            // classlardan obje oluşturmak ve kullanmak için ;

            // 1- class ismi 2 - referans ismi (değişken ismi) 3- = new yazıp class ismini tekrar yazıyoruz();

            // örnek ;
            // Araba ArabaDegiskeni = new Araba();

            // burada tanımladığımız araba1 referansımız üzerinden Araba classındaki metotları kullanabileceğiz..
            Araba araba1 = new Araba();

            araba1.kapiSayisi = 4; // classtaki Bir Değişkene değer atamak için önce tanımladığımız referansı yazarız yani araba1 sonra nokta koyup classtaki degisken
            // ismini gireriz..
            araba1.arabaRengi = "Lacivert";
            araba1.arabaModeli = "BMW";

            araba1.arabaMotoruCalistir(); // classtan gelen metodu çağırmak için Referansımızı yazarız yani araba1 sonra nokta koyup methodu çağırırız.
            araba1.KapilariKilitle();     // classtan gelen metodu çağırmak için Referansımızı yazarız yani araba1 sonra nokta koyup methodu çağırırız.


            Console.WriteLine("Arabanın Kapı Sayısı : " +araba1.kapiSayisi); // classtan gelen bir değişkeni yazdırmak için Yine referansımız nokta ve degisken ismi
            Console.WriteLine("Arabanın Rengi : " +araba1.arabaRengi);
            Console.WriteLine("Arabanın Modeli : " + araba1.arabaModeli);

            Console.ReadLine();

        }
    }
}
