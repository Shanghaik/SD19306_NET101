namespace _9_List
{
    internal class Program
    {
        /*
         * List là một loại Generic Collection được sử dụng để hỗ trợ lập
         * trình viên lưu trữ và quản lý dữ liệu một cách hiệu quả hơn
         * so với mảng, List có thể chứa nhiều kiểu dữ liệu nhưng khi đã
         * được khai báo nó chỉ chỉ có thể dùng được 1 loại dữ liệu duy nhất 
         * cho cả danh sách. VD: List số nguyên, List Động vật,...
         * Kích thước của List là không giới hạn, truy xuất phần tử trong list
         * tương tự như trong array (mảng) thông qua chỉ số
         */
        static void Main(string[] args)
        {
            // Cú pháp khai báo 
            List<int> list; // Không nên chỉ khai báo
            // Khởi tạo
            List<int> listInt = new List<int>();
            List<string> listString = new List<string>();
            // kí hiệu <x> với x là kiểu dữ liệu chung của cả List
            // Để sử dụng được List ta có các phương thức hỗ trợ
            // Các phương thức thêm
            // Các phương thức xóa
            // Thêm với add và addrange
            listInt.Add(1); listInt.Add(2); listInt.Add(3); listInt.Add(4);
            Console.WriteLine("List int so 1");
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
            List<int> listInt2 = new List<int>();
            listInt2.Add(5); listInt2.Add(6); listInt2.Add(7); listInt2.Add(8);
            Console.WriteLine("\nList int so 2");
            foreach (var item in listInt2)
            {
                Console.Write(item + " ");
            }
            listInt.AddRange(listInt2); // Thêm 1 list vào list khác cùng loại
            Console.WriteLine("\nList int so 1 sau khi them la");
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
            // Thêm với Insert/InsertRange
            listInt.Insert(5, 1000);// thêm vào vị trí 5 giá trị 1000
            Console.WriteLine("\nList int so 1 sau khi insert 1000 la");
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
            // List không có phương thức để sửa trực tiếp mà cần truy xuất đến phần tử
            // sau đó trực tiếp sửa phần tử đó
            listInt[7] = 777;
            Console.WriteLine("\nList int so 1 sau khi sua la");
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
            // Xóa với remove/removeAt/removerange/removeAll
            listInt.Remove(4); // xóa phần tử đầu tiên có giá trị là 4
            Console.WriteLine("\nList int so 1 sau khi xoa phan tu gia trị 4 la");
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
            listInt.RemoveAt(4); // xóa phần tử đầu tiên có giá trị là 4
            Console.WriteLine("\nList int so 1 sau khi xoa phan tu vị trí 4 la");
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
            listInt.RemoveRange(2, 3); // Xóa từ vị trí 2, 3 phần tử
            Console.WriteLine("\nList int so 1 sau khi xoa tu vi tri 2, 3 phan tu la");
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
            listInt.Insert(2, 4); listInt.Insert(5, 4); listInt.Insert(0, 4);
            Console.WriteLine("\nList khi thêm 3 phần tử 4");
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
            listInt.RemoveAll(p => p == 4); // Xóa tất cả phần tử bằng 4
            Console.WriteLine("\nList khi thêm xóa het phan tu 4");
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
        }
    }
}