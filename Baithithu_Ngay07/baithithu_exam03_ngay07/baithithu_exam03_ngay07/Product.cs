using System;
namespace baithithu_exam03_ngay07
{
	public class Product
	{
        
        private string productId;
		private string name;
		private double price;
		public Product()
		{
			productId = "";
			name = "";
			price = 0;
		}
		public Product(string productId, string name, double price)
		{
			this.productId = productId;
			this.name = name;
			this.price = price;
		}
		public string ProductId
		{
			set { this.productId = value; }
			get { return productId; }
		}
		public string Name
		{
			get { return name; }
			set { this.name = value; }
		}
		public double Price
		{
			set { this.price = value; }
			get { return price; }
		}
		public void input()
		{
			Console.WriteLine("Input productId:");
			productId = Console.ReadLine();
			Console.WriteLine("Input name:");
			name = Console.ReadLine();
			Console.WriteLine("Input price:");
			price = double.Parse(Console.ReadLine());
		}
		
		public void display()
		{
			string str = string.Format("{0,-1} {1,-1} {2,-5}", productId, name, price);
			Console.WriteLine(str);
			//Console.Write(string.Format("{0,20}", name));
			//Console.Write(string.Format("${0,10}", price));
			//Console.WriteLine($"{productId,-20} | {name,-20} | {price,-10}");
			
		}
		
	}
}

