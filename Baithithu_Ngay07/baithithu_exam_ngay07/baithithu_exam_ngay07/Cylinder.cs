using System;
namespace baithithu_exam_ngay07
{
	public class Cylinder
	{
        private double radius;
        private double height;
        private double BaseArea, LateralArea, TotalArea, Volume;
        public Cylinder()
		{
			radius = 0;
			height = 0;
		}
		public Cylinder(double radius, double height)
		{
			this.radius = radius;
			this.height = height;
		}
		public double Radius
		{
			get { return this.radius; }
			set { this.radius = value; }
		}
		public double Height
		{
			get { return this.height; }
			set { this.height = value; }
		}

		public void Nhap()
		{
			Console.WriteLine(" Nhập bán kính hình trụ:");
			radius = double.Parse(Console.ReadLine());
			Console.WriteLine("Nhập chiều cao hình trụ:");
			height = double.Parse(Console.ReadLine());
		}
		public void Hienthi()
		{
			Console.WriteLine("Cylinder Characteristics");
			Console.WriteLine("Radius: {0}, Height: {1}", radius, height);
		}

        
        
        public void Process()
		{
			
            BaseArea = radius * radius * Math.PI;
            LateralArea = 2 * Math.PI * radius * height;
            TotalArea = 2 * Math.PI * radius * (height + radius);
            Volume = Math.PI * radius * radius * height;
        }
		public void Result()
		{
			Console.WriteLine("Base: {0}  ; Lateral: {1}  ; Total: {2}  ; Volume: {3}", BaseArea, LateralArea, TotalArea, Volume);
		}
    }
}

