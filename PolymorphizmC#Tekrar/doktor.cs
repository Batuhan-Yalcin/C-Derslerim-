using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmC_Tekrar
{
    public class doktor : calisan
    {
        private string isim;
        private string soyisim;
        private int yas;


        public string getisim()
        {
            return isim;
        }

        public void setisim(string isim)
        {
            this.isim = isim;
        }

        public string getsoyisim()
        {
            return soyisim;
        }

        public void setsoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }

        public int getyas()
        {
            return yas;
        }

        public void setyas(int yas)
        {
            this.yas = yas;
        }
        public override void calisanbilgileri()
        {
            Console.WriteLine("İsim : " + getisim() + " " + "Soyisim : " + getsoyisim() + " " + "Yaş : " + getyas());
        }
        public override void calisandurumu()
        {
            Console.WriteLine("Doktor Muayene Ediyor..");
        }

        public override void calisanulke()
        {
            base.calisanulke();
        }

    }
}
