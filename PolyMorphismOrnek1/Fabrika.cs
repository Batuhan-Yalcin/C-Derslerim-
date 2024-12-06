using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismOrnek1
{
    public class Fabrika
    {

        public string unvan;

        public Fabrika(string unvan)
        {
            this.unvan = unvan;
        }

        public string getUnvan()
        {
            return unvan;
        }

        public void setUnvan(string unvan)
        {
            this.unvan = unvan;
        }

        public virtual void unvanYazdır()
        {
            Console.WriteLine("Ben Bir fabrikayım.");
        }

    }
}
