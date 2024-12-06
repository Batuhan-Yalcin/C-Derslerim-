using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceİleUygulamaOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Çalışan , Yazılımcı , Yönetici
            // Çalışan = SuperClass


            Console.WriteLine("Çalışan Uygulamasına Hoşgeldiniz..");

          

            string secilenIslem = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("1 - Yazılımcı İşlemleri ");
                Console.WriteLine("2 - Yönetici İşlemleri");
                Console.WriteLine("Çıkış İçin q Tuşuna Basınız");

                if (secilenIslem == "q")
                {
                    Console.WriteLine("Çıkış Yapılıyor...");
                    break;
                }
                else if (secilenIslem == "1")
                {
                    Yazilimci yazilimci = new Yazilimci(1, "Batuhan", "Yalçın", "C#, Java, C++");
                    while (true)
                    {
                        Console.WriteLine("Yazılımcı İşlemi Seçiniz  : ");
                        Console.WriteLine("1 - Format At");
                        Console.WriteLine("2 - Bilgileri Göster");
                        Console.WriteLine("3 - Çıkış İçin q'ya basınız");
                        string yazilimciIslem = Console.ReadLine();

                        if (yazilimciIslem == "q")
                        {
                            Console.WriteLine("Yazılımcı İşlemlerinden Çıkış Yapılıyor..");
                            break;
                        }
                        else if (yazilimciIslem == "1")
                        {
                            Console.Write("İşletim Sistemi Giriniz : ");
                            string isletimSistemi = Console.ReadLine();
                            yazilimci.FormatAt(isletimSistemi);
                        }
                        else if (yazilimciIslem == "2")
                        {
                            yazilimci.BilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz.. !");
                        }
                    }



                }

                else if (secilenIslem == "2")
                {
                    Yonetici yonetici = new Yonetici(2, "Alparslan", "Kaya", 58);

                    while (true)
                    {
                        Console.WriteLine("Yönetici İşlemi Seçiniz  : ");
                        Console.WriteLine("1 - Zam Yap");
                        Console.WriteLine("2 - Yöneticinin Bilgilerini Göster");
                        Console.WriteLine("3 - Çıkış İçin q'ya basınız");
                        string yoneticiIslem = Console.ReadLine();
                        if (yoneticiIslem == "q")
                        {
                            Console.WriteLine("Yönetici İşlemlerinden Çıkış Yapılıyor..");
                            break;
                        }
                        else if (yoneticiIslem == "1")
                        {
                            Console.Write("Zam Miktarını Giriniz : ");
                            int zamMiktari = Convert.ToInt32(Console.ReadLine());
                            yonetici.zamYap(zamMiktari);
                        }
                        else if (yoneticiIslem == "2")
                        {
                            yonetici.BilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir Tuşlama Yapınız. !!");
                        }
                    }



                }
                else
                {
                    Console.WriteLine("Lütfen Çalışan Uygulaması İçin geçerli bir işlem giriniz. !!");
                }
                Console.ReadLine();
            }
        }
    }
}
