using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonKullanimi
{
    public class Musteri
    {
        
        public int MusteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }

        public Musteri(int id,string isim,string soyisim,string email)
        {
            this.MusteriID = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.email = email;
        }

        // Generic koleksiyonu ekrana yazabilmek için parametre olarak gelen değerlerimi to string metodu ile eziyorum.
        public override string ToString()
        {
            return "İd : " + this.MusteriID + " " + "İsim : " + this.isim + " " + " Soyisim : " + this.soyisim + " " + this.email;
        }

    }
}
