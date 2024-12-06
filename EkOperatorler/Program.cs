using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkOperatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ARTI EŞİTTİR OPERATÖRÜ = +=
            // EKSİ EŞİTTİR OPERATÖRÜ = -=
            // BÖLÜ EŞİTTİR OPERATÖRÜ = /=
            // ÇARPI EŞİTTİR OPERATÖRÜ = *=

            int a = 5;
            a += 4; // a nın üzerine 4 ekle ve a değişkenine ata dedim ve çıktı 9 oldu
            // diğerlerinin kullanımı da şu şekil 
           
            // a -=3; a değişkeninden 3 çıkar ve a nın içine tekrar ata dedim
            // a *=3; a değişkenini 3 ile çarp ve tekrar a nın içine ata dedim
            // a /=3; a değişkenini 3 e böl ve tekrar a nın içine ata dedim.

            Console.WriteLine("a ' nın değeri : " +a); 

            Console.ReadLine();

        }
    }
}
