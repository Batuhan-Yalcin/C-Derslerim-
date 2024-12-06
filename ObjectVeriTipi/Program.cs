using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OBJECT VERİ TİPİ İSE TÜM VERİ TİPLERİNİN YAPTIĞI İŞLEVİ YAPABİLEN VERİ TİPİDİR.
            // VERİ TİPLERİNİN ATASI OLARAK DA BİLİNİR.
            // HEM DOUBLE HEM STRİNG HEM İNT HEM CHAR HEM FLOAT KISACASI TÜM VERİ TİPLERİNİ DÖNDÜREBİLİR.
            // GELİN BİRLİKTE ÖRNEĞİMİZİ İNCELEYELİM..

            object a = 1;
            object b = "Batu";
            object c = 10.2;
            object d = 'b';
            object e = true;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.ReadLine();
            // GÖRDÜĞÜNÜZ GİBİ HER VERİ TİPİNİ DÖNDÜRME YETKİSİ VARDIR..
        }
    }
}
