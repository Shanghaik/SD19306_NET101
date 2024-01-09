namespace _3_Toantu
{
    /*
     * Toán tử là những kí hiệu để đại diện cho một thao tác/phép toán, biểu thức
     * trong lập trình. Toán tử là thành phần không thể thiếu đối với lập trình. 
     * Có rất nhiều loại toán tử và cách để phân loại.
     * Cách phân loại theo chức năng:
     * - Toán tử số học (Thực thi các biểu thức số học như: + - * / %)
     * - Toán tử quan hệ (>, <, >=, <=, !=, ==)
     * - Toán tử logic (&& || ! ^)
     * - Toán tử gán (=, +=, -=,...) 
     * - Toán tử bit (&, |, ^, ~, >>, <<)
     * Phân loại theo ngôi (ngôi ở đây là số lượng chủ thể cần có của toán tử)
     * - 1 ngôi: --a, ++a, a++, a--, !a,...
     * - 2 ngôi: + - * / %, gán, so sánh,...
     * - 3 ngôi: điều kiện ? biểu thức nếu đk đúng : biểu thức nếu đk sai 
     */
    internal class Program
    {
        // 1. Nhập 2 số nguyên sau đó in ra kết quả của các phép +, -, *, / chính xác
        // đến chữ số thập phân số 4 (Math.Round(số cần làm tròn, số chữ số thập phân))
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Nhập số a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a + b}");
            Console.WriteLine($"{a}-{b}={a - b}");
            Console.WriteLine($"{a}*{b}={a * b}");
            //Console.WriteLine($"{a}/{b}={Convert.ToDouble(a) / b}");
            Console.WriteLine($"{a}/{b}={a * 1.0 / b}");
            Console.WriteLine($"{a}/{b}={(double)a / b}");
            double phepchia = a * 1.0 / b;
            Console.WriteLine($"{a}/{b}={Math.Round(phepchia,4)}");
            // Lưu ý: a là số nguyên mà 1.0 là số thực thì kết quả a*1.0 là số thực
            // dẫn đến kết quả a*1.0/b là số thực
            // 2. Thực hiện các phép gán với a và b vừa nhập
            //Console.WriteLine($"Tăng a lên b đơn vị {a+=b}");
            // 3. Thực hiện các phép ++, -- trên a hoặc b
            // --a sẽ thực hiện giảm a đi 1 đơn vị trước khi câu lệnh chứa nó được thực thi
            // a-- sẽ thực hiện giảm a đi 1 đơn vị sau khi câu lệnh chứa nó được thực thi
            //Console.WriteLine(++a);
            //Console.WriteLine(a);
            // Nguyên lý ưu tiên toán tử. Mỗi toán tử có một chỉ số ưu tiên nhất định, khi
            // chúng được dùng sẽ thực hiện phép tính được ưu tiên trước vd: ++a sẽ ưu tiên
            // hơn so với a++
            Console.WriteLine($"{a++},{++a},{--a},{a--},{a++},{--a}");
            Console.WriteLine(a);
        }
    }
}