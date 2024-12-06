using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STATİC TANIMI : Eğer Bizim Bir Metodumuzda , değişkenimizde static tanımlandı ise Biz O Classtan bir obje oluşturmak zorunda değiliz 
            // Direkt Class İsmini yazıp metodu çağırabiliriz Aşşağıdaki örnekteki gibi Musteri M1 = New Musteri(); gibi Obje ile çağırmak zorunda değiliz..
            // Şimdi Statiği şu şekil bir örnek ile anlatalım.. 

            //********************************************************************
            // STATİC KULLANILMAYAN Main Metodu İçi : 
            // {
            // Musteri M1 = new Musteri ();
            // M1.selamver();
            // }

            //  STATİC KULLANILMAYAN ! Musteri Class'ı İçi : 
            // public class Musteri {
            // public void selamver()
            // {
            //   girilecek kod..
            // }

            // ********************************************************************


            // STATİC KULLANILAN Main Metodu İçi : 
            // {
            // Musteri.selamver();
            // }

            // STATİC KULLANILAN Musteri Class'ı içi : 
            // Public Class musteri{
            //public static void SelamVer()
            //{
            // Girilecek kod..
            // }
            // ********************************************************************

        }
    }
}
