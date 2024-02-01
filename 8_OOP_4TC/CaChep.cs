using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOP_4TC
{
    internal class CaChep : Ca
    {
        // Khi 1 lớp kế thừa từ 1 lớp abstract nó bắt buộc phải override tất cả các
        // phương thức abstract mà lớp cha có
        public override void Boi()
        {
            Console.WriteLine("Cá chép bơi chìm");
        }
    }
}
