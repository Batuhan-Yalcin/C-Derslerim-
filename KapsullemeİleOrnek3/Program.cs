using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeİleOrnek3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Bu Örneğimizde Bir Araba Sınıfı Oluşturacağız..
            // Marka (string) ve Model (string) özelliklerine sahip olacak ve bu özellikler sadece okunabilir Olacak Sadece Get edecek yani Set etmeyecek..
            // Hiz (int) özelliğine sahip olacak, bu özellik hem okunabilir hem de yazılabilir, ancak hız hiçbir zaman negatif olamayacak.
            // Bir Hizlan(int miktar) metodu ekleyeceğiz, bu metot hızı belirli bir miktar artıracak.
            // Bir Yavasla(int miktar) metodu ekleyeceğiz, bu metot hızı belirli bir miktar azaltmalı, ancak hız 0’ın altına inmemeli.

            Araba araba = new Araba("BMW" , "M5");

            Console.WriteLine("Marka: " + araba.ArabaMarkasi);
            Console.WriteLine("Model: " + araba.ArabaModeli);

            araba.hizlan(20);
            Console.WriteLine("Araç Hızlandıktan Sonraki Hız : " +araba.ArabaHizi);

            araba.yavasla(10);
            Console.WriteLine("Araba Yavaşladıktan Sonraki Hız : " +araba.ArabaHizi);

            araba.yavasla(15);
            Console.WriteLine("Hız Sıfıra Düşerse : " +araba.ArabaHizi);


        }
    }
}
