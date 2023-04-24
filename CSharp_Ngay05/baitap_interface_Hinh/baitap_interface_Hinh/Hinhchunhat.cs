using System;
namespace baitap_interface_Hinh
{
	public class Hinhchunhat:iHinh
	{
        public double chieudai;
        public double chieurong;
        public Hinhchunhat()
		{
			chieudai = chieurong = 0;
		}
		public Hinhchunhat(double chieudai, double chieurong)
		{
			this.chieudai = chieudai;
			this.chieurong = chieurong;
		}
		public double Chieudai
		{
			get { return this.chieudai; }
			set { this.chieudai = value; }
			
		}
		public double Chieurong
		{
			get { return this.chieurong; }
			set { this.chieurong = value; }
		}
		public virtual void Nhap()
		{
			Console.WriteLine("Nhap chieu dai hinhf chu nhat: ");
			chieudai = double.Parse(Console.ReadLine());
			Console.WriteLine("nhap chieu rong hinh chu nhat:");
			chieurong = double.Parse(Console.ReadLine());
		}
		public virtual void Hienthi()
		{
			Console.WriteLine("Hình chữ nhật có chiều dài là: {0}, chiều rộng là: {1}", chieudai, chieurong);
		}
		public virtual double Chuvi()
		{
			return (chieurong + chieudai) * 2;
		}
		public virtual double Dientich()
		{
			return chieudai * chieurong;
		}
	}
}

