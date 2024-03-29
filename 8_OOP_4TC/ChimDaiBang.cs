﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _8_OOP_4TC
{
    internal class ChimDaiBang:ChimChoc
    {
        // Khi kế thừa, thì lớp con sẽ có
        // tất cả cả các thành phần của lớp cha
        string ten; // thêm thuộc tính ten
        public string Ten { get => ten; set => ten = value; }
        // ChimDaiBang có 4 thuộc tính bao gồm 3 tt
        // kế thừa và 1 thuộc tính riêng
        public ChimDaiBang()
        {
            this.ten = "Đại bàng mỏ tép";
        }
        public ChimDaiBang(string chungloai, string noio, int soluong) : base(chungloai, noio, soluong)
        {
        }
        // Tạo Constructor đầy đủ 4 tham số
        // Cách 1 tự mà gõ ra/copy
        // Cách 2: Bước 1. Ấn chuột tên Class
        // Bước 2: Ctrl . sau đó chọn Generate
        // constructor chứa các tham số của lớp cha
        // Bước 3: Bôi đen các thuộc tính mới của 
        // lớp con sau đó Ctrl . chọn add parameter
        // to Constructor => Chọn cái mình cần
        // Từ khóa base cho phép trỏ đến thành phần
        // từ lớp cha, base = class cha
        // Kế thừa phương thức
        public void XuatThongTin()
        {
            base.InThongTin(); // dùng từ khóa base để gọi phương thức của lớp cha
            // Kế thừa phương thức
            Console.WriteLine("Tên là " + ten);
        }
        // Tính đa hình là tính chất cho phép các hành động giống nhau được thể hiện khác
        // nhau ở những đối tượng khác nhau hoặc cùng 1 đối tượng nhưng trong các trạng
        // thái khác nhau
        public void Bay()
        {
            Console.WriteLine("Bay tà tà chờ thời cơ");
        }
        public void Bay(string trangthai)
        {
            if (trangthai == "săn mồi") Console.WriteLine("Bay nhanh");
            else if (trangthai == "thấy súng") Console.WriteLine("Bay mất tích");
            else Console.WriteLine("Lại bay tà tà");
        }
        // Cùng 1 hành động của 1 đối tượng (cùng tên method) nhưng trạng thái khác 
        // nhau (khác tham số truyền vào) thì thể hiện khác nhau
        // Khi đó người ta gọi là Overload - Nạp chồng
        public override void VoCanh()
        {
            Console.WriteLine("Chim đại bàng không vỗ cánh");
        }
    }
}
