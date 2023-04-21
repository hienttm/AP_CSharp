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
            //không được tạo đối tượng từ lớp abstract
            //Nhanvien nv = new Nhanvien();
            NVKyThuat nv1 = new NVKyThuat();
            nv1.nhap();
            nv1.hienthi();

            Nhanvien nv2 = new NVKyThuat();
            nv2.nhap(); //nhap() của lớp NVKyThuat
            nv2.hienthi();//hienthi() của lớp NVKyThuat
        }
    }
}
