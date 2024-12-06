using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeİleOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // YAPACAĞIMIZ ÖRNEK : Personelimizin  TC'sini alacağız ve şu kontroller yapacağız..
            // Set Şartları ;
            // 1 - TC KİMLİK NO'SU 11 HANELİ OLMALI 
            // 2 - Tüm karakterleri Sayısal Karakterler Olmalı..

            // Get Şartları ; 
            // TC Kimlik No'sunun ilk 5 karakteri alınacak Hepsi Değil.

            Personel p = new Personel();


            p.TC = "12345678956";

            Console.WriteLine("TC Kimlik Numaranız : " +p.TC);

            Console.ReadLine();
        }
    }
}
