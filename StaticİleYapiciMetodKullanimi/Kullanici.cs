using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticİleYapiciMetodKullanimi
{
    public class Kullanici
    {

        private int kullaniciID { get; set; }
        private static int maas { get; set; }
        private string isim { get; set; }
        private  string soyisim { get; set; }


        static Kullanici () // PROGRAM ÇALIŞTIĞINDA İLK BAŞTA STATİC YAPICI METODUNA BAKAR ONU ÇALIŞTIRIR DAHA SONRASINDA Kullanci Yapıcı Metodu Çalışır.
        {
            maas = 2500; 
            // static ile yapıcı metod oluşturma bu şekildedir.
        }

        public Kullanici(int KULLANİCİİD, string İSİM,string SOYİSİM)
        {
            kullaniciID = KULLANİCİİD;
            isim = İSİM;
            soyisim = SOYİSİM;
           
        }



        public void BilgileriGoster()
        {
            Console.WriteLine("Kullanıcı Bilgileri : ");
            Console.WriteLine("Kullanıcının ID'si : " + kullaniciID);
            Console.WriteLine("Kullanıcının İsmi : " +isim);
            Console.WriteLine("Kullanıcının Soyismi : " + soyisim);
            Console.WriteLine("Kullanıcının Maaşı : " +maas);
        }

        public void zamYap(int zamMiktari)
        {
            Console.WriteLine("Kullanıcıya Zam Yapılıyor..");
            Console.WriteLine("Şuan ki Maaşı : " +(maas+zamMiktari));
        }


    }
}
