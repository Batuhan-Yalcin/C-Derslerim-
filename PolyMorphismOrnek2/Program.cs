using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismOrnek2
{
     class Program
    {
        static void Main(string[] args)
        {

            // Şekil Uygulaması 
            // Şekil Bilgilerini Gösteren , Şekli Hesaplayan Metotları Override İşlemi - Polymorphism kullanarak hesaplama

            Console.WriteLine("Şekil Uygulamasına Hoşgeldiniz...");

            while (true)
            {
                Console.WriteLine("İşlem Seçiniz : ");
                Console.WriteLine("1 - Dikdörtgen İşlemleri");
                Console.WriteLine("2 - Üçgen İşlemleri");
                Console.WriteLine("3 - Kare İşlemleri");
                Console.WriteLine("4 - q tuşuna basarak çıkınız.");

                string secim = Console.ReadLine();

                if (secim == "q")
                {
                    break;
                }
                else if (secim == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("1 - Dikdörtgen alanı hesapla ");
                        Console.WriteLine("2 - Diktörtgen Bilgileri Göster ");
                        Console.WriteLine("3 - Diktörgen Çıkış Yap ");

                        string secimDikdortgen = Console.ReadLine();

                        if (secimDikdortgen == "1")
                        {
                            Console.WriteLine("Kısa Kenarı Giriniz : ");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Uzun Kenarı Giriniz : ");
                            int uzunkenar = Convert.ToInt32(Console.ReadLine());

                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", kisakenar, uzunkenar);
                            dikdortgen.sekilHesapla();
                        }
                        else if (secimDikdortgen == "2")
                        {
                            Console.WriteLine("Kısa Kenarı Giriniz : ");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Uzun Kenarı Giriniz : ");
                            int uzunkenar = Convert.ToInt32(Console.ReadLine());

                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", kisakenar, uzunkenar);
                            dikdortgen.sekilBilgileriGoster();
                        }
                        else if (secimDikdortgen == "q")
                        {
                            Console.WriteLine("Dikdörtgen İşlemlerinden Çıkılıyor..");
                            
                            break;
                        }

                    }
                }
                else if (secim == "2")
                {

                        while (true)
                    {
                        Console.WriteLine("1 - Üçgen alanı hesapla ");
                        Console.WriteLine("2 - Üçgen Bilgileri Göster ");
                        Console.WriteLine("3 - Üçgenden Çıkış Yap ");

                        string secimUcgen = Console.ReadLine();

                        if (secimUcgen == "1")
                        {
                            Console.WriteLine("Üçgenin Tabanını Giriniz : ");
                            int ucgenTaban = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Üçgenin Yüksekliğini Giriniz : ");
                            int ucgenYukseklik = Convert.ToInt32(Console.ReadLine());

                            Ucgen ucgen = new Ucgen("Üçgen", ucgenTaban, ucgenYukseklik);
                            ucgen.sekilHesapla();
                        }
                        else if (secimUcgen == "2")
                        {
                            Console.WriteLine("Üçgenin Tabanını Giriniz : ");
                            int ucgenTaban = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Üçgenin Yüksekliğini Giriniz : ");
                            int ucgenYukseklik = Convert.ToInt32(Console.ReadLine());

                            Ucgen ucgen = new Ucgen("Üçgen", ucgenTaban, ucgenYukseklik);
                            ucgen.sekilBilgileriGoster();
                        }
                        else if (secimUcgen == "q")
                        {
                            Console.WriteLine("Üçgen İşlemlerinden Çıkış Yapılıyor..");
                            
                            break;
                        }
                    }
                    
                }

                else if (secim == "3")
                {

                    while (true)
                    {
                        Console.WriteLine("1 - Kare alanı hesapla ");
                        Console.WriteLine("2 - Kare Bilgileri Göster ");
                        Console.WriteLine("3 - Kare den Çıkış Yap ");
                        string kareSecim = Console.ReadLine();

                        if (kareSecim == "1")
                        {
                            Console.WriteLine("Karenin Kenarını Giriniz : ");
                            int kareKenar = Convert.ToInt32(Console.ReadLine());
                             
                            Kare kare = new Kare("Kare", kareKenar);
                            kare.sekilHesapla();
                        }
                        else if (kareSecim == "2")
                        {
                            Console.WriteLine("Karenin Kenarını Giriniz : ");
                            int kareKenar = Convert.ToInt32(Console.ReadLine());
                            Kare kare = new Kare("Kare", kareKenar);
                            kare.sekilBilgileriGoster();

                        }
                        else if (kareSecim == "q")
                        {
                            Console.WriteLine("Kare İşleminden Çıkış Yapılıyor..");
                            
                            break;
                            
                        }
                       
                    }
                }

                else
                {
                    Console.WriteLine("Geçersiz Bir Değer Girdiniz..");
                }
                
                }

            }

        }
    }

