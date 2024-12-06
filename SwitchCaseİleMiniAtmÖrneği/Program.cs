using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseİleMiniAtmÖrneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MİNİ ATM UYGULAMASI YAPILACAKLAR ; 
            // KULLANICIDAN DEĞER ALACAĞIZ.
            // ALDIĞIMIZ DEĞERLERE GÖRE ŞU İŞLEMLERİ YAPACAĞIZ.
            // 1- BAKİYE GÖRÜNTÜLEME 
            // 2- PARA ÇEK
            // 3- PARA YATIR
            // 4- ÇIKIŞ YAP 
            // 1 - 2 - 3 - 4 DIŞINDA BİR TUŞA BASILDIYSA HATALI DEĞER GİRİLDİ YAZSIN.



            int bakiye = 1500;

            Console.WriteLine("ATM'ye Hoşgeldiniz.");
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");


            Console.WriteLine("1 - Bakiye Görüntüleme");
            Console.WriteLine("2 - Para Çekme");
            Console.WriteLine("3 - Para Yatırma");
            Console.WriteLine("4 - Çıkış Yap");

            string secim = Console.ReadLine();


            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz : "+bakiye);
                    break;

                    case "2":
                    Console.WriteLine("Çekmek İstediğiniz Para Miktarını Giriniz : ");
                    int cekilecekTutar = Convert.ToInt32(Console.ReadLine());

                    if (cekilecekTutar > bakiye)
                    {
                        Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan Bakiyeniz : " + (bakiye-cekilecekTutar));
                    }
                    break;

                    case "3":
                    Console.WriteLine("Yatırmak İstediğiniz Para Tutarını Giriniz : ");
                    int paraYatir = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Yeni Bakiyeniz : " +(bakiye+paraYatir));   
                    break;

                    case "4":
                    Console.WriteLine("Hesabınızdan Çıkış Yapılıyor İyi Günler..");
                    break;
                    
                    default:
                    Console.WriteLine("Lütfen Geçerli Bir Tuşlama Yapınız.");
                    break ;
                    
            }
            Console.ReadLine();

        }

    }
}