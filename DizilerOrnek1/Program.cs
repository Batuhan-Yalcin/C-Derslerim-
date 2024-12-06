using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bu örneğimde Kullanıcının Girdiği sayı dizinin içinde varmı ? varsa kaç tane olduğunu söyleyen yoksa
            // yoktur diye uyaran programı kodlayacağım gelin birlikte inceleyelim...



            int[] sayilar = { 10, 10, 20, 30, 20, 30,40,50,40,50,70,55,65,70,55,65,5,20,35,65,5,20,35,65,80 };
            int adet = 0; // adet değişkenim eğer benim girdiğim değer dizide varsa kaç adet olduğunu gösteren değişkenimdir.
            int sayi; // sayi değişkenimi de kullanıcıdan aldığım değişkendir.

            // 1. adım Kullanıcıdan değer alma 
            Console.Write("Lütfen Bir Sayı Giriniz : ");

            //2. adım Kullanıcıdan aldığımız değeri integer veri tipine dönüştürme 
            sayi = Convert.ToInt32(Console.ReadLine());

            // 3. adım for döngüsü ile dizilerin tamamını kontrol ediyoruz
            for (int i = 0; i < sayilar.Length; i++) 
            {
                // 4. adım  Kullanıcının girmiş olduğu sayı benim dizimdeki o an ki değere eşitse if bloklarım çalışacak
                if(sayi == sayilar[i])
                {
                    // ve o sayıdan ne kadar varsa adeti o kadar artacak
                    adet++;
                }
            }

            //5. adım kullanıcının girdiği sayı yoksa adet 0 sa yani girdiğiniz değer yoktur dedik
            if (adet == 0)
            {
                Console.WriteLine("Girmiş olduğunuz sayı Dizide Bulunamadı ! ");
            }
            // 6. adım Girdiği değer dizimde varsa sayı dizide bulundu dedik ve girdiğiniz sayının adeti diyip onu yazdırdık.
            else
            {
                Console.WriteLine("Girdiğiniz sayı Dizide Bulundu...");
                Console.WriteLine("Girdiğiniz Sayının Adeti : " + adet);
            }

            Console.ReadLine();

        }
    }
}
