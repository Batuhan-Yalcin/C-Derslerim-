using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyİleKapsullemeKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PROPERTY NEDİR ? : Kapsülleme yapmanın 2. yöntemidir Kullanımı : 
            // Açmış Olduğumuz Musteri Classına Prop yazıp 2 kere taba basınca public int MyProperty { get; set; } böyle birşey çıkıyor
            // Kullanımı ise şu şekildedir ..
            //  private int kilo; private erişim belirleyicisinde kilo değerini oluşturduk.
            //   public int PropKilo {  PropKilo isminde MyProperty yazan değişkenin ismini PropKilo olarak deiştirip süslü parantezi açtık,

            // get  GET METODUMUZU YAZDIK 

            //   {     KIVIRCIK PARANTEZİ AÇTIK 

            //   return kilo;  VE KİLOYU RETURN ETMESİNİ İSTEDİK

            // }   GETİN KIVIRCIK PARANTEZİNİ KAPADIK.

            // set      SET METODUMUZU YAZDIK

            //     {    KIVIRCIK PARANTEZİNİ AÇTIK

            // kilo = value;  ATAMIŞ OLDUĞUMUZ KİLOYU BURDA VALUE İLE DEĞER ATADIK

            // } KIVIRCIK PARANTEZİNİ KAPADIK 

            // }  PROPKİLO NUN DA KIVIRCIK PARANTEZİNİ KAPATTIK.

            // KISA HALİ İLE ŞU ŞEKİLDEDİR :


            //  public int PropKilo
            //  {


            //    get
            //  {
            //    return kilo;
            // }

            //        set
            //         {

            //       kilo = value ; VALUE ANAHTAR KELİMESİ KULLANICININ GİRMİŞ OLDUĞU DEĞERİ TUTAN ANAHTAR KELİMEDİR.

            //          }

            //        }




            Musteri musteri1 = new Musteri();

            musteri1.PropKilo = 68; // Değer Ataması Yaptığım İçin Set Bloklarım Çalışır 
            // Eğer Değer Ataması Yapmasaydım O zaman Get Bloklarım Çalışacaktı.. 

            Console.WriteLine(musteri1.PropKilo);

        }
    }
}
