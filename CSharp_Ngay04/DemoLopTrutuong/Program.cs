using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLopTrutuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //không được tạo object thể hiện của lớp trừu tượng
            //Nhanvien nv = new Nhanvien();
            NhanvienKT nvkt = new NhanvienKT("NV KT1",10000000,24);
            nvkt.hienthi();
            Console.WriteLine("Lương:" + nvkt.tinhluong());
            nvkt.hienthinvkt();
            //sử dụng biến kiểu lớp cha tham chiếu tới lớp con
            Nhanvien nv = nvkt;
            //truy cập tới các phương thức của nvkt mà đã override
            Console.WriteLine("Lương nv:" + nvkt.tinhluong());
            //nv.ngaycong = 20;
            //nv.hienthinvkt();
        }
    }
}
