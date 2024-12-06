using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukturVeBuyukEsitOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BÜYÜKTÜR OPERATÖRÜ = >
            // BÜYÜK EŞİTTİR OPERATÖRÜ = >=

            // ARALARINDAKİ FARKLARI İNCELEYELİM ŞİMDİ..

            int yas = 22;

            bool kontrolEt = yas > 18; // BURADA YAŞIM 18DEN BÜYÜK MÜ DİYE SORU SORDUK

            bool kontrolEt2 = yas >= 22; // BURADA YAŞIM 22 DEN BÜYÜK VEYA EŞİT Mİ DİYE SORDUM 


            Console.WriteLine("Yaşım 18 Den  Büyük mü ? : " +kontrolEt);
            Console.WriteLine("Yaşım 22 Den Büyük veya Eşit mi ? : "+kontrolEt2); 


            Console.ReadLine();
        }
    }
}
