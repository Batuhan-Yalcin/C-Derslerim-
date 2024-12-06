using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakPointVeToolTipDersleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BREAK POİNT ŞUDUR 
            // YAZMIŞ OLDUĞUMUZ KODLARI DERLEYİCİ NASIL DERLİYOR 
            // BU ADIMLAR NASIL GERÇEKLEŞİYOR 
            // YAZDIĞIMIZ KODLARIN İLK HANGİSİ ÇALIŞIYOR 
            // DEĞERİ ALIYOR NEREYE KOYUYOR NEREYE GÖTÜRÜYOR GİBİ ŞEYLERİ 
            // İZLEME FIRSATI VEREN BİR ARAÇTIR.

            // TOOL TİP İSE ÖRNEK CONSOLE SINIFININ WRİTELİNE KISMINI KULLANDIĞIMIZDA SAĞDA 
            // BİR PENCERE AÇILIYOR Oradaki şey tooltip dir hata aldığımızda vs 
            // TOOL TİP PENCERESİNDE YAZAR BU ŞEKİLDE HATANIN NEYDEN KAYNAKLI OLDUĞUNU ANLARIZ.


            int a = 3; // incelemek istediğimiz yerin en sol kısmına gelip bir tane tıklıyoruz ve kırmızı nokta oluşuyor
            // sonra start a basıyoruz.
            // Daha Sonrasında f10 tuşu ile devam ediyoruz ve herşeyin nasıl başladığını nasıl ilerlediğini 
            // Ekranda izleyebiliyoruz. BUNA BREAKPOİNT DENİR . 
            int b = 5;
            int c = 10;

            int sonuc = a+ b + c;
            Console.WriteLine(sonuc);  

            Console.ReadLine();

            
        }
    }
}
