using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanAlinanSayilarUzerindeİslemYapma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- Kullanıcıdan 10 tane int değer alacağız 
            // 2- Kaç adet Tek, kaç adet çift eleman olduğunu öğreneceğiz 
            // 3- Son olarak Çift değerlerin toplamı Tek değerlerin toplamından büyükse Çift değerlerin toplamı büyüktür yazsın
            // 4- eğer teklerin toplamı büyükse tek değerlerin toplamı büyüktür yazsın

            int[] sayilar = new int[10]; // 10 elemanlı bir dizi tanımladım Değer vermedim kullanıcı vereceği için

            int tekAdetToplam = 0; // Tek adet toplam değişkeni yaptım kaç tane tek adet sayı girdiğini anlamak için kullanıcının
            int ciftAdetToplam = 0;// cift adet toplam değişkeni yaptım kaç tane çift adet sayı girdiğini anlamak için kullanıcının.

            int tekSayilarinToplami = 0; // Kullanıcının girdiği tek sayıların toplamını öğrenmek için teksayılarintoplamı degiskeninini oluşturdum
            int ciftSayilarinToplami = 0;// Kullanıcının girdiği çift sayıların toplamını öğrenmek için çiftsayılarintoplamı degiskeninini oluşturdum
            int kullaniciDeger;// kullanıcıdan değer almak için kullanıcı değer isminde boş bir değişken oluşturdum 

            for (int i = 0; i < sayilar.Length; i++) // sonra 0 dan başlayan ve kullanıcının gireceği sayilar dizisinin uzunluğu kadar dönen döngü oluşturdum
            {
                Console.Write((i + 0) + ". index değerini giriniz : "); // burdaki i + 0 demek i 0 dan başlıyor döngüdeki 0+ 0 . index değerini girecek 
                // sonrasında döngü döndüğünde i 1 olacak ve 1+0 dan 1. index değerini girecek böyle böyle tüm index değerlerini alacağız kullanıcıdan 

                kullaniciDeger = int.Parse(Console.ReadLine()); // Kullanıcıdan aldığımız değeri int veri tipine dönüştürdüm.

                sayilar[i] = kullaniciDeger; // Kullanıcının girdiği değerleri dizinin içine ekleyen method budur.
            }

            for (int j = 0; j < sayilar.Length; j++)
            {

                if (sayilar[j] % 2 == 0) // Sayilar dizisinin j. indexinin 2 ye bölümünden kalan 0 sa çift değilse tektir 
                {
                    ciftAdetToplam++; // kalan 0 sa çift adet toplamı arttır 
                    ciftSayilarinToplami += sayilar[j]; // çift sayıların toplamını yaz 
                }
                else
                {
                    tekAdetToplam++;
                    tekSayilarinToplami += sayilar[j];
                }
            }

                if (ciftSayilarinToplami > tekSayilarinToplami)
                {
                    Console.WriteLine("Çift Sayıların Toplamı Tek sayıların toplamından büyüktür.");
                }
                else
                {
                    Console.WriteLine("Tek sayıların toplamı çift sayıların toplamından büyüktür.");
                }

                Console.WriteLine("*******************************************************************");
                Console.WriteLine("Çift sayıların toplamı : " + ciftSayilarinToplami);
                Console.WriteLine("Çift sayıların adedi : " + ciftAdetToplam);
                Console.WriteLine("*******************************************************************");

                Console.WriteLine("Tek sayıların toplamı : " + tekSayilarinToplami);
                Console.WriteLine("Tek sayıların adedi : " + tekAdetToplam);

                Console.ReadLine();

            }
        }
    }

