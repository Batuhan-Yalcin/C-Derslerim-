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
