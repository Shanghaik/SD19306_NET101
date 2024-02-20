namespace ThiThu
{
    internal class Program
    {
        public static string Menu()
        {
            Console.WriteLine("1: Nhap");
            Console.WriteLine("2: Xuat");
            Console.WriteLine("3: Xuat > 6");
            Console.WriteLine("4: Xoa");
            Console.WriteLine("5: Thoat");
            Console.WriteLine("6: Ke thua");
            Console.WriteLine("Hãy nhap lua chon cua ban");
            string choose = Console.ReadLine();
            return choose;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Services sv = new Services(); // Tạo ra để gọi các phương thức đã làm
            while (true)
            {
                switch (Menu()) // Menu được gọi lại và sử dụng như 1 string
                {
                    case "1":
                        sv.NhapDS(); break;
                    case "2":
                        sv.XuatDS(); break;
                    case "3":
                        sv.XuatDSKihocHon6(); break;
                    case "4":
                        sv.XoaC2(); break;
                    case "5":
                        // return; // Không nên dùng
                        Environment.Exit(0); // Thoát hẳn môi trường
                        break;
                    case "6": 
                        NganhUDPM udpm = new NganhUDPM();
                        udpm.Id = 1; udpm.Ten = "UDPM"; udpm.Sokihoc = 6;
                        udpm.InThongTin();
                        break;
                    default: 
                        Console.WriteLine("Nhập từ 1 đến 6 thôi ông nội =))");
                        break;
                }
            }
        }
    }
}