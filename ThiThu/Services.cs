using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu
{
    internal class Services
    {
        List<Nganhhoc> list = new List<Nganhhoc>(); // Sợ quên thì khỏi tạo luôn ở đây
        public Services()
        {
            list = new List<Nganhhoc>();  // thông thường sẽ khởi tạo ở đây
        }
        // 
        public void NhapDS()
        {
            Console.WriteLine("Ban muon nhap bao nhieu");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                // Mỗi lần lặp tạo ra 1 đối tượng để thực hiện việc nhập
                Nganhhoc nh = new Nganhhoc();
                Console.WriteLine("Nhập id");
                nh.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập Ten");
                nh.Ten = Console.ReadLine();
                Console.WriteLine("Nhập So ki hoc");
                nh.Sokihoc = Convert.ToInt32(Console.ReadLine());
                // Thêm đối tượng vừa nhập vào List
                list.Add(nh);
                Console.WriteLine("Bạn co muon nhap tiep hay ko? Y neu co, con lai la khong");
                string choose = Console.ReadLine();
                if(choose == "Y") NhapDS();  // Gọi lại hàm để nhập tiếp
            }
        }
    }
}
