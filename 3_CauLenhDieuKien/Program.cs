namespace _3_CauLenhDieuKien
{
    /*
     * Câu lệnh điều kiện là những cú pháp, câu lệnh, cấu trúc mà 
     * kết quả thực thi dựa theo 1 điều kiện nào đó mang giá trị 
     * boolean (true/false) 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //int x = 10, y = 10;
            //bool a = x == y;
            //Console.WriteLine(a);
            //if(a)
            //{
            //    Console.WriteLine("x bằng y");
            //}else
            //{
            //    Console.WriteLine("x khác y");
            //}
            // Khi chúng ta sử dụng 1 biến bool trong điều kiện
            // thi không cần so sánh thêm nó với true hay false
            // Sử dụng if/else để thực hiện việc in ra màn hình
            // Học lực của sinh viên dựa theo điểm
            // 0 đến dưới 5 -> Tạch, 5 đến dưới 6.5 -> TB, 6.5 -> Dưới 8
            // -> Khá, 8 đến 10 -> Giỏi, ngoài khoảng -> Báo sai
            //Console.WriteLine("Enter your grade: ");
            //double grade = Convert.ToDouble(Console.ReadLine());
            //if(grade<0 || grade > 10)
            //{
            //    Console.WriteLine("Wrong number");
            //}
            //else if(grade >=0 && grade < 5)
            //{
            //    Console.WriteLine("You're failed");
            //}else if (grade < 6.5)
            //{
            //    Console.WriteLine("You're fairy good");
            //}else if(grade < 8)
            //{
            //    Console.WriteLine("You're quite good");
            //}else 
            //{
            //    Console.WriteLine("You're excellent");
            //}
            // Switch-case là câu lệnh điều kiện cho phép thực thi các câu lệnh
            // theo một điều kiện nào đó mạng 1 giá trị cụ thể
            // Nhập 1 số thực a và một số nguyên b
            // sử dụng switch case để thực hiện các câu lệnh sau
            // Nếu b = 2, 3 thì chúng ta tính a^b
            // Nếu b = 4, 5 thì ta tính căn bậc b của a
            // Còn lại thì Tính kết quả Căn bậc b của a*b
            //Console.WriteLine("Hãy nhập a");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Hãy nhập b");
            //int b = Convert.ToInt32(Console.ReadLine());
            //switch (b)
            //{
            //    case 2:
            //    case 3:
            //        Console.WriteLine($"{a}^{b}={Math.Pow(a, b)}");
            //        break;
            //    case 4:
            //    case 5:
            //        Console.WriteLine($"Căn bậc {b} của {a} là: {Math.Pow(a, 1.0 / b)}");
            //        break;
            //    default:
            //        Console.WriteLine($"Căn bậc {b} của {a * b} là: {Math.Pow(a * b, 1.0 / b)}");
            //        break;
            //}
            // Căn bậc b của a = a^(1/b)
            // Khi code xong hãy quen với thao tác 1: Ctrl Shift S: Lưu lại code
            // 2: Ctrl B để build lại project hoặc Ctrl Shift B để build lại Solution
            // Toán tử 3 ngôi có cấu trúc như sau:
            // Điều kiện ? Cú pháp nếu ĐK đúng : Cú pháp nếu ĐK sai
            ////Console.WriteLine("Kết quả so sánh a và b: " + (a >= b ? "A lớn hơn hoặc bằng B" : "B lớn hơn A"));
            ////// Dùng tt 3 ngôi để tính sai khác giữa 2 số: Nếu a>=b thì in ra a-b, ngược lại in ra b-a
            ////Console.WriteLine(a >= b ? a - b : b - a);
            // Nhập 3 số x, y, z, hãy tìm ra số lớn thứ 2 trong 3 số đó
            // Ý tưởng 1: Đi so sánh các số vd nếu x>=y và x<=z => x là số lớn thứ 2
            // => thêm cả 1 trường hợp nữa là x<=y và x>=z giữa 2 DK này là 1 dấu hoặc (||)
            // Ý tưởng 2: Tìm max và min sau đó lấy tổng 3 số trừ max và min
            // Ý tưởng 3: Dựa vào tính chất của số lớn thứ 2: 
            // Số lớn thứ 2 trừ đi max <= 0 và trừ đi min >=0, 2 kết quả đó khi nhân với nhau <=0
            // max - 2 số còn lại >=0 2 kết quả nhân với nhau >=0
            // min - 2 số còn lại <=0 2 kết quả nhân với nhau >=0
            Console.WriteLine("Nhập x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập z:");
            int z = Convert.ToInt32(Console.ReadLine());
            if (x >= y && x <= z || x <= y && x >= z)
            {
                Console.WriteLine($"{x} lớn thứ 2");
            }
            else if (y >= x && y <= z || y <= x && y >= z)
            {
                Console.WriteLine($"{y} lớn thứ 2");
            }
            else Console.WriteLine($"{z} là số lớn thứ 2");
            // Cách 2:
            int max = x >= y && x >= z ? x : y >= z ? y : z; // Tìm max
            // Nếu x lớn hơn cả y và z thì x là max nếu không ta so sánh tiếp y và z, lớn hơn là max
            int min = x <= y && x <= z ? x : y <= z ? y : z; // Tìm min
            Console.WriteLine($"Số lớn thứ 2 là: {x + y + z - min - max}");

        }
    }
}