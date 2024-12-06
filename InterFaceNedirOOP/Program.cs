using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceNedirOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
           InterFaceler'den bir tane örnek oluşturamazsınız.. = yani InterfaceMusteri musteri = new InterFaceMusteri(); bunu yapamayız..

           Interface'i implement'e eden classdan aldığımız örneği interface karşılayabilir. = Yani Musteri musteri = new Musteri(); de yazabiliriz yada 
           InterfaceMusteri musteri = new Musteri(); de yazabiliriz..

           Interface içerisinde Metotları Tanımlarız. Classlarda da içeriğini doldururuz. !!!

           Interface içerisinde ki metotların ERİŞİM BELİRLEYİCİLERİ ve İÇERİĞİ olamaz.. !!!

           Interface'leri miras alan sınıflar, içerisinde tanımlanan tüm metodları Implemente etmek ZORUNDADIR. !!!

           Bir Class Sadece Bir Class'tan türetebilirken, bir class birden çok INTERFACE'ten TÜRETİLEBİLİR. !!!
           Yani şöyle düşünelim musteri classımız InterfaceMusteri classını miras aldı ya bi tane daha comploment açıp onada Ipersonel dedik Ve musteri clasımız
           hem InterfaceMusteri İnterface'ini hemde IPersonel interfaceini aynı anda miras alabilir..
           public class Musteri : InterFaceMusteri,IPersonel bu şekilde.. 
             
            */


            InterFaceMusteri musteri = new Musteri();

            musteri.ekle();
            musteri.getir();
            musteri.guncelle();
            musteri.sil();

            Console.ReadLine();

        }
    }
}
