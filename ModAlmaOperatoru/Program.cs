using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAlmaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mod Alma operatörü = %
            // Mod alma operatörü nedir ? 2 SAYIYI BİRBİRİNE BÖLDÜĞÜMÜZDE KALAN DEĞERİ BİZE VERİR.
            // GELİN ÖRNEK İLE ANLAYALIM..

            int sayi1 = 10;
            int sayi2 = 3;

            Console.WriteLine(sayi1 % sayi2);
            // BURADA NE YAPTI SİSTEM 10 U 3 E BÖLDÜ 3 * 3 = 9 KALAN NEDİR 1. MOD ALMA OPERATÖRÜ
            // KALANI VERDİĞİ İÇİN ÇIKTIMIZ 1 OLDU ..

            Console.ReadLine();
        }
    }
}
