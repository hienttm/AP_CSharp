using System;
namespace baithithu_Ngay10
{
	public class Phone:Product
	{
		public Phone()
		{
		}
		public Phone(string productId, string name, double price):base(productId,name,price)
		{

		}
        public override double computeTax()
        {
            return price * 10 / 100;
        }
    }
}

