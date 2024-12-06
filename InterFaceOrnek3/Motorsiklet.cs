using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceOrnek3
{
    public class Motorsiklet : IArac
    {
        public void Hizlan()
        {
            Console.WriteLine("MOTORSİKLET HIZLANIYOR..");
        }

        public void yavasla()
        {
            Console.WriteLine("MOTORSİKLET YAVAŞLIYOR..");
        }
    }
}
