using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLopTrutuong
{
    internal class NhanvienKT : Nhanvien
    {
        public int ngaycong;

        public NhanvienKT() : base()
        {
            ngaycong = 0;
        }

        public NhanvienKT(string name, double luongcb, int ngaycong) : base(name, luongcb)
        {
            this.ngaycong = ngaycong;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhập ngày công:");
            ngaycong = int.Parse(Console.ReadLine());
        }
        public override void hienthi()
        {
            base.hienthi();
            Console.WriteLine("Ngày công:" + ngaycong);
        }
        public override double tinhluong()
        {
            return luongcb + ngaycong * 100000;
        }
        public void hienthinvkt()
        {
            Console.WriteLine("Ngày công:" + ngaycong);
            Console.WriteLine("Lương:" + tinhluong());
        }
    }
}
