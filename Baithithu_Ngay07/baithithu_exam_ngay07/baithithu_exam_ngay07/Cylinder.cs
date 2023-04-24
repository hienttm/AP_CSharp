using System;
namespace baithithu_exam_ngay07
{
	public class Cylinder
	{
		public double Radius;
		public double Height;

        public Cylinder()
		{
			Radius = 0;
			Height = 0;
		}
		public Cylinder(double Radius, double Height)
		{
			this.Radius = Radius;
			this.Height = Height;
		}
		public double radius
		{
			get { return this.Radius; }
			set { this.Radius = value; }
		}
		public double height
		{
			get { return this.Height; }
			set { this.Height = value; }
		}

		public void Nhap()
		{
			Console.WriteLine(" Nhập bán kính hình trụ:");
			Radius = double.Parse(Console.ReadLine());
			Console.WriteLine("Nhập chiều cao hình trụ:");
			Height = double.Parse(Console.ReadLine());
		}
		public void Hienthi()
		{
			Console.WriteLine("Cylinder Characteristics");
			Console.WriteLine("Radius: {0}, Height: {1}", Radius, Height);
		}

        
        double BaseArea, LateralArea, TotalArea, Volume;
        public void Process()
		{
			
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }
		public void Result()
		{
			Console.WriteLine("Base: {0}  ; Lateral: {1}  ; Total: {2}  ; Volume: {3}", BaseArea, LateralArea, TotalArea, Volume);
		}
    }
}

