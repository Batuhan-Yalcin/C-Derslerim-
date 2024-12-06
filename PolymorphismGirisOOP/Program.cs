using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGirisOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // POLYMORPHİZM OVERRİDE NEDİR ? : POLYMORPHİZM OVERRİDE BİR CLASSTA YAZDIĞIMIZ METODUN DİĞER CLASSLARDA FARKLI ŞEKİLDE KULLANMAMIZA YARAR
            // MESELA HAYVAN CLASSINDA KONUŞ İSMİNDE BİR METOT TANIMLADIM.
            // O METODU KEDİ CLASSINDA KEDİYİ MİYAVLATMAK İÇİN KULLANDIM. KÖPEK CLASSINDA HAVLATMAK İÇİN KULLANDIM. HAYVAN CLASSINDA HAYVAN KONUŞUYOR
            // YAZDIRMAK İÇİN KULLANDIM.. YANİ 1 METOD TANIMLADIM VE 3 FARKLI ŞEKİLDE AYNI METODU KULLANDIM OVERRİDE İŞLEMİ İLE 


            // Bizler Bir Metodun Farklı classlarda farklı işi yapmaları için polymorphizm i kullanırız.
            // ve override edebilmesi için erişim belirleyicisinden sonra virtual anahtar kelimesini eklemek zorundayız metoda.
            /*
            Hayvan hayvan = new Hayvan("Hayvan");
            hayvan.konus();

            Kedi kedi = new Kedi("Tekir");
            kedi.konus();

            Kopek kopek = new Kopek("Karabaş");
            kopek.konus();

            Console.ReadLine(); */

            // 2. Çağırma Yöntemi 
            // aşağıya Hayvanları konuştur metodu tanımladım ve Hayvan clasından hayvan isminde bir parametre verdik ve konuş metodunu çağırdık.

            HayvanlariKonustur(new Kedi ("Kedi Sınıfı Konuştu"));
            HayvanlariKonustur(new Kopek("Köpek Sınıfı Konuştu"));
            

        }

        public static void HayvanlariKonustur(Hayvan hayvan)
        {
            hayvan.konus();
        }

    }
}
