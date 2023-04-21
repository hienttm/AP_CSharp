using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_Mang_Class
{
    internal class Sinhvien
    {
        private string masv;
        private string hoten;
        private double diem;
        public string MaSV { get { return masv; } set { masv = value; } }
        public string Hoten { get { return hoten; } set { hoten = value; } }
        public double Diem { get { return diem; } set { diem = value; } }   
        //xây dựng 2 contructor (nạp chồng 2 hàm tạo)
        public Sinhvien()
        {
            masv = "";
            hoten = "";
            diem = 0;
        }
        public Sinhvien(string masv, string hoten, double diem)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.diem = diem;
        }
        //xây dựng phương thực Nhap() để nhập thông tin sinh viên từ bàn phím
        public void Nhap()
        {
            Console.Write("mã sv:");
            masv = Console.ReadLine(); ;
            Console.Write("họ tên:");
            hoten = Console.ReadLine() ;
            do
            {
                Console.Write("điểm:");
                diem = double.Parse(Console.ReadLine());
            } while (diem < 0 || diem > 10);
        }
        public void Hienthi()
        {
            Console.WriteLine("Mã: {0}, Họ tên: {1}, Điểm : {2}", masv, hoten, diem);
        }
    }
}
