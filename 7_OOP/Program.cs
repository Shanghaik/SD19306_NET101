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
            //Dongvat dv2 = new Dongvat(); // Khỏi tạo bằng constructor không tham số
            //dv2.InThongTin();
            //// Sử dụng get để lấy giá trị cảu thuộc tính và set để gán
            //// giá trị cho thuộc tính
            //Console.WriteLine("Sau khi set giá trị");
            //dv2.Ten = "Mèo"; // set để gán giá trị
            //dv2.Noio = "Rừng";
            //dv2.InThongTin();
            //Console.WriteLine("Số chân của con vật này là: " + dv2.Sochan);
            // Get hay set đều dùng dấu . để tương tác với thuộc tính
            // Dùng Constructor có tham số
            Dongvat dv3 = new Dongvat("Gà", "3 tháng", "Mái", 2, "Chuồng gà");
            dv3.InThongTin();
            Dongvat dv4 = dv3;
            dv4.InThongTin();
            dv3.Sochan = 10;
            Console.WriteLine("Sau khi thay đổi dv3");
            dv4.InThongTin();
            // Khi gán dv4 = dv3 mà ta thay đổi thông tin của dv3 thì
            // dv4 thay đổi theo
            // Class là 1 references type là những kiểu dữ liệu cho phép
            // tham chiếu. Tức là khi ta khai báo dv4 = dv3 thì bản chất
            // chúng ta chỉ tạo ra thêm 1 biến dv4 kiểu Dongvat nhưng trỏ
            // tới nơi lưu trữ dữ liệu của dv3.

        }
    }
}