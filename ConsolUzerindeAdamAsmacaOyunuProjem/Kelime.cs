using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolUzerindeAdamAsmacaOyunuProjem
{
    public class Kelime
    {

        private string _kelime;
        private HashSet<char> _dogruTahminler;

        public Kelime(string kelime)
        {
            _kelime = kelime.ToLower();
            _dogruTahminler = new HashSet<char>();
        }

        public bool Tahmin(char harf)
        {
            harf = char.ToLower(harf);
            if (_kelime.Contains(harf))
            {
                _dogruTahminler.Add(harf);
                return true;
            }
            return false;
        }

        public string GorunurDurum()
        {
            string sonuc = "";
            foreach (char harf in _kelime)
            {
                if (_dogruTahminler.Contains(harf))
                {
                    sonuc += harf + " ";
                }
                else
                {
                    sonuc += "_ ";
                }
            }
            return sonuc.Trim();
        }

        public bool KazandimMi()
        {
            foreach (char harf in _kelime)
            {
                if (!_dogruTahminler.Contains(harf))
                {
                    return false;
                }
            }
            return true;

        }
    }
}
