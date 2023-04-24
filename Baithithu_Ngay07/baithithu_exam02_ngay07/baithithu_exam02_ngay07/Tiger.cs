using System;
using System.Xml.Linq;

namespace baithithu_exam02_ngay07
{
	public class Tiger:Animal
	{
		public Tiger():base()
		{
		}
		public Tiger(string name, double weight)
			:base()
		{

		}
        public override void SetMe()
        {
            Console.WriteLine("Input name of Tiger: ");
            name = Console.ReadLine();
            Console.WriteLine("Input weight of Tiger: ");
            weight = double.Parse(Console.ReadLine());
        }
        public override void Show()
        {
            Console.WriteLine("Name of Tiger: {0} , Weight:{1}", name, weight);
        }
    }
}

