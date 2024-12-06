using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace StaticİleDegiskenKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static İle Değişken Kullanımı ve çalışma mantığı..

            Calisan c1 = new Calisan();

            c1.calisanİd = 1; // Static Olmayan Degisken
            c1.isim = "Batuhan"; // Static Olmayan Degisken
            c1.soyisim = "Yalçın"; // Static Olmayan Degisken

            Calisan.maas = 5000; // Static olarak belirttiğimiz değişken.

            Console.WriteLine("Çalışanın Idsi : " +c1.calisanİd);// Static Olmayan Degiskeni Ekrana Yazdırma
            Console.WriteLine("Çalışanın İsmi : " +c1.isim);     // Static Olmayan Degiskeni Ekrana Yazdırma
            Console.WriteLine("Çalışanın Soyadı : " + c1.soyisim); // Static Olmayan Degiskeni Ekrana Yazdırma
            Console.WriteLine("Çalışanın Maaşı : " +Calisan.maas); // Static Olan Degiskeni Ekrana Yazdırma
            Console.ReadLine();

           

        }
    }
}
