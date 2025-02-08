using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class ogrencikredisi : banka
    {
        public override void kredihesaplama()
        {
            Console.WriteLine("Öğrenci Kredisi Hesaplandı : Tutar 1000");
        }

        public override void krediciktimi()
        {
            Console.WriteLine("Öğrenciye Kredi Çıkmadı..");
        }

    }
}
