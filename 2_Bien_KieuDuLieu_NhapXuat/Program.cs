namespace _2_Bien_KieuDuLieu_NhapXuat
{
    /*
     * Biến là gì? Biến được tạo ra để lưu trữ các giá trị
     * với một kiểu dữ liệu nào đó và có thể được thay đổi trong
     * quá trình sử dụng
     * Kiểu dữ liệu cho phép chúng ta xác định xem biến có dữ liệu
     * thuộc loại nào, có nhiều loại kiểu dữ liệu trong đó phổ biến
     * là: int, float, double, char, short, long, string 
     * Giới hạn của kiểu dữ liệu: 
     * int: int32 4 bytes <=> 32 bits - -2^31 - 2^31-1
     * long: int64 8 bytes <=> 64 bits - -2^63 - 2^63-1
     * float, double: IEEE754
     * Khai báo biến/Khởi tạo biên
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int x; // Khai báo biến x kiểu int
            int y = 10; // Khởi tạo biến y kiểu int
            // Câu lệnh xuất thông tin sử dụng phương thức WriteLine()
            // của lớp Console được dựng sẵn có 1 tham số là giá trị
            // cần được in ra màn hình
            Console.WriteLine("Hãy nhập dữ liệu: ");
            // Cú pháp nhập dữ liệu từ bàn phím lên console bằng phương
            // thứ ReadLine() cho phép đọc tất cả dữ liệu trên 1 dòng ở
            // console 
            //string s = Console.ReadLine();
            //Console.WriteLine(s);
            //Console.WriteLine("Hãy nhập s: ");
            //int c = Console.Read();
            //Console.WriteLine(c);
            // Ép kiểu là chuyển đổi dữ liệu từ kiểu này sang kiểu khác
            // để phù hợp với mục đích sử dụng
            // Có 2 loại ép kiểu 
            // 1: Ép kiểu trực tiếp (tưởng minh) khi chúng ta chủ động
            // dử dụng các phương thức để ép kiểu
            //int so = int.Parse(s); // Không thể ép kiểu cho null
            //int so2 = Convert.ToInt32(s); // Trả về 0 nếu null
            //Console.WriteLine(so2);
            // Nhập tên, tuổi, cân nặng của bạn trai người yêu cũ
            // float t = 1.5F;
            // Format code: Ctrl K D, Comment Ctrl K C, Bỏ Comment Ctrl K U
            Console.WriteLine("Nhập tên anh ấy:");
            string ten = Console.ReadLine();
            Console.WriteLine("Anh ấy năm nay:");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anh ấy nặng:");
            double nang = Convert.ToDouble(Console.ReadLine());
            // Xuất dữ trên trên 1 dòng duy nhất
            // Cách 1 sử dụng dấu +
            Console.WriteLine("Tên: " + ten + " Tuổi: " + tuoi + " Nặng: " + nang);
            // Cách 2: Array Argument thông qua {}
            Console.WriteLine("Tên: {0}, Tuổi {1}, Nặng {2}", ten, tuoi, nang);
            // Cách 3: Dùng $ để nhúng trược tiếp biến vào trong chuỗi
            Console.WriteLine($"Tên: {ten}, Tuổi: {tuoi}, Nặng {nang}");
            // Ép kiểu ngầm định là khi chương trình tự động ép kiểu dữ liệu có
            // phạm vi biểu diễn nhỏ hơn sang phạm vi biểu diễn lớn hơn
        } 
    }
}