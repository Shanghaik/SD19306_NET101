namespace _4_VongLap
{
    internal class Program
    {
        /*
         * Vòng lặp là 1 cấu trúc lệnh cho phép thực thi lặp đi lặp lại
         * mội khối lệnh mà không cần viết lại nhiều lần tuân theo một
         * điều kiện nào đó
         * Các loại vòng lặp quen thuộc: for, while, do-while, foreach
         */
        static void Main(string[] args)
        {
            //int i = 0;
            //for (; i < 11;)
            //{
            //    Console.Write(i + " ");
            //    i++;
            //}
            //while (i < 11)
            //{
            //    Console.Write(i + " ");
            //    i++;
            //}
            //i++;
            //Console.WriteLine("Giá trị sau vòng for là: " + i); 
            // Dùng vòng lặp for để kiểm tra số nguyên tố
            // Số nguyên tố là số nguyên dương chỉ có 2 ước nguyên dương là 1
            // và chính nó.
            //Console.Write("Nhap vao mot so: ");
            //int number = int.Parse(Console.ReadLine());
            //bool IsPrime = true; // Kiểm tra số nguyên tố
            //if (number < 2)
            //{
            //    Console.WriteLine($"{number} is a prime number");
            //}
            //for (int i = 2; i <= Math.Sqrt(number); i++)
            //{
            //    if (number % i == 0)
            //    {
            //        IsPrime = false;
            //        break;
            //    }
            //}
            //if (IsPrime)
            //{
            //    Console.Write($"{number} la so nguyen to.");
            //}
            //else
            //{
            //    Console.Write($"{number} khong phai so nguyen to.");
            //}
            //Console.ReadKey();
            // Sử dụng do while để viết chương trình yêu người dùng nhập số cho đến
            // khi nhập một số chính phương thì in số đó ra và dừng lại
            do
            {
                Console.WriteLine("Please enter a number: ");
                int num = int.Parse(Console.ReadLine());
                int a = (int)Math.Sqrt(num);// Tính nguyên của căn bậc 2 của số vừa nhập
                if (a * a == num)
                {
                    Console.WriteLine($"{num} is a square number!");
                    break;
                }
            } while (true);
        }
    }
}