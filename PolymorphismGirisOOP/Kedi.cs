using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGirisOOP
{
    public class Kedi : Hayvan
    {

        public Kedi (string isim) : base (isim) // yapıcı metodun almış olduğu isim değerini üst class a parametre olarak göndermek demektir. base hayvan classını temsil ediyor
        {
              
        }

        public override void konus()
        {
            Console.WriteLine(getIsim() + "Miyavlıyor.");
        }

    }
}
