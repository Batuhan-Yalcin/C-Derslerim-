using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceNedirOOP
{
    public class Musteri : InterFaceMusteri,IPersonel
    {
        public void ekle()
        {
            Console.WriteLine("Müşteri Eklendi.");
        }

        public void getir()
        {
            Console.WriteLine("Müşteri Getirildi.");
        }

        public void guncelle()
        {
            Console.WriteLine("Müşteri Güncellendi..");
        }

        public void sil()
        {
            Console.WriteLine("Müşteri Silindi.");
        }
    }
}
