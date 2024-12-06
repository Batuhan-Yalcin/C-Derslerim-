using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegilOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DEĞİL OPERATÖRÜ  = ! 
            // DEĞİL OPERATÖRÜ BİRŞEY DOĞRUYKEN YANLIŞ YAZDIRIR YADA YANLIŞ BİRŞEYİ DOĞRU YAZDIRIR
            // YANİ TAM ZITTINI VERİR SONUÇ OLARAK.


            bool a = !true; // burda a değişkenine true verdik fakat başına ! koyduğumuz için false oldu çıktı da.

            Console.WriteLine(a); // ÇIKTI SONUCU : FALSE

        }
    }
}
