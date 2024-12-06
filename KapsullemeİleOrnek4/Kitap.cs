using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeİleOrnek4
{
    public class Kitap
    {

        private string kitapAdi;
        private string Yazar;
        private int SayfaSayisi;
        private bool okunmaDurumu;

        public void KitapBilgileriniGoster()
        {
            Console.WriteLine("Kitabın adı : " + kitapAdi);
            Console.WriteLine("Kitabın Yazarı : " + Yazar);
            Console.WriteLine("Kitabın Sayfa Sayısı : " + SayfaSayisi);
            Console.WriteLine("Kitabın Okunma Durumu : " + okunmaDurumu);
        }

        public void OkunmaDurumuDegistir()
        {
            if (okunmaDurumu)
            {
                okunmaDurumu = false;
            }

            else
            {
                okunmaDurumu = true;
            }
        }

        public string KİTAPADİ
        {
            get
            {
                return kitapAdi;
            }

            set
            {
                kitapAdi = value;
            }

        }



        public string YAZAR
        {
            get
            {
                return Yazar;
            }
            set
            {
                Yazar = value;
            }
        }

        public int SAYFASAYİSİ
        {
            get
            {
                return SayfaSayisi;
            }
            set
            {
                SayfaSayisi = value;
            }
        }

        public bool OKUNMADURUMU
        {
            get
            {
                return okunmaDurumu;
            }
            set
            {
                okunmaDurumu = value;
            }
        }


    }
}
