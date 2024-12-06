using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ARRAYLİST NEDİR ? : ARRAYLİST BİR TANE KOLEKSİYON TÜRÜDÜR. BİZİM İSTEDİĞİMİZ TİPDEKİ DEĞERLERİMİZİ TUTAN VE İÇERİSİNDE YARDIMCI METODLARI BARINDIRABİLEN 
            // BİR SINIFTIR..

            // ASLINDA ÇALIŞMA MANTIĞI DİZİ GİBİDİR FAKAT DİZİLER ARRAYLİST'E GÖRE BİRAZCIK DAHA İLKEL KALIYOR GELİN ARRAYLİST NASIL YAZILIR BİRLİKTE GÖRELİM..

            // DİZİ OLUŞTURMA...
          //  string[] isimler = { "Sa", "AS", "XD" };
         //   foreach (string s in isimler)
           // {
            //    Console.WriteLine(s);
            //}
            //Console.ReadLine();


            ArrayList koleksiyon = new ArrayList(); // ArrayList Oluşturma Yöntemi..

            koleksiyon.Add("Batubey"); // Add metodu Koleksiyonumuza Değerler Eklemek İçin Kullanacağımız metottur.
            koleksiyon.Add("Sami");    // Add metodu Koleksiyonumuza Değerler Eklemek İçin Kullanacağımız metottur.
            koleksiyon.Add("Hüseyin"); // Add metodu Koleksiyonumuza Değerler Eklemek İçin Kullanacağımız metottur.
            koleksiyon.Add("ali");     // Add metodu Koleksiyonumuza Değerler Eklemek İçin Kullanacağımız metottur.

          //  koleksiyon.Remove("Sami"); // Remove Metodu Koleksiyondan istediğimiz Bir Değeri Kaldırmamıza Yarar..

            int diziCountu = koleksiyon.Count; // Count Metodu Koleksiyonun Eleman Sayısını Gösteriyor. yani dizide kaç adet girili değer olduğunu..

           // koleksiyon.Clear(); // Clear Metodu ArrayList'imizin İçinde Tüm Değerleri Temizler. Clear dedikten sonra çıktı da hiçbirşey göremeyiz..

        bool kontrol = koleksiyon.Contains ("Batubey"); // Contains Metodu Dizide .. Değeri Varmı diye kontrol eder yani burada dizimde Batubey Değeri Varmı Kontrol et dedim.
            // VARSA TRUE YOKSA FALSE DÖNER..

          int index = koleksiyon.IndexOf("Batubey"); // IndexOf Metodu ise Dizimdeki Batubey isimli kişinin index numarası kaçtır diye sorar ve index numarasını döndürür.
            // Batubey 0. indexte olduğu için ekrana yazdırdığımızda 0 değerini verir.

            koleksiyon.Insert(2, "Ekledim"); // Instert Metodu ise Diziye ekleme yapabiliyor Yani burada dedimki 2. index e Ekledim isminde bir değer ata.
            // Çalıştırdığımda ise Çıktı da : Batubey Sami Ekledim Hüseyin Ali Yazdı Yani 2. index e Ekledim yazdırdık..

            koleksiyon.Reverse(); // Reverse Metodu İse Diziyi Ters Çevirir Yani Sondan Başa Çıktı Verir Dizimde en başta batubey varken en sonda oldu
            // sami sondan 1. oldu ekledim sondan 2. hüseyin sondan 3. ali ise en başta oldu ..

            

            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(5);
            rakamlar.Add(3);
            rakamlar.Add(1);
            rakamlar.Add(100);
            rakamlar.Add(2);

            rakamlar.Sort(); // Sort metodu Rakamları Sıralı bir şekilde çıktı vermeye yarar yani yukarıda 5 - 3 -1 - 100 - 2 diye karışık tanımladığım rakamları 
            // Küçükten Büyüğe Sıralı Bir şekilde Çıktı Verdi..
            // ÇIKTI = 1 - 2 - 3 - 5 - 100 OLDU..

         //  rakamlar.ToString(); // ToString Metodu int olarak girilen değişkenleri String veri tipine dönüştürmeye yarar..

            foreach (int i in rakamlar)
            {
                Console.WriteLine(i);
            }


            foreach (var a in koleksiyon)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Dizinin Eleman Sayısı : " +diziCountu); // Çıktı = 3 çükü samiyi remove metodu ile silmiştik..
            Console.WriteLine("Dizimde Batubey isimli birisi var mı ? " +kontrol); // ÇIKTI : TRUE 
            Console.WriteLine("Batubey'in İndex Numarası Kaçtır ? : " +index); // ÇIKTI : 0 Çünkü Batubey'in index değeri 0'dır.
            
            Console.ReadLine();

        }
    }
}
