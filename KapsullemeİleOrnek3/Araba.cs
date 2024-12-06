using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeİleOrnek3
{
    public class Araba
    {

        private string Marka;
        private string Model;
        private int Hiz;

        public string ArabaMarkasi
        {
            get
            {
                return Marka;
            }

        }

        public string ArabaModeli
        {
            get
            {
                return Model;
            }
        }

        public int ArabaHizi
        {
            get
            {
                return Hiz;
            }
            set
            {
                if(value >=0)
                {
                    Hiz = value;
                }
                
            }
        }

        public Araba (string marka, string model)
        {
            Marka = marka;
            Model = model;
             Hiz = 0;
        }

        public void hizlan (int miktar)
        {
            if (miktar > 0)
            {
                Hiz += miktar;
            }
 
        }

        public void yavasla(int miktar)
        {
            if (miktar > 0)
            {
                Hiz -= miktar;
                if (Hiz < 0)
                {
                    Hiz = 0;
                }
            }
        }

    }
}
