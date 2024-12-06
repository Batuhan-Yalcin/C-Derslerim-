using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslarNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // public class Musteri <T> Musteri classımızda Generic class bu şekil belirtilir sonuna geliriz < içine bir harf veririz.>
            // Main metodumuzda aşağıda ki gibi bir nesne oluşturduğumuzda musteri classında oluşturduğumuz tüm değişkenleri string olarak algılayacaktır
            // sebebi ise nesne nin içine belirtmiş olduğumuz stringdir. yani musteri classında ki public T id { get; set; } id yi mesela
            // string veri tipinde dönderecektir..


            Musteri<string> musteri = new Musteri<string>();

        }
    }
}
