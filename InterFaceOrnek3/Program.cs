using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceOrnek3
{
    internal class Program
    {
        static void Main(string[] args)
        {

        /*


        Bir Arac adında bir interface oluşturun ve bu interface'de Hizlan ve Yavasla adında iki metot tanımlayın.
        Ardından, Araba ve Motorsiklet adında iki sınıf oluşturun.
        Her iki sınıf da Arac interface'ini implement etsin ve bu metotları Araba ve Motorsiklet için uygun şekilde gerçekleştirsin- aynı anda işlem yapabilsin.

        Bu soruda Hizlan metodu, aracın hızlanmasını simüle etsin, Yavasla metodu ise aracın yavaşlamasını simüle etsin.
        */


        AracController controller = new AracController();

            controller.Aracİslemleri(new Araba());
            controller.Aracİslemleri(new Motorsiklet());

            Console.ReadLine();

        }
    }
}
