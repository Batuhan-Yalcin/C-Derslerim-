using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenInterFaceKullaniriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface'imizi implement'e eden classlarımızdan oluşturduğumuz örneği INTERFACE Karşılayabilir.

            // SQL Server MySQL 

            // Şimdi burada yaptığımız işlem aslında şudur. 
            // Interface'in yararı : Biz sqlserver classımıza da mysql classımıza da ekle adında metot yazdık.
            // şimdi bu ekle metodunu her ikisindede çalıştırabilmek için Interface kullandık peki nasıl iki aynı metot ismi farklı şekilde çalıştı..

            /*public void musteriEkle(IMusteri veritabani)
            {
                veritabani.ekle();
            }
            Yukarıda biz şu işlemi yaptık MusteriController classımıza gittik musteriEkle isminde bir metot yazdık parantezine de Imusteri interfaceinde bir veritabanı isminde
            parametre oluşturduk. ve bu parametre olan veritabanı'nda ekle metodunu kullandık.
            ve bu ekle metodunu çağırabilmek için main metodumuza gelip 
            önce bir MusteriController sınıfının nesnesini oluşturduk.
            sonrasında ise controller.musteriekle diyip parantez açıp new yani yeni sqlserver classımızı çağırdık
            sonrasında aynısını mysql classımız içinde yaptık ve yazdırma işlemine geçtiğimiz zaman 2 sini birden ekrana yazdırdık.. 

      !!!!!!!!!!      yani interfaceimiz olan Imusteri'yi miras alan sqlserver ve mysql classlarımızdan Oluşturduğumuz metotları ınterface bize karşıladı.. !!!!!!!!!!!!!!!!
            */ 


            MusteriController controller = new MusteriController();

           controller.musteriEkle(new Sqlserver());
           controller.musteriEkle(new MySql());
           

        }
    }
}
