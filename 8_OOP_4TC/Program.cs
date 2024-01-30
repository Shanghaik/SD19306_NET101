namespace _8_OOP_4TC
{
    internal class Program
    {
        /*
         * OOP có 4 tính chất căn bản bao gồm
         * 1. Tính đóng gói (bao đóng) thể hiện khả năng truy cập tới các thành
         * phần trong class (field, constructor, method,..)
         * VD: Phòng học khi đóng cửa (private) thì sinh viên không thể vào được
         * Cổng trường luôn mở nên bất kì ai cũng vào được.
         * 2. Kế thừa: Thể hiện khả năng cho phép tái sử dụng các thành phần đã
         * được tạo ra và kế thừa lại. Trong C# chỉ có thể đơn kế thừa với Class
         * 3. Tính đa hình: Với cùng 1 hành động (thể hiện qua method) thì với 
         * các đối tượng khác nhau hoặc cũng 1 đối tượng nhưng ở các trạng thái
         * khác nhau sẽ thể hiện ra khác nhau.
         * VD: Chùng là hành động tập võ nhưng bạn A thích tập võ thì tập rất
         * hăng còn bạn B lười hoạt động thì tập cho có. Đối tượng - Sinh viên
         * Hành động - Tập võ. Cùng là hành động đi xe máy nhưng nếu dậy sớm đi 
         * sẽ chậm và cần thận hơn khi dậy muộn và có nguy cơ đến muộn giờ
         */
        static void Main(string[] args)
        {
            Oto ot = new Oto();
            // Console.WriteLine(ot.ten);
            Console.WriteLine(ot.hangSX);
            // Console.WriteLine(ot.namSX);
            Console.WriteLine(ot.color);
            Console.WriteLine(ot.soghe);
        }
    }
}