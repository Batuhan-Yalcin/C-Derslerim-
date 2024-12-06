using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnİleGeriyeDegerDondurenMetotTanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PARAMETRE ALAN - GERİYE DEĞER DÖNDÜREN METOT TANIMLAMA.
            // RETURN ANAHTAR KELİMESİ  = Geriye döndür demektir..
            // METOT SONU.

          int donenDeger =   ToplamaYap(6, 7);
             
            // Metottan gelen değerleri de böyle kontrol yapabiliriz mesela Bu örnek olarak yapıldı ..
            if (donenDeger > 10)
            {
                Console.WriteLine("Dönen Değer 10'dan Büyüktür..");
            }
            else 
            {
                Console.WriteLine("Dönen Değer 10'dan Küçüktür.."); 
            }

            // string ile geriye değer döndüren metot çağırılışı  :
            string GelenİsimSoyisimDegeri = isimSoyİsimYazdir("BATUHAN", "YALÇIN");
            Console.WriteLine(GelenİsimSoyisimDegeri);

            Console.ReadLine();

        }

        static int ToplamaYap(int sayi1 , int sayi2) //  static den sonra void kullanmadık çünkü ; void geriye değer döndürmez değer döndürmesini istediğimiz veri tipini 
            // belli ettik yani int sonrrasında toplamayap isminde değişken yaptık ve paranteze int sayi1 - int sayi2 adında değişkenlerimizi oluşturduk.
        {
            int sonuc = sayi1 + sayi2; // sonuç isminde bir değişken oluşturduk ve sayi1 + sayi 2 dedik 2 sayıyı toplamasını istedik 
            return sonuc; // return sonuc dedik yani sonucu tekrar et anlamında.
        }

        // string ile geriye değer döndüren metot tanımı 
        static string isimSoyİsimYazdir(string isim, string soyisim)
        {
            return isim + " " + soyisim;
            
        }
    }
}
