using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismOrnek4
{
    public class Ogrenci : Personel
    {

        public override void calis()
        {
            Console.WriteLine("Öğrenci Şuanda Derse Çalışıyor..");
        }

    }
}
