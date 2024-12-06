using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAtmUygulamasiİFELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcıya Nasıl bir işlem yapmak istediğini soracağız . 
            // 1 - Bakiye Görüntüleme 
            // 2 - Para Çekme 
            // 3 - Para Yatırma
            // 4 - q Tuşuna Basarak Çıkış yapma 

            int bakiye = 1000;

            Console.WriteLine("Atm' ye Hoşgeldiniz.");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz : ");

            string secim = Console.ReadLine(); // kullanıcıdan alınan değeri secim değişkenine attık 

            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz : " + bakiye);
            }

            else if (secim == "2")
            {
                Console.WriteLine("Lütfen Çekmek İstediğiniz Para Miktarını Giriniz : ");
                int cekilecekTutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecekTutar <= bakiye)
                {
                    Console.WriteLine("Kalan Tutarınız : " + (bakiye - cekilecekTutar));
                }
                else
                {
                    Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz..");
                }
                
            }

            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak İstediğiniz Tutarı Seçiniz : ");
                int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Güncel Bakiyeniz : " + (bakiye + yatirilacakTutar));
            }

            else if (secim == "q")
            {
                Console.WriteLine("ATM'den Çıkış Yapılıyor...");
                Console.WriteLine("Çıkış Yapıldı İyi Günler.");
            }
            else
            {
                Console.WriteLine("Lütfen Geçerli Bir Giriş Yapınız.");
            }

            Console.ReadLine();
        }
    }
}
