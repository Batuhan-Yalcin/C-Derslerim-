using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BireBirDers
{
    public class Program
    {
        static void Main(string[] args)
        {

            double[] dizi1 = { 1.50,2.30};
            int[] dizi2 = { 1, 2, 3, 4, 5 };

            foreach (int i in dizi1)
            {
                Console.WriteLine("Dizi 1 değerleri : " + i);
            }

            foreach (int i in dizi2)
            {
                Console.WriteLine("Dizi 2 değerleri : " + i);
            }

            Console.ReadKey();
            // Continue Break 
            /*
           for (int a = 1; a <= 10; a++)
           {
               if (a == 8)
               {
                   break; // döngüyü tamamen kır        
               }
               Console.WriteLine("A'nın Değeri : " + a);
           }
           Console.ReadLine();


            for (int b = 1; b <= 10; b++)
           {
               if (b == 8)
               {
                   continue; // döngüyü bi kere kırar 
               }
               Console.WriteLine("B'nin Değeri : " + b);
           }




       for(int i = 1; i <=15; i++) 
            {
                for(int j = 1; j <=15; j++)
                {
                    Console.WriteLine(i + " X " + j + " = " + (i*j));
                }
            }


            // String veri tipinde İller isminde bir dizi oluştur. bu diziye ankara istanbul bursa izmir ekle
            // Foreach döngüsü ile bu diziyi yazdır.

            string[] iller = {"Ankara","İstanbul","Bursa","İzmir" };
            foreach( string il in iller)
            {
                Console.WriteLine(iller);
            }
          */

            /*



            Program program = new Program();
            program.MerhabaYaz();
            program.KareHesapla(5);
            program.HosgeldinYazdir("Batuhan");
            Console.WriteLine(program.Topla(5, 10));
            Console.WriteLine(program.CiftMi(12));








            Console.ReadLine();

            */





            // Program program = new Program();
            //program.Ekraniyazdir();
            //program.İsimYazdir("Metehan", "AYAN");
            //Console.WriteLine(program.Topla(2, 5));
            //Console.WriteLine(program.CiftMi(4));
            //Console.WriteLine(program.İsimYazdir2("Metehan", "AYAN"));
            Console.WriteLine(Program.Hesapla(1)); //1.Ödev
            Console.WriteLine(Program.ilYazdir("Bolu", "Sivas", "istanbul")); //2.ödev
            Console.WriteLine(Program.Yazdir("Metehan AYAN ", "İstanbul")); // 3.ödev



            //program.Topla(1, 2, 3, 4);
            //program.Topla(1, 2, 3);

            //program.Topla(10.5, 10.10);
            //program.Topla(10.5, 10.20, 30.10);
        }


        /*
        public void Ekraniyazdir()
        {
            Console.WriteLine("Metehan");
        }



        public void İsimYazdir(string isim, string soyisim) // Değer döndürmeyen metot
        {
            Console.WriteLine("isminiz : " + isim + " " + soyisim);

        }

        public string İsimYazdir2(string isim, string soyisim)
        {
            return isim + " " + soyisim;
        }



        public int Topla(int sayi1, int sayi2) // Parametreli geriye değer döndüren methotlar.
        {

            return sayi1 + sayi2;   // return ile geriye hangi değerler döneceğini belirtiriz. yani parametreleri..
        }


        public bool CiftMi(int sayi) // Parametreli geriye değer döndüren methot.
        {
            return sayi % 2 == 0;
        }


        public int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
        public int Topla(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            return sayi1 + sayi2 + sayi3 + sayi4;
        }

        public double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }

        public double Topla(double sayi1, double sayi2, double sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        public string İsimYazdir3(string isim1, string isim2)
        {
            return isim1 + isim2;
        }

        public string İsimYazdir3(string isim1, string isim2, string isim3)
        {
            return isim1 + isim2 + isim3;
        }
        */







        /*

        public void MerhabaYaz()   // Parametresiz Geriye Değer Döndürmeyen Methot.
        {
            Console.WriteLine("Merhaba");
        }


        void KareHesapla(int sayi) // Parametreli Geriye Değer Döndürmeyen Methot.
        {
            Console.WriteLine("Kare : " + sayi * sayi);
        }

        void HosgeldinYazdir(string isim) // Parametreli Geriye Değer Döndürmeyen methot.
        {
            Console.WriteLine("Hoşgeldin " + isim);
        }


        int Topla(int sayi1 , int sayi2) // Parametreli geriye değer döndüren methotlar.
        {
            return sayi1 + sayi2;
        }

        bool CiftMi(int sayi) // Parametreli geriye değer döndüren methot.
        {
            return sayi % 2 == 0;
        }



        public int Topla(int sayi1,int sayi2, int sayi3) // Overloading Aşırı Yüklenme
        {
            int toplam = sayi1 + sayi2+ sayi3;
            return toplam;
        }

        public double Topla (double sayi1, double sayi2, double sayi3) // Overloading.
        {
            double toplam = sayi1 + sayi2 + sayi3;
            return toplam;
        }
        */


        public static int Hesapla(int sayi1)  //1.Ödev
        {
            int Hesapla = sayi1 + 10;
            return Hesapla;
        }

        public static string ilYazdir(string il1, string il2, string il3) //2. ödev
        {
            return "3 il : " + il1 + " " + il2 + " " + il3;

        }

        public static void Yazdir() // 3.ödev
        {
            Console.WriteLine("Adı Batuhan");
            Console.WriteLine("İstanbulda yaşıyor.");

        }

    }
}

