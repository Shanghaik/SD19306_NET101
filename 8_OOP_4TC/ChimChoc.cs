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
        string chungloai = "Chim bay";
        string noio = "Trong tổ";
        int soluong = 1000;
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
            Console.WriteLine($"Loài {chungloai}, Nơi ở {noio}, Số lượng {soluong}");
        }
        public virtual void VoCanh() // từ khóa virtual cho phép 1 phương thức có thể được ghi đè
        {
            Console.WriteLine("Vỗ pạch pạch");
        }
    }
}
