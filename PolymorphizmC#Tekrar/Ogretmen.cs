using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class Ogretmen
    {
        
        private string isim;
        private string soyisim;
        private int yas;

        public Ogretmen()
        {
            Console.WriteLine("Ogretmen Classının Yapıcı Methodu Çalıştı.");
        }

        public Ogretmen(string isim,string soyisim,int yas)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.yas = yas;
        }

        public string getIsim()
        {
            return isim;
        }
        public void setIsim(string isim)
        {
            this.isim = isim;
        }
        public string getSoyİsim()
        {
            return soyisim;
        }
        public void setSoyİsim(string soyisim)
        {
            this.soyisim= soyisim;
        }

        public int getYas()
        {
            return yas;
        }
        public void setYas(int yas)
        {
            this.yas = yas;
        }

        public void ogretmenBilgileri()
        {
            Console.WriteLine("İsim : " + isim + " " + "Soyisim : " + soyisim + " " + "Yaş : " + yas);
        }

    }
}
