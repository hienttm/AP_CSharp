using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //mảng kiểu dữ liệu là class cha thì được tham chiếu tới đối tượng lớp con
            Nhanvien[] list = new Nhanvien[3];
            list[0] = new NVKyThuat("NV kỹ thuật 1", 8000000, 24);
            list[1] = new NVKinhdoanh("NV Kinh doanh 1", 10000000, 100000000);
            list[2] = new NVKyThuat("NV kỹ thuật 2", 5000000, 20);
            Console.WriteLine("Danh sách nhân viên:");
            foreach (Nhanvien nv in list)
            {
                nv.hienthi();
                double luong = nv.Tinhluong();
                Console.WriteLine("Lương:" + luong);
            }
            Console.ReadKey();
        }
    }
}
