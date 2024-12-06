using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationKAPSULLEMEYEgiris
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ENCAPSULATİON (KAPSÜLLEME) NEDİR ? : Kapsülleme Private olarak belirttiğimiz bir Erişim belirleyicisine sadece classlardan ulaşabiliyoruz demiştik 
            // Bir uygulama yaptığımızı varsayalım ve isim adında bir değişkenimiz var buna kullanıcı erişememesi için private yaptık ama diyelimki buna biz erişmek istedik
            // PRİVATE HİÇBİRYERDEN ERİŞİLEMEZ DEMİŞTİK E BİZ BUNA ERİŞMEMİZ GEREKİYOR İŞTE KAPSÜLLEME BURADA DEVREYE GİRİYOR.
            // ÖRNEK VERELİM..

            // Ogrenci İsminde bir classımız var diyelim..

            // public class Ogrenci 
            // {
            // private string isim = "Batu";
            // }

            // Main metodumuzdan Kapsülleme Sayesinde private değere erişme .. 

            // public static void Main(string[] args) 
            // {
            // Ogrenci Ogrenci1 = new Ogrenci();
            // Console.WriteLine(Ogrenci1.isim);

        }
    }
}
