using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenInterFaceKullaniriz
{
    public class Sqlserver : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("SQL Server Eklendi");
        }

        public void sil ()
        {
            Console.WriteLine("Sql Server Silindi.");
        }

        public void guncelle()
        {
            Console.WriteLine("Sql Server Güncellendi.");
        }

    }
}
