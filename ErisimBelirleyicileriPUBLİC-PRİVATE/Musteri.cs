using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicileriPUBLİC_PRİVATE
{
    public class Musteri
    {
        public string isim;
        public string soyisim;
        public string cinsiyet;

        public int maasDegeri;
        private int yas;

        public Musteri()
        {
            Console.WriteLine("Müşteri Sınıfının Yapıcı Metodu Çalıştı..");
        }

        public void musteriBilgileriGoster()
        {
            Console.WriteLine("İSİM : " +isim);
            Console.WriteLine("Soyisim : " + soyisim);
            Console.WriteLine("Maaş Değeri : " +maasDegeri);
            Console.WriteLine("Cinsiyet : " +cinsiyet);
            Console.WriteLine("Yaş : " +yas);

            private  void isimSoyİsimYazdir(string Musterininİsmi,string musterininSoyismi)
             {
            Console.WriteLine("Müşterinin İsmi Ve Soyismi : " +Musterininİsmi + " " +musterininSoyismi);

             }


        }
    }

