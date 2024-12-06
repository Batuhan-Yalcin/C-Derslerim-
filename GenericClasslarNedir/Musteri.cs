using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslarNedir
{
    public class Musteri <T>
    {

        public T id { get; set; }
        public string isim { get; set; }
        public T email { get; set; }


    }
}
