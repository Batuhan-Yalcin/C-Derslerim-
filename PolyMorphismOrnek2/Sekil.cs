using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismOrnek2
{
    public class Sekil
    {

        public string isim { get; set; }

        public Sekil(string isim)
        {
            this.isim = isim;
        }

        public string GetIsim()
        {
            return isim;
        }

        /*
        public void SetIsim(string isim)
        {
            this.isim = isim;
        } */

        public virtual void sekilHesapla()
        {
            Console.WriteLine("Şeklin Alanı Hesaplanıyor...");
        }


        public virtual void sekilBilgileriGoster()
        {
            Console.WriteLine(GetIsim() + "nin Bilgileri..");
        }


    }
}
