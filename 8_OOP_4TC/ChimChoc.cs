using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOP_4TC
{
    internal class ChimChoc
    {
        // thuộc tính
        string chungloai;
        string noio;
        int soluong;
        public string Chungloai { get => chungloai; set => chungloai = value; }
        public string Noio { get => noio; set => noio = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public ChimChoc()
        {
        }
        public ChimChoc(string chungloai, string noio, int soluong)
        {
            this.chungloai = chungloai;
            this.noio = noio;
            this.soluong = soluong;
        }

        public void InThongTin()
        {
            Console.WriteLine($"Loài {chungloai}");
        }
    }
}
