using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOP_4TC
{
    internal abstract class Ca // Từ khóa abstract để dánh dấu 1 lớp là lớp trừu tượng
    {
        // Lớp trừu tượng là lớp có các thành phần trừu tượng (thường là method)
        // Nhưng không phải tất cả các thành phần đều là trừu tượng
        public void InThongTin()
        {
            Console.WriteLine("Thích thì tôi in");
        }
        public abstract void Boi(); // Phương thức abstract không có phần thân và
        // bắt buộc phải được override lại từ lớp con để được sử dụng
        // abstract class là trừu tượng không hoàn toàn 

    }
}
