using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSealedAnahtarKelimesininOnemi
{
    public sealed class Personel // sealed ile Hiç kimse Miras alamasın dedik..
    {

        public int personel_id { get; set; }
        public int personel_ismi { get; set; }
        public int personel_soyisim { get; set; }
        public int personel_maas { get; set; }

        public void PersonelBilgileriGoster()
        {
            Console.WriteLine("Personel'in İd'si : " +personel_id);
            Console.WriteLine("Personel'in ismi : " + personel_ismi);
            Console.WriteLine("Personel'in Soyismi : " +personel_soyisim);
            Console.WriteLine("Personel'in maaşı : " + personel_maas);
        }
    }
}
