using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Bu Örneğimizde Bir Öğrenci Sınıfı Oluşturacağız.
            // Ad, Soyad ve Numara özelliklerine sahip olacak.
            // Ad ve Soyad özellikleri sadece okunabilir olsun Yani Set etmeyecek.
            // Numara özelliği hem okunabilir hem de yazılabilir olsun, ancak Numara negatif bir değer alamaz.
            // Öğrencinin tam adını döndüren bir metot ekleyeceğiz (TamAd()).

            Ogrenci ogrenci = new Ogrenci("Batuhan","Yalçın");

            ogrenci.Numara = 1907;
            Console.WriteLine("Öğrencinin Adı ve Soyadı : " + ogrenci.TamAd());
            Console.WriteLine("Öğrencinin Numarası : " + ogrenci.Numara);

            Console.ReadLine();
        }
      
        

    }
}
