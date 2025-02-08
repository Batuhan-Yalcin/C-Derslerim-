using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Banka isminde Base Class olsun
            // AskerKredisi  Classı Olsun
            // OgretmenKredisi Classı Olsun
            // OgrenciKredisi Classı olsun

            // Banka Classında 2 method olacak methodların ismi ;
            // KrediHesaplama(); KrediCiktiMi();
            // Diğer Classlarda bu methodu override edecek ve kendine göre değişecek 


            /*
           Kopek kopek = new Kopek();
            Kedi kedi = new Kedi();

            kopek.sesCikar();
            
            Bmw bmw = new Bmw();
            Audi audi = new Audi();
            Mercedes merc = new Mercedes();

            bmw.arabaRengi();
            bmw.arabaKm();
            bmw.arabaSesi();
            Console.WriteLine("------------------------");
            merc.arabaRengi();
            merc.arabaKm();
            merc.arabaSesi();
            Console.WriteLine("------------------------------");
            audi.arabaRengi();
            audi.arabaKm();
            audi.arabaSesi();
            
            ogrencikredisi ogrenci = new ogrencikredisi();
            askerkredisi asker = new askerkredisi();
            ogretmenkredisi ogretmen = new ogretmenkredisi();

            ogrenci.kredihesaplama();
            ogrenci.krediciktimi();
            Console.WriteLine( "--------------------------");
            asker.krediciktimi();
            asker.kredihesaplama();
            Console.WriteLine("------------------------------");
            ogretmen.kredihesaplama();
            ogretmen.krediciktimi();
           

            Ogretmen ogretmen = new Ogretmen("Batuhan", "Yalçın", 23);
            ogretmen.setIsim ("Batu");
            ogretmen.ogretmenBilgileri();
             */

            // Calisan Base Class olsun
            // Muhendis Ogretmen, Doktor Classları olacak 
            // her classın kendine ait Private olarak isim soyisim yas değişkenleri olacak (encapsulation)
            // Calisan classında 2 method olacak CalisanBilgileri(); CalisanDurumu();
            // Diğer classlarda onu override edecek..

            ogretmen2 ogretmen2 = new ogretmen2();
            mühendis mühendis1 = new mühendis();
            doktor doktor1 = new doktor();

            ogretmen2.setisim("Metehan");
            ogretmen2.setsoyisim("AYAN");
            ogretmen2.setyas(15);

            ogretmen2.calisanbilgileri();
            ogretmen2.calisanulke();
            ogretmen2.calisandurumu();
            Console.WriteLine("------------------------");
            mühendis1.setisim("Batuhan");
            mühendis1.setsoyisim("YALÇIN");
            mühendis1.setyas(23);

            mühendis1 .calisanbilgileri();
            mühendis1 .calisanulke();
            mühendis1 .calisandurumu();
            Console.WriteLine("---------------------------");
            doktor1 .setisim("Mehmet");
            doktor1.setsoyisim("KARASU");
            doktor1.setyas(14);

            doktor1.calisanbilgileri();
            doktor1.calisanulke();
            doktor1.calisandurumu();


            // Canlı İsminde base class oluştur
            // İnsan Classı oluştur
            // Hayvan classı oluştur
            // Bitki Classı oluştur
            // Her sınıfın kendine ait yapıcı methodu olsun değişkenleri parametre olarak alsın
            // Örnek insan için public İnsan(string isim,string soyisim,int yas) this.isim=isim; this.soyisim=soyisim;this.yas=yas; gibi..
            // Canlı classında NefesAlma(); Yasama(); Methodları olsun Bu methodları diğer classlar override etsin kendine göre
            // İnsan, hayvan, bitki classının kendine ait değişkenleri olsun private get-set kullan
            // örnek insanda isim soyisim yaş , hayvanda isim cins yas , bitkide tur renk isminde değişkenler olabilir.
            // Bunları program.cs classında çağır ve kullan
        }
    }
}
