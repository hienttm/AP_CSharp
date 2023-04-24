using System;
namespace baitap_Tinhluong_Abstract
{
	public abstract class Nhanvien
	{
		public string hoten;
		public double luongcb;
		public Nhanvien()
		{
		}
		public Nhanvien(string hoten, double luongcb)
		{
			this.hoten = hoten;
			this.luongcb = luongcb;
		}
		
        public virtual void Nhap()
		{
			Console.WriteLine("Nhập thông tin nhân viên:");
			Console.WriteLine("Nhập Họ tên:");
			hoten = Console.ReadLine();
			Console.WriteLine("Nhập luơng cơ bản:");
			luongcb = Convert.ToDouble(Console.ReadLine());
		}
		public virtual void Hienthi()
		{
			Console.WriteLine("Họ tên: {0}, lương cơ bản: {1}",hoten,luongcb);
		}
		public abstract double Tinhluong();
	}
}

