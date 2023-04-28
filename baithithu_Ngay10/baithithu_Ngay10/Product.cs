using System;
namespace baithithu_Ngay10
{
	public abstract class Product
	{
		public string productId;
		public string name;
		public double price;
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
			get { return this.productId; }
		}
		public string Name
		{
			set { this.name = value; }
			get { return this.name; }
		}
		public double Price
		{
			set { this.price = value; }
			get { return this.price; }
		}
        public abstract double computeTax();
    }
}

