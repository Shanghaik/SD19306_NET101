using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP
{

    internal class Dongvat
    {
        // Khai báo các thuộc tính cho đối tượng
        private string ten = "Chó"; // mặc định là private rồi
        string tuoi;
        string gioitinh = " Đực";
        int sochan = 3;
        string noio = "Ao hồ"; // Ao hồ cũng là giá trị mặc định
        // Property với get và set được dùng để gán hoặc lấy ra giá trị
        // của thuộc tính nào đó
        // Bôi đen các thuộc tính, sau đó ấn tổ hợp các phím ctrl . hoặc
        // click chuột phải chọn Quick Action... 
        // Sau đó chọn Encasulate Field and Use Property
        public string Ten { get => ten; set => ten = value; }
        public string Tuoi { get => tuoi; set => tuoi = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public int Sochan { get => sochan; set => sochan = value; }
        public string Noio { get => noio; set => noio = value; }
        // Constructor (hàm tạo) khỏi tạo các đối tượng với các giá trị thuộc tính
        // Constructor không tham số
        // Khởi tạo đối tượng với các giá trị mặc định (có thể được thiết lập)
        // Tổ hợp phím: CTOR tab tab (Xê tê o rờ táp táp)
        public Dongvat()
        {
            // Gán giá trị mặc định
            sochan = 4; // giá trị mặc định = 4, ưu tiên giá trị nằm trong constructor
            tuoi = "1"; // tuổi mặc định = 1
        }

        public Dongvat(string ten, string tuoi, string gioitinh, int sochan, string noio)
        {
            this.ten = ten; // this chính là bản thân class
            this.tuoi = tuoi; // this.tuoi và tuoi khác gì nhau?
            this.gioitinh = gioitinh; // this.tuoi là thuộc tính tuoi của class
            this.sochan = sochan; // tuoi là giá trị được truyền vào (param)
            this.noio = noio;
        }

        public Dongvat(string ten, string tuoi, string gioitinh)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.gioitinh = gioitinh;
        }
        // Constructor có tham số - khởi tạo đối tượng với thuộc tính mang giá
        // trị của các tham số được truyền vào
        // Cách tạo:
        // 1. Bôi đen các thuộc tính => Ctrl . => Generate Constructor
        // 2. Click vào vùng trống trên màn hình => Ctrl . => Generate Constructor
        // chọn các thuộc tính mà mình muốn cho vào => OK

        // Các Method (Phương thức) thể hiện các hành vi của đối tượng
        // Method có cấu tạo y hệt như function nhưng phải gắn liên với đối tượng
        public void InThongTin()
        {
            Console.WriteLine($"Động vật {ten} {gioitinh }có số tuổi là: {Tuoi}");
            Console.WriteLine($"Đang sinh sống tại {Noio} hiện còn: {sochan} chân");
        }
        // Nôi viết hoa thực chất sẽ trỏ đến noio viết thường nên bản chất chúng đều là 1
        public void PhanLoai()
        {
            if (sochan == 2) Console.WriteLine("gia cầm");
            else if (sochan == 4) Console.WriteLine("Gia súc");
            else Console.WriteLine("Không xác định");
        }


    }
}
