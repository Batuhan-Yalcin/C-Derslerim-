using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismOrnek2
{
    public class Dikdortgen : Sekil
    {
        public int kisaKenar { get; set; }
        public int uzunKenar { get; set; }
        public Dikdortgen(string isim,int kisaKenar,int uzunKenar) : base(isim)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(GetIsim() + "nin alanı : " + (kisaKenar * uzunKenar));
        }

        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("Şeklin İsmi : " + GetIsim());
            Console.WriteLine(GetIsim() + "nin kısa Kenarı : " +this.kisaKenar);
            Console.WriteLine(GetIsim() + "nin kısa Kenarı : " + this.uzunKenar);
        }
    }
}
