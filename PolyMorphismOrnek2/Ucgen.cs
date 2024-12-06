using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismOrnek2
{
    public class Ucgen : Sekil
    {

        public int tabanAlani { get; set; }
        public int yukseklik { get; set; }

        public Ucgen(string isim, int tabanAlani,int yukseklik) : base(isim)
        {
            this.tabanAlani = tabanAlani;
            this.yukseklik = yukseklik; 
        }


        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(GetIsim() + "nin alanı : " + (tabanAlani * yukseklik) / 2);
        }

        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("Şeklin ismi : " + GetIsim());
            Console.WriteLine(GetIsim() + "nin taban alanı : " + this.tabanAlani);
            Console.WriteLine(GetIsim() + "nin yüksekliği : " + this.yukseklik);

        }

    }
}
