using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslarGercekHayattaKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // BİZİM BU ÖRNEKTE YAPTIĞIMIZ İŞLEM ŞU REPOSİTORY İSMİNDE BİR CLASS OLUŞTURDUK T TİPİNİ VERDİK.
            // VE 2 ADET METOT YAZDIK BUNLARA T TİPİNİ VERDİK.
            // BU YAZMIŞ OLDUĞUMUZ METOTLAR BİZE GÖNDERİLEN TÜM TİPLERE HİZMET EDİYOR.
            // YANİ URUNDE GÖNDERSEK KABUL EDER MUSTERİ DE PERSONEL DE KİŞİDE HİÇ FARKETMEZ..
            // TEK BİR METOT YÜZLERCE TİPE HİZMET EDİYOR YANİ..

            //   repositoryMusteri.Getir(); // Bakın bu metotta bana T tipinde bir değer dönüyor sebebi ise Repository classımızda T tipinde bir tanımlama yaptık 
            // Ve muster classından örnek oluşturduğumuzda artık Musteri classının içinde ki herşeye T koydu gibi düşünebiliriz.. Artık bizim buradaki getir metodumuz
            // Müşteri tipinde dönüyor..

            // repositoryUrun.Getir(); Bakın bu metotta da bize urun tipinde bir liste dönüyor.. aynı metot farklı tiplere hizmet edebiliyor generic classlarda..

            Repository<Musteri> repositoryMusteri = new Repository<Musteri>();
            List<Musteri> musterilerim = repositoryMusteri.Getir();
            

            Musteri musteri = new Musteri();
            musteri.id = 1;
            musteri.isim = "Batuhan";
            musteri.soyisim = "Yalçın";
            musteri.email = "batu@gmail.com";

            repositoryMusteri.ekle(musteri);



            Repository <Urun> repositoryUrun = new Repository<Urun>();
            List <Urun> urunlerim =   repositoryUrun.Getir();


            Urun urun = new Urun();

            urun.urunID = 1;
            urun.isim = "ram bellek";
            urun.urunFiyat = 5000;

           string cikti = repositoryUrun.ekle(urun);
            Console.WriteLine(cikti);
            Console.ReadLine();
           


        }
    }
}
