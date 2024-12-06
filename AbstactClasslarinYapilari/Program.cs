
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactClasslarinYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Abstract Classlar tamamen kalıtım amaçla geliştirilmiştir.
            // İçerisinde tanımllanmış metot imzalarını miras alan class'lara override etmek zorundadır.

            // Abstract Class - Normal Class arasında ki fark nedir ? 

            // 1 - Normal classlarda metot imzası tanımı yapmaz iken abstract classlarda metot imzası yapılır.
            // 2 - Normal classlarda new anahtar kelimesi ile nesneler oluşturulurken abstract classlarda  yapamayız.
            // Metodun imzası demek = (); bu şekilde tanımlamaya denir. örnek = public abstract void metot2(); 

            // Abstract classlar - interface arasında ki fark nedir ?

            // Bir Sınıfa Abstract class'lardan sadece birini miras alabilirken , o class birden çok interface'i implemente edebilir.
            // Yani İnterface de 1 interface 1 den fazla class a miras verebiliyordu fakat abstract class veremez sadece 1 class a miras verebilir.
            // public class AltSinif : TemelSinif,AltSinif2 yani bu şekilde TemelSinif abstract class altsinif2 de abstract class fakat normal class 2sini birden miras alamadı..


            AltSinif altSinif = new AltSinif();

            altSinif.metot2();
            altSinif.metot1();

            Console.ReadLine();


        }
    }
}
