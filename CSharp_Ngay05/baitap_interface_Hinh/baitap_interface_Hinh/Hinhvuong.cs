using System;
namespace baitap_interface_Hinh
{
	public class Hinhvuong : Hinhchunhat
	{
		double canh;
		public Hinhvuong()
		{
			canh = 0;
		}
		public Hinhvuong(double canh)
		{
			this.canh = canh;
		}
		public double Canh
		{
			get{return this.canh;}
			set { this.canh = value; }
		}
		public override void Nhap()
		{
			Console.WriteLine("nhập độ dài cạnh của hình vuông:");
			canh = double.Parse(Console.ReadLine());
		}
        public override void Hienthi()
        {
			Console.WriteLine("Hình vuông có chiều dài là: "+ canh);
        }
        public override double Chuvi()
        {
			return canh * 4;
        }
        public override double Dientich()
        {
			return canh * canh;
        }
    }
}

