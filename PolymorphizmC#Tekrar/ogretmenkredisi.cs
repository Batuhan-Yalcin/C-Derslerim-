using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class ogretmenkredisi : banka
    {
        public override void kredihesaplama()
        {
            Console.WriteLine("Öğretmen Kredisi Hesaplandı : Tutar 3000");
        }

        public override void krediciktimi()
        {
            Console.WriteLine("Öğretmene Kredi Çıktı..");
        }


    }
}
