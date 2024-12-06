using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte veri tipinde birinci adında değişken tanımladım ve 5 değerine atadım anlamına gelir.
            // BYTE VERİ TİPİNDE SADECE 0-255 ARASI DEĞER GİRİLEBİLİR 256 OLDUĞU AN HATA ALIRSINIZ..
            byte birinci = 5;
            byte ikinci = 25;
            byte minDeger =byte.MinValue;
            byte maxDeger =byte.MaxValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);    
           
            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.ReadLine();
            
        }
    }
}
