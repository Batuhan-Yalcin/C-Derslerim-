using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenInterFaceKullaniriz
{
    public class MySql : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("MySql Ekledi");
        }

        public void guncelle()
        {
            Console.WriteLine("MySql Guncelledi");
        }

        public void sil()
        {
            Console.WriteLine("MySql Sildi");
        }
    }
}
