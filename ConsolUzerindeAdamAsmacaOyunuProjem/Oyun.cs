using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolUzerindeAdamAsmacaOyunuProjem
{
    public class Oyun
    {

        private List<string> _kelimeListesi;
        private Kelime _aktifKelime;
        private int _kalanHak;
        private List<char> _yanlisTahminler;

        public Oyun()
        {
            // Kelime listesini başlat
            _kelimeListesi = new List<string> { "bilgisayar", "programlama", "yazilim", "klavye", "ekran" };
            _yanlisTahminler = new List<char>();
        }

        public void Baslat()
        {
            do
            {
                // Rastgele bir kelime seç
                Random rnd = new Random();
                string secilenKelime = _kelimeListesi[rnd.Next(_kelimeListesi.Count)];
                _aktifKelime = new Kelime(secilenKelime);

                // Hakları sıfırla
                _kalanHak = 6;
                _yanlisTahminler.Clear();

                // Oyun döngüsü
                while (_kalanHak > 0 && !_aktifKelime.KazandimMi())
                {
                    // Durumu göster
                    Console.Clear();
                    Console.WriteLine("Adam Asmaca");
                    Console.WriteLine("Kelime: " + _aktifKelime.GorunurDurum());
                    Console.WriteLine("Yanlış Tahminler: " + string.Join(", ", _yanlisTahminler));
                    Console.WriteLine("Kalan Hak: " + _kalanHak);

                    // Kullanıcıdan tahmin al
                    Console.Write("Bir harf tahmin edin: ");
                    char tahmin = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    // Tahmini kontrol et
                    if (!_aktifKelime.Tahmin(tahmin))
                    {
                        if (!_yanlisTahminler.Contains(tahmin))
                        {
                            _yanlisTahminler.Add(tahmin);
                            _kalanHak--;
                        }
                        else
                        {
                            Console.WriteLine("Bu harfi zaten tahmin ettiniz!");
                        }
                    }
                }

                // Oyun sonucu
                Console.Clear();
                if (_aktifKelime.KazandimMi())
                {
                    Console.WriteLine("Tebrikler! Kelimeyi doğru tahmin ettiniz: " + secilenKelime);
                }
                else
                {
                    Console.WriteLine("Maalesef! Kaybettiniz. Kelime: " + secilenKelime);
                }

                // Kullanıcıya tekrar oynamak isteyip istemediğini sor
                Console.WriteLine("Tekrar oynamak ister misiniz? (E/H)"); // e = evet h = hayır e yazarsa oyun yeniden başlar h yazarsa oyun iptal 
            } while (Console.ReadLine()?.ToLower() == "e");

            Console.WriteLine("Oyun için teşekkürler! Görüşmek üzere!");

             /* Görsel Kodlama Başlangıcı Buradan Devam Edecek.. */

        }
    }
}