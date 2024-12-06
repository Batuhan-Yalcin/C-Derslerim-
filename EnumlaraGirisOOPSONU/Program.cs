using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumlaraGirisOOPSONU
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Enumerations(Numaralandırmalar) anlamına gelir.
            // Eğer ki 1 gelirse şunu yap, 2 ye bunu yap dediğimiz yerlerde ve bunun gibi işlemlerde oldukça faydalıdır.
            // Büyük projelerde önemi oldukça büyüktür. !!!!

            //  Enum içerisine değer vermezsek, değerler 0'dan başlar ve birer birer artar.

           Gunler gun = Gunler.pazartesi; // enum ile verdiğimiz değeri böyle yakalarız main metodunda.
            // Gunler gun = Gunler.pazartesi; diyerek biz gün pazartesi ise onu ekrana yazdır dedik yani bir numaralandırma yaptık .

            if (gun == Gunler.pazartesi)
            {
                Console.WriteLine("Gün Pazartesidir.");
            }
            else if (gun == Gunler.salı)
            {
                Console.WriteLine("Gün Salıdır.");
            }

            else if (gun == Gunler.çarşamba)
            {
                Console.WriteLine("Gün Çarşambadır.");
            }

            else if (gun == Gunler.perşembe)
            {
                Console.WriteLine("Gün Perşembedir.");
            }

            else if (gun == Gunler.cuma)
            {
                Console.WriteLine("Gün Cumadır.");
            }

            else if (gun == Gunler.cumartesi)
            {
                Console.WriteLine("Gün Cumartesidir.");
            }

            else if (gun == Gunler.pazar)
            {
                Console.WriteLine("Gün pazardır.");
            }

            else
            {
                Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz. ! ");
            }


            Console.ReadLine();

        }
    }
}
