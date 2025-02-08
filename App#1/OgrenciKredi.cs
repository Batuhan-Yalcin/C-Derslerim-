using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_1
{
    public class OgrenciKredi : KrediManager
    {
        public string isim = "Ahmet";

        private int ogrenciFaizi;

        public int getogrenciFaizi()
        {
            return ogrenciFaizi;
        }

        public void setogrenciFaizi(int ogrenciFaizi)
        {
            this.ogrenciFaizi = ogrenciFaizi;
        }



    }
}
