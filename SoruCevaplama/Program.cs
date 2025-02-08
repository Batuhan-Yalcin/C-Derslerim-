using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCevaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
 * 1. SORU = Sayının Pozitif Mi negatif mi nötr mü olduğunu bulma Sayı 0 dan büyükse Pozitif 0 ise nötr 0 dan küçükse negatif yazdır
 * 2. SORU = Kullanıcıdan yaşını iste. Kullanıcının yaşı 13 den küçükse Çocuk yazsın 13den büyük eşitse ve 19 dan Küçük eşitse Genç değilse Yetişkin yazdır
 * 3. SORU = For döngüsü kullanarak 1 den 20 ye kadar olan sayıları yazdır 
 * 4. SORU = For Döngüsü kullanarak 1 den 20 ye kadar olan sayılardan çift olanları ekrana yazdır.
     */


            for (int i = 0; i <= 20; i++)
            {
                if(i%2 == 0)
                {
                    Console.Write(i);
                }

               
            }

    Console.ReadLine();






        }
    }
}
