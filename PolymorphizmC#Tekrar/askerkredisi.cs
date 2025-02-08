using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class askerkredisi : banka
    {
        public override void kredihesaplama()
        {
            Console.WriteLine("Asker Kredisi Hesaplandı : tutar 2000");
        }

        public override void krediciktimi()
        {
            Console.WriteLine("Askere Kredi Çıktı..");
        }

    }
}
