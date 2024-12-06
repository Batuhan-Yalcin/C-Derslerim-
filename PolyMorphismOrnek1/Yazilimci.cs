using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismOrnek1
{
    public class Yazilimci : Fabrika
    {

        public Yazilimci(string unvan) : base(unvan) 
        {
            
        }

        public override void unvanYazdır()
        {
            Console.WriteLine(getUnvan() + "Ben Bir Yazılımcıyım.");
        }

    }
}
