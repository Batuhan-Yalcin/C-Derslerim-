using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslarGercekHayattaKullanimi
{
    public class Repository <T>
    {

        public List<T> Getir()
        {
            // Metodumuzu bu amaç ile kullanacağımızı düşünelim. Veritabanında ilgili tabloya git ve oradan kayıtları getir.

            return null;
        }


        public string ekle(T data)
        {
            // Ekle metodunun kullanım amacı :  Veri tabanına git ilgili tabloya T Tipinde ki datayı ekle..

            return "Data başarılı bir şekilde eklenmiştir.";

        }

    }
}
