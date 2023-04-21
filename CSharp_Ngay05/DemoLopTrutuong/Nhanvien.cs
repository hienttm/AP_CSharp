using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLopTrutuong
{
    abstract class Nhanvien
    {
        public string name;
        public double luongcb;

        public Nhanvien()
        {
        }

        public Nhanvien(string name, double luongcb)
        {
            this.name = name;
            this.luongcb = luongcb;
        }
        public virtual void nhap()
        {
            Console.Write("Nhập họ tên:");
            name = Console.ReadLine();
            Console.Write("Nhập lương cb:");
            luongcb = double.Parse(Console.ReadLine()); 
        }
        public virtual void hienthi()
        {
            Console.WriteLine("Họ tên:" + name);
            Console.WriteLine("Lương CB:" + luongcb);
        }
        public abstract double tinhluong();
    }
}
