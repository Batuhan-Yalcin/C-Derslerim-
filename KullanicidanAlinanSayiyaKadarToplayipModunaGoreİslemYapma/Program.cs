using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanAlinanSayiyaKadarToplayipModunaGoreİslemYapma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcıdan 1 sayı alacağız 0 ' dan başlayıp aldığımız sayıya kadar toplayacağız ve girdiği sayıyı 
            // böleceğiz  eğer ortalama 50den büyükse ortalama 50 den büyüktür yazacağız
            // değilse küçüktür yazacağız...


            Console.WriteLine("Lütfen Bir Sayı Giriniz : ");

            int sayi = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan aldığım değeri int e dönüştürdüm

            int toplam = 0;

            for (int i = 1; i <= sayi; i++)
            {
                toplam += i; // yada toplam = toplam + i; bunu da yapabiliriz 2. yöntemi
            }

            Double ortalama = toplam / sayi;

            if (ortalama > 50)
            {
                Console.WriteLine("ortalamanız 50'den büyüktür.");
            }
            else
            {
                Console.WriteLine("Ortalamanız 50'den Küçüktür.");
            }
            Console.ReadLine();


        }
    }
}
