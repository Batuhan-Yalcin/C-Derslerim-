using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonlarGiris
{
     class Program
    {
        static void Main(string[] args)
        {
            /* Arraylist int değeri de alıyor string değeri de double değeri de yani bir obje bu herşeyi alabiliyor fakat GenericKoleksiyonlar
             * sadece 1 veri tipi ile çalışır.. 
             
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add(1);
            koleksiyon.Add("Batuhan");
            koleksiyon.Add(3.10);
            */

            degerEkle(5);


        }

        static void degerEkle(int deger) // Bu ise Her tipi kabul etmeyen arraylist kullanımıdır. Birdahaki dersimizde generic koleksiyonları göreceğiz..
        {
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add(deger);
        }

    }
}
