using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticİleYapiciMetodKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // STATİC ANAHTAR KELİMESİ İLE YAPICI METHOD KULLANIMI..
            // STATİC YAPICI METOD KULLANIRKEN DİKKAT EDİLMESİ GEREKENLER ;
            // STATİC YAPICI METOT ERİŞİM BELİRLEYİCİSİ ALMAZ !! (PUBLİC PRİVATE GİBİ..)
            // STATİC YAPICI METODLAR PARAMETRE ALAMAZ YANİ Static Kullanici(int maas) paranteze int maas yazamayız.. parametre paranteze yazılan şey demektir.
            // STATİC YAPICI METOT SINIFA AİT TÜM YAPICILARDAN ÖNCE ÇALIŞIR.
            // STATİC YAPICI METOT KAÇ NESNE ÖRNEĞİ OLUŞTURULURSA OLUŞTURULSUN SADECE BİR KERE ÇALIŞIR !!
            // BİR SINIF SADECE BİR TANE STATİC YAPICI METOT İÇEREBİLİR !!
            // STATİC YAPICI METOT YA İLK NESNE ÖRNEĞİ OLUŞTURULDUĞUNDA YA DA İLK STATİC SINIF ÜYESİ ÇAĞIRILMADAN HEMEN ÖNCE YÜRÜTÜLÜR.

            Kullanici k = new Kullanici(58,"Batuhan","Yalçın");

            k.BilgileriGoster();
            k.zamYap(2500);
            

            Console.ReadLine();
        }
    }
}
