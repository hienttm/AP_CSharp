using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract_Class
{
    internal class NVKinhdoanh:Nhanvien
    {
        double doanhthu;
        public NVKinhdoanh()
        {
        }
        public NVKinhdoanh(string hoten, double luongcoban, double doanhthu)
            : base(hoten, luongcoban)
        {
            this.doanhthu = doanhthu;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Doanh thu:");
            doanhthu = double.Parse(Console.ReadLine());
        }
        public override void hienthi()
        {
            base.hienthi();//hiển thị thông tin của lớp cha
            Console.WriteLine("Doanh thy: " + doanhthu);
        }
        //định phương thức trừu tượng (chưa nội dung) để lớp con buộc phải kế thừa
        public override double Tinhluong()
        {
            return luongcoban + (doanhthu * 0.1);
        }
    }
}
