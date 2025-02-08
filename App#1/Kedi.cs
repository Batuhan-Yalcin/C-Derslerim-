using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_1
{
    public class Kedi : hayvan
    {
        private string kediİsmi;
        private string kediCinsi;
        private int kediYasi;



        public string getkediİsmi()
        {
            return kediİsmi;
        }

        public string getkediCinsi()
        {
            return kediCinsi;
        }

        public int getkediYasi()
        {
            return kediYasi;
        }


        public void setkediİsmi(string kediİsmi)
        {
            this.kediİsmi = kediİsmi;
        }

        public void setkediCinsi(string kediCinsi)
        {
            this.kediCinsi = kediCinsi;
        }
        
        public void setKediYasi(int kediYasi)
        {
            this.kediYasi = kediYasi;
        }

        

        

    }
}
