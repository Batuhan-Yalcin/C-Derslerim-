using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeGetAndSETMethodlari
{
    public class Ogrenci
    {

        private string isim; // İsim adında private değişken oluşturduk.
        private long tc; // tc adında private bir değişken oluşturduk.

        public void setIsim (string _isim) // setIsim Metodu İle Değer Atama Yaptık.

        {
             isim = _isim; // Parametre olarak gelen _isim değişkenini yukarıdaki isim değişkenimize gönderdik.
            
        }

        public string getIsim() // get metodu ile Değer aldık.
        {
            return isim;    // isim değerini döndür dedik return ile..
        }

        public void SetTc(long _tc)
        {
            tc = _tc;
        }

        public long getTc()
        {
            return tc;
            
        }

    }
}
