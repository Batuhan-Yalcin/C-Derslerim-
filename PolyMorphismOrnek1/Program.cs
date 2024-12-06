using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Bir Yazılımcı Bir Yonetici Birde Fabrika Adında Bir Class Oluşturun.
            // Fabrika = Base Class (Super Class) Olacak.
            // Yani her 2 sine de miras verecek.
            // Fabrika Classına bir metod tanımlayın.
            // Metodun ismi unvanYazdir olsun.
            // Kişi yazılımcı ise yazılımcı Yönetici ise yönetici yazdırsın.
            // Bu metod 1 classta tanımlanacak fakat 3 classta birden kullanılacaktır override edilecek...


            Fabrika fabrika = new Fabrika("Fabrika : ");
            fabrika.unvanYazdır();

            Yazilimci yazilimci =  new Yazilimci("Yazılımcı : ");
            yazilimci.unvanYazdır();

            Yonetici yonetici = new Yonetici("Yönetici : ");
            yonetici.unvanYazdır();


            Console.ReadLine();

        }
    }
}
