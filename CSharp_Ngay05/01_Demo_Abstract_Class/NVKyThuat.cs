using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract_Class
{
    public class NVKyThuat : Nhanvien
    {
        public int ngaycong;
        public NVKyThuat()
        {
        }
        public NVKyThuat(string hoten, double luongcoban, int ngaycong)
            :base(hoten, luongcoban)
        {
            this.ngaycong  = ngaycong;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Ngày công:");
            ngaycong = int.Parse(Console.ReadLine());
        }
        public override void hienthi()
        {
            base.hienthi();
            Console.WriteLine("Ngày công: " + ngaycong);
        }
        //định phương thức trừu tượng (chưa nội dung) để lớp con buộc phải kế thừa
        public override double Tinhluong()
        {
            return luongcoban + (ngaycong * 100000);
        }
    }
}
