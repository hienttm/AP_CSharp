using System;
namespace baitap_Tinhluong_Abstract
{
	public class Nhanvienkinhdoanh:Nhanvien
	{
		public double doanhthu;
		public Nhanvienkinhdoanh()
		{
		}
		public Nhanvienkinhdoanh(string hoten, double luongcb, double doanhthu) : base(hoten, luongcb)
		{
			this.doanhthu = doanhthu;
		}
        public override void Nhap()
        {
            base.Nhap();
			Console.WriteLine("Nhập doanh thu của NV kinh doanh ");
			doanhthu = Convert.ToDouble(Console.ReadLine());
        }
        public override void Hienthi()
        {
            base.Hienthi();
			Console.WriteLine(" Doanh thu cuả nhân viên là: " + doanhthu);
        }
        public override double Tinhluong()
        {
            return luongcb+doanhthu*0.1;
        }
    }
}

