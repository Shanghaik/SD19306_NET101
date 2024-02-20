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
        public void NhapDS() // 1.5
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
            }
            Console.WriteLine("Bạn co muon nhap tiep hay ko? Y neu co, con lai la khong");
            string choose = Console.ReadLine();
            if (choose == "Y") NhapDS();  // Gọi lại hàm để nhập tiếp
        }
        public void XuatDS() // 1.0
        {
            if (list.Count == 0)  // Kiểm tra xem list có đnag rỗng hay không, count là số phần tử
            {
                Console.WriteLine("Danh sach dang trong, hay nhap da");
                NhapDS();
                XuatDS();
            }
            Console.WriteLine("Danh sach la:");
            foreach (var item in list) // Với mỗi phần tử của List
            {
                item.InThongTin();
            }
        }
        public void XuatDSKihocHon6() // 1.0
        {
            if (list.Count == 0)  // Kiểm tra xem list có đnag rỗng hay không, count là số phần tử
            {
                Console.WriteLine("Danh sach dang trong, hay nhap da");
                NhapDS();
                XuatDS();
            }
            Console.WriteLine("Danh sach la:");
            foreach (var item in list) // Với mỗi phần tử của List
            {
                if (item.Sokihoc > 6) item.InThongTin();
            }
        }
        public void XoaC1()
        {
            Console.WriteLine("Nhap id can xoa");
            int id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    list.RemoveAt(i); // Xóa đi
                    i--; // cập nhật lại vị trí check vì đã có phần tử bị xóa
                }
            }
            Console.WriteLine("Danh sách sau khi xóa");
            XuatDS();
        }
        public void XoaC2()
        {
            Console.WriteLine("Nhap id can xoa");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var item in list.ToList()) // list và list.ToList() là 2 đối tượng khác nhau
            {
                if (item.Id == id) list.Remove(item);
            }
        }
    }
}
