using System;
namespace baitap_Tinhluong_Abstract
{
	public class NhanvienKythuat : Nhanvien
	{
		public int ngaycong;
		public NhanvienKythuat()
		{
		}
		public NhanvienKythuat(string hoten, double luongcb, int ngaycong):base(hoten,luongcb)
		{
			this.ngaycong = ngaycong;
		}
		public override void Nhap()
		{
			base.Nhap();
            Console.WriteLine("Nhập ngày công");
			ngaycong = int.Parse(Console.ReadLine());
        }
        public override void Hienthi()
        {
            base.Hienthi();
			Console.Write(" Ngày công: " + ngaycong);
        }
        public override double Tinhluong()
        {
			return luongcb + ngaycong * 100000;
        }
    }
}

