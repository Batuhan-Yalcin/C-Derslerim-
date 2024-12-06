using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicileriPUBLİC_PRİVATE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ERİSİM BELİRLEYİCİLERİ NEDİR : Birşeye Erişmek İçin Koymuş Olduğumuz Kısıtlamalar Anlamına Gelir.

            // PUBLİC ERİŞİM BELİRLEYİCİSİ : HerYerden Erişilebilen Erişim Belirleyicisidir.
            // PROTECTED ERİŞİM BELİRLEYİCİSİ : Farklı paketlerde olup sınıfı miras almayanlar erişemez. Erişebilenler : aynı sınıf içinden, alt sınıflardan,aynı paketten olanlar
            // PRİVATE ERİŞİM BELİRLEYİCİSİ : Sadece Bulunduğu Class İçerisinden Erişilebilen Erişim Belirleyicisidir. Yani dış dünyaya kapalıdır..
            // İNTERNAL ERİŞİM BELİRLEYİCİSİ : Yalnızca aynı proje veya derleme (assembly) içerisindeki kodlardan erişime izin verir. Proje dışından erişim mümkün değildir.




            Musteri musteri1 = new Musteri();
            musteri1.isim = "Batuhan";
            musteri1.soyisim = "Yalçın";
            musteri1.maasDegeri = 30000;
            musteri1.cinsiyet = "Erkek";

            musteri1.musteriBilgileriGoster();

        }
    }
}
