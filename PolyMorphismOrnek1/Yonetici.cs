using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismOrnek1
{
    public class Yonetici : Fabrika
    {

        public Yonetici(string unvan) : base (unvan)
        {
           
        }

        public override void unvanYazdır()
        {
            Console.WriteLine(getUnvan () + "Ben Bir Yöneticiyim.");
        }

    }
}
