using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceİleUygulamaOrnegi
{
    public class Yazilimci : Calisan
    {
        private string diller;

 public Yazilimci(int id, string isim, string soyisim, string diller) : base(id, isim, soyisim) // base benim miras aldığım sınıfımın yapıcı metodunu temsil eder yani calisan sınıfının.
        {
            this.diller = diller;
        }
        public void FormatAt(string isletim_Sistemi)
        {
            Console.WriteLine(getIsim() + " Şuanda " + " " +isletim_Sistemi + " işletim sistemine Format atıyor...");
        }

    }
}
