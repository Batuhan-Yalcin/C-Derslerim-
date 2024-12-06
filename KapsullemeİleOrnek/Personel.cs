using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeİleOrnek
{
    public  class Personel
    {

        private string tc;

        public string TC 
        {
            get
            {
                return tc.Substring(0, 5) + "******";     // Substring metodu elimizde var olan değerin şu karakterinden şu karakterine kadar almak istiyorum demeye yarıyor
                // yani 1 den 5 e kadar almak istiyoruz burada.
            }

            set
            {
                bool kontrol = false;

                if (value.Length == 11) // kullanıcının gönderdiği değerin uzunluğu 11 e eşit mi 
                {

                    for (int i = 0; i < value.Length; i++) // 0 dan başlayıp kullanıcının girdiği değere kadar dönecek
                    {
                   bool sayiMi =  char.IsNumber(value[i]); // buraya eğer ki karakter girilirse yani sayı olmadıgını anlarsa 123456AB Böyle birşey girilirse Else bloğuna gidip
                        if (sayiMi)
                        {
                            // Yapmam Gereken Birşey Yok eğer True İse
                        }
                        else
                        {
                            kontrol = true; // Kontrol ü true ya çekip döngü kırdık break ile 
                            break;
                        }

                    }

                    if (kontrol)
                    {
                        Console.WriteLine("TC Kimlik Numaranızda Geçersiz Karakter Bulundu.");
                    }
                    else
                    {
                         tc = value;
                    }

                    
                }

                else
                {
                    Console.WriteLine("Girdiğiniz TC Kimlik No 11 Karakter Değildir.");
                }

            }

        }



    }
}
