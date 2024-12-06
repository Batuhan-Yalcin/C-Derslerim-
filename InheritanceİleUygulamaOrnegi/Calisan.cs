using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceİleUygulamaOrnegi
{
    public class Calisan
    {

        private int id;
        private string isim;
        private string soyisim;

        public Calisan(int id, string isim, string soyisim)
        {
            this .id = id;
            this .isim = isim;
            this .soyisim = soyisim;
        }

        public int getId()
        {
            return this.id;
        }
        public void setId(int ID)
            {
            this.id = ID;
            }

        public string getIsim()
        {
            return this.isim;
        }

        public void SetIsim(string isim)
        {
            this.isim = isim;
        }

        public string getSoyisim()
        {
            return this.soyisim;
        }

        public void SetSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }


        public void BilgileriGoster()
        {
            Console.WriteLine("İd : " + this.id);
            Console.WriteLine("İsim : " +this.isim);
            Console.WriteLine("Soyisim : " +this.soyisim);
        }


    }
}
