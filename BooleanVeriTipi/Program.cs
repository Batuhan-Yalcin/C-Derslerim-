using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boolean Veri Tipi 2 ihtimalin olduğu yerlerde kullanılır TRUE - FALSE DEĞERİ DÖNDÜRÜR.
            // KULLANIMI ÖRNEK İLE ŞU ŞEKİLDEDİR = ALİ YEMEĞİNİ YEDİ Mİ ? TRUE VEYA FALSE OLARAK DÖNER
            // YADA KULLANICI PAROLAYI GİRDİ Mİ ? TRUE- FALSE OLARAK DÖNER.
            // bool olarak yazılır 

            

            bool kontrol = false;
            bool kontrol2 = true;

            bool sonuc = 10 > 5; // 10 5 den büyük mü diye sorduk.

            Console.WriteLine(sonuc); // Yazdırdığımızda TRUE Değeri Dönmüştür. Çünkü 10 sayısı 5 sayısından büyüktür.

            Console.ReadLine();
        }
    }
}
