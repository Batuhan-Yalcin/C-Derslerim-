using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeİleOrnek4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Bu Örnekte Şunlar Yapılacak .. 
            // Bir sınıf oluşturun, bu sınıf Kitap olacak. Kitap sınıfının içinde şunlar olacak:
            // Kitap Adı (string) - Kitabın adı.
            // Yazar (string) - Kitabın yazarı.
            // Sayfa Sayısı (int) - Kitabın sayfa sayısı.
            // Okunma Durumu (bool) - Kitap okunup okunmadığı bilgisini tutacak. Başlangıçta false olacak.

            // Kitap Bilgilerini Gösterme (void) - Kitabın adını, yazarını, sayfa sayısını ve okunma durumunu ekrana yazdıran bir metod
            // Okuma Durumunu Değiştirme (void) - Kitabın okunup okunmadığını değiştiren bir metod. Okunmadıysa true yapacak, okunduysa false yapacak.
            // Bir Kitap nesnesi oluşturun ve metodları kullanarak kitaba ait bilgileri görüntüleyin, okuma durumunu değiştirin ve tekrar bilgileri görüntüleyin.


            Kitap kitap = new Kitap();

            kitap.OKUNMADURUMU = true;
            kitap.KİTAPADİ = "Arsen Lüpen Kibar hırsız.";
            kitap.SAYFASAYİSİ = 220;
            kitap.YAZAR = "Batuhan Yalçın";
            
            
            kitap.KitapBilgileriniGoster();

            
            Console.ReadLine();

        }
    }
}
