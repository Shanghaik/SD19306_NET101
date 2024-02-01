using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOP_4TC
{
    internal class ChimSe : ChimChoc
    {
        // Tạo phương thức ghi đè
        // Cách 1: Tự mà viết
        // Cách 2: Click vào tên class => Ctrl . => Generate overrides => Chọn cái cần và OK
        public override void VoCanh()
        {
            Console.WriteLine("Chim sẻ vỗ cành liên toành toạch");
        } // Dutch lady
    }
}
