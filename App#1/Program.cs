using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Köpek kopek = new Köpek();
            Kedi kedi = new Kedi();

            kopek.setkopekYasi(5);
            kopek.setkopekİsmi("Karabaş");
            kopek.setkopekCinsi("shitzhu");

            kopek.hayvanBilgileri(kopek.getkopekİsmi(), kopek.getkopekCinsi(), kopek.getkopekYasi());

            Console.WriteLine(kopek.getkopekİsmi());
            Console.WriteLine(kopek.getkopekCinsi());
            Console.WriteLine(kopek.getkopekYasi());
            kopek.KopekSesi();
            kopek.Uyuyor(kopek.getkopekİsmi());

            Console.WriteLine("-------------------------");
            kedi.setkediİsmi("Minnoş");
            kedi.setkediCinsi("British");
            kedi.setKediYasi(2);



            kedi.Uyuyor(kedi.getkediİsmi());
            kedi.hayvanBilgileri(kedi.getkediİsmi(), kedi.getkediCinsi(), kedi.getkediYasi());


            */







            AskerKredi asker = new AskerKredi();
            TarimKredi tarim = new TarimKredi();
            OgrenciKredi ogrenci = new OgrenciKredi();



            asker.setaskerFaizi(2);
          

            tarim.settarimFaizi(3);

            ogrenci.setogrenciFaizi(4);

            asker.krediHesapla(asker.isim, asker.getaskerFaizi());
            Console.WriteLine("-------------------------------------");

            ogrenci.krediHesapla(ogrenci.isim, ogrenci.getogrenciFaizi());














        }
    }
}

