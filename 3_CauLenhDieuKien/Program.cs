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
            int x = 10, y = 10;
            bool a = x == y;
            Console.WriteLine(a);
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
            Console.WriteLine("Enter your grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());
            if(grade<0 || grade > 10)
            {
                Console.WriteLine("Wrong number");
            }
            else if(grade >=0 && grade < 5)
            {
                Console.WriteLine("You're failed");
            }else if (grade < 6.5)
            {
                Console.WriteLine("You're fairy good");
            }else if(grade < 8)
            {
                Console.WriteLine("You're quite good");
            }else 
            {
                Console.WriteLine("You're excellent");
            }
            
        }
    }
}