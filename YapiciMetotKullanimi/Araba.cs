using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOlusturma
{
    public class Araba // ARABA ADINDA BİR CLASS OLUŞTURDUK.
    {
        public int kapiSayisi; // KAPI SAYISI İSMİNDE BİR DEĞİŞKEN OLUŞTURDUK
        public String arabaModeli; // ARABA MODELİ İSMİNDE BİR DEĞİŞKEN OLUŞTURDUK
        public string arabaRengi; // ARABA RENGİ İSMİNDE BİR DEĞİŞKEN OLUŞTURDUK


        public Araba(int _kapiSayisi, string _arabaModeli, string _arabaRengi) // YAPICI METOT TANIMLAMA.. KISA YOLU ctor yazıp 2 kere taba basarsak kendi oluşturur..
        {
            // değişken olarak girdiğimiz değerleri parametre olarak girdiğimiz _li değişkenlere atıyoruz Parametre : yapıcı metodun parantezndeki girdiklerimiz..
            kapiSayisi = _kapiSayisi;
            arabaModeli = _arabaModeli;
            arabaRengi = _arabaRengi;
            
        }

        

        public void arabaMotoruCalistir() // ARABA MOTORU ÇALIŞTIR İSMİNDE BİR METOT TANIMLADIK
        {
            Console.WriteLine("MOTOR ÇALIŞIYOR...");    // MOTORU ÇALIŞTIRDIGINI EKRANA YAZDIRDIK
        }

        public void KapilariKilitle() // KAPILARI KİLİTLE METODU TANIMLADIK
        {
            Console.WriteLine("Kapılar Kilitleniyor.."); // KAPILAR KİLİTLENİYOR YAZDIRDIK.
        }

    }
}
