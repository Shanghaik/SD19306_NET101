namespace _7_OOP
{
    internal class Program
    {
        /*
         * OOP là gì? Object Oriented Programing - Lập trình hướng đối tượng
         * Là phương pháp lập trình sử dụng các đối tượng làm trung tâm
         * Mỗi đối tượng sẽ có các thần phần cụ thể là:
         * - Thuộc tính: Các giá trị thể hiện các tính chất của đối tượng
         * - Constructor: Hàm tạo (sử dụng để khởi tạo đối tượng với các thuộc tính)
         * - Method (Phương thức) thể hiện các hành vi của đối tượng
         * Class (lớp) là khuôn mẫu cho các đối tượng, đối tượng (object) được
         * gọi là các instance (thể hiện) của các class
         * Một Class thường được tạo trong 1 file vật lý. Tuy nhiên cần phân biệt 
         * file .cs và các class. Một file cs có thể chứa nhiều class
         * Tất cả những thứ gì chứa thông tin, có thể được lưu thông tin lại và
         * tương tác được => đối tượng
         * OOP có 4 tính chất cơ bản (Đóng gói, kế thừa, tính đa hình, trừu tượng)
         * Đóng gọi: Thể hiện khả năng truy cập
         * Kế thừa: Thể hiện khả năng sử dụng lại các thành phần có sẵn
         * Đa hình: thể hiện Sự đang dạng trong việc thể hiện các hành động
         * Trừu tượng: Trừu tượng hóa các lớp đối tượng thông qua các thành phần chung
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            // Tạo 1 đối tượng
            Dongvat dv; // Khai báo - đối tượng sẽ mang giá trị null
            // dv.InThongTin(); // Lỗi vì đối tượng chưa được khởi tạo
            Dongvat dv2 = new Dongvat(); // Khỏi tạo bằng constructor không tham số
            dv2.InThongTin();
        }
    }
}