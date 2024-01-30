using _8_OOP_4TC;

namespace _8_TestOOP
{
    internal class Program
    {
        // muốn dùng dc class ... ở project khác => Add references 
        // Chuột phải vào mục dependency/references của project
        // Chọn add project reference => Chọn project nguồn cần add => OK
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Oto ot = new Oto();
            // Console.WriteLine(ot.ten);
            Console.WriteLine(ot.hangSX);
            // Console.WriteLine(ot.namSX);
            // Console.WriteLine(ot.color);
            // Console.WriteLine(ot.soghe);
        }
    }
}