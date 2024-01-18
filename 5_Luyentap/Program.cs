namespace _5_Luyentap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enter a number");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    sum += x;// Mỗi lần nhập thì tăng tổng lên đúng giá trị nhập
            //    if (Math.Floor(x) != x) // co the dung (int)x != x
            //    {
            //        Console.WriteLine(x + " is a decimal number");
            //        break;
            //    }
            //}
            //string choice = "";
            //Console.WriteLine("Sum of the input numbers is: " + sum);
            //do
            //{
            //    Console.WriteLine("Please enter a choose:");
            //    Console.WriteLine("a. Input:");
            //    Console.WriteLine("b. Output:");
            //    Console.WriteLine("c. Calculate");
            //    Console.WriteLine("d. Exit");
            //    choice = Console.ReadLine();
            //    if (choice == "a")
            //    {
            //        Console.WriteLine("You've choosen a");
            //    }
            //    else if (choice == "b")
            //    {
            //        Console.WriteLine("You've choosen b");
            //    }
            //    else if (choice == "c") 
            //    {
            //        Console.WriteLine("You've choosen c");
            //    }
            //    else if (choice == "d")
            //    {
            //        Console.WriteLine("You've choosen d"); break;
            //    }
            //    else Console.WriteLine("Wrong!!!");
            //    //switch (choice)
            //    //{
            //    //    case "a":
            //    //        Console.WriteLine("You've choosen input");
            //    //        break;
            //    //    case "b":
            //    //        Console.WriteLine("You've choosen output");
            //    //        break;
            //    //    case "c":
            //    //        Console.WriteLine("You've choosen calculate");
            //    //        break;
            //    //    case "d":
            //    //        Console.WriteLine("You want to exit, thanks");
            //    //        break;
            //    //    default:
            //    //        Console.WriteLine("Wrong input!!!");
            //    //        break;
            //    //}
            //}
            //while (true);
            Console.WriteLine("Nhập x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập z");
            double z = Convert.ToDouble(Console.ReadLine());
            if (x * y <= 0 || y * z <= 0 || x * z <= 0)// Nếu có cạnh đó bị âm
            {
                Console.WriteLine("Not a triangle");
            }
            else
            {
                if (x + y > z || x + z > y || z + y > x) // Kiểm tra điều kiện là tam giác - bất đẳng thức tam giác
                {
                    if (x * x == y * y + z * z || x * x + y * y == z * z || x * x == y * y - z * z)// Pytago
                    {
                        Console.WriteLine("Right Triangle"); // Tam giác vuông
                    }
                    else if (x * x > y * y + z * z || x * x + y * y < z * z || y * y > z * z + x * x)
                    {
                        Console.WriteLine("Obtuse Triangle"); // Tam giác tù
                    }
                    else Console.WriteLine("Pointed Triangle");
                }
                else
                {
                    Console.WriteLine("Not a triangle");
                }
            }
        }
    }
}