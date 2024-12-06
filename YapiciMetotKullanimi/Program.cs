using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassOlusturma;

namespace YapiciMetotKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor YAPICI METOTLAR Nedir ? : classlardan obje oluşturduğum sırada oluşan geriye dönüş tipi olmayan metottur.
            // yani şöyle söyleyelim Diyelim ki class ismim Araba Metodumun ismide Araba olmak zorundadır ve geriye dönüş tipi olmayacak. 
            // Araba araba2 = new Araba();  aslında buradaki new den sonraki Araba() bizim yapıcı metodumuzdur.

            // ÖRNEK ;
            //  public class Araba{
            //  public Araba()
            //   {
            //  // Araba Classının yapıcı metodu içerisindeyiz..
            //  }
            // }


            Araba araba2 = new Araba(4, "BMW M4", "Siyah"); // Yapıcı Metotta Girdiğimiiz değişkenleri Burada dolduruyoruz 
            Console.WriteLine("Aracın Kapı Sayısı : " + araba2.kapiSayisi); // ve ekrana yazdırıyoruz.
            Console.WriteLine("Arabanın Modeli : " + araba2.arabaModeli);
            Console.WriteLine("Aracın Rengi : " + araba2.arabaRengi);


            araba2.arabaMotoruCalistir();
            araba2.KapilariKilitle();

           
            


        }
    }
}
