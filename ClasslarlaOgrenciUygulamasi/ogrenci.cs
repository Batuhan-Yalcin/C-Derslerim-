using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslarlaOgrenciUygulamasi
{
    public class ogrenci
    {
        private int ogrenciNo;
        private string ogrenciİsim;
        private string ogrenciSoyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulİsmi;


        public ogrenci(int _ogrenciNo, string _ogrenciİsim, string _ogrenciSoyisim, int _vize1,int _vize2,int _final, string _okulİsmi)
        {
            ogrenciNo = _ogrenciNo;
            ogrenciİsim = _ogrenciİsim;
            ogrenciSoyisim = _ogrenciSoyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulİsmi = _okulİsmi;
        }

       public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrencinin İsmi : " +ogrenciİsim);
            Console.WriteLine("Öğrencinin Soyismi : " +ogrenciSoyisim);
            Console.WriteLine("Öğrencinin Numarası : " +ogrenciNo);
            Console.WriteLine("Öğrencinin Vize1 Notu : " +vize1);
            Console.WriteLine("Öğrencinin Vize2 Notu : " + vize2);
            Console.WriteLine("Öğrencinin Final Notu : " + final);
            Console.WriteLine("Öğrencinin Okuduğu Okul : " + okulİsmi);
        }

        public double ogrenciOrtalamasiBul()
        {
         double ortalama =   vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;    
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin Okuduğu Okul : " +okulİsmi);
        } 


    }
}
