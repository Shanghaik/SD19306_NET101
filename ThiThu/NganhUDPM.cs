using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu
{
    internal class NganhUDPM : Nganhhoc
    {
        string khauhieu = "Kieu gi thi cung se hoc lai thoi";

        public string Khauhieu { get => khauhieu; set => khauhieu = value; }
        public NganhUDPM()
        {

        }
        public void InThongTin()
        {
            base.InThongTin(); // Kế thừa phương thức
            Console.WriteLine("Cung toi ho khau hieu " + khauhieu);
        }
    }
}
