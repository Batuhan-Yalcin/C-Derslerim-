using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirisUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcı Giriş Sayfası Uygulaması Yapacağız.
            // Kullanıcı adı ve şifresini doğru girerse Tebrikler Başarılı Bir Şekilde Giriş Yaptınız Yazacak
            // Yanlış Girerse Hatalı Giriş yaptınız ve 3 hakkınız var tekrar deneyiniz yazdıracağız 
            // 3. hakkı bittiğinde giriş uygulaması bitecek

            int hakSayisi = 3;
            while (true)
            {
                Console.WriteLine("Kullanıcı Adınızı Giriniz : ");
                string KullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifrenizi Giriniz : ");
                string sifre = Console.ReadLine();

                if (KullaniciAdi == "Batuhan" && sifre == "190758")
                {
                    Console.WriteLine("Tebrikler Başarılı Bir Şekilde Giriş Yaptınız..");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı Adınız Veya Şifreniz Yanlıştır ! ");
                    if(hakSayisi > 0)
                    {
                        hakSayisi -= 1;
                    }
                    if(hakSayisi == 0)
                    {
                        Console.WriteLine("Giriş Yapma Hakkınız Dolmuştur.");
                        break;
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
