using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace EnumKullanmaninFaydalari
{
    public  class Musteri
    {
        /* ENUM KULLANMADAN YAPILAN ÖRNEK : 
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string cinsiyet { get; set; }
        public string emailAdres { get; set; }



        public Musteri(int id, string isim,string soyisim,string cinsiyet,string emailAdres)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.cinsiyet = cinsiyet;
            this.emailAdres = emailAdres;
        }


        public static ArrayList musteriler = new ArrayList();

        public int musteriEkle(Musteri m1)
        {
            musteriler.Add(m1); // müşterimizi koleksiyona ekledik.
            return 413444; // değerin eklendiği anlamına gelecek
        }

        */

        // ENUM KULLANARAK YAPILAN ÖRNEK : 
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string cinsiyet { get; set; }
        public string emailAdres { get; set; }



        public Musteri(int id, string isim, string soyisim, string cinsiyet, string emailAdres)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.cinsiyet = cinsiyet;
            this.emailAdres = emailAdres;
        }


        public static ArrayList musteriler = new ArrayList();


        public  MusteriDurum MusteriEkle (Musteri m1)
        {
            musteriler.Add(m1);                     // müşterimizi koleksiyona ekledik.
            return MusteriDurum.kayitbasarili;      // değerin eklendiği anlamına gelecek
        }

    }
}
