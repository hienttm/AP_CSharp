using System;
namespace baithithu_Ngay10
{
	public class Book : Product
	{
		public Book()
		{
		}
		public Book(string productId, string name, double price) :base(productId, name, price)
		{

		}
		public override double computeTax()
		{
			return price * 5 / 100;
		}

    }
}

