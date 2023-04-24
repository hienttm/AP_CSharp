using System;
namespace baithithu_exam02_ngay07
{
	public class Lion:Animal
	{	
		public Lion():base()
		{
		}
		public Lion(string name, double weight)
			:base(name, weight)
		{

		}
        public override void SetMe(string name, double weight)
            
        {
            base.SetMe(name, weight);
        }
        /*
        public override void SetMe()
        {
            Console.WriteLine("Input name of Lion: ");
            name = Console.ReadLine();
            Console.WriteLine("Input weight of Lion: ");
            weight = double.Parse(Console.ReadLine());
        }
        */
        public override void Show()
        {
            Console.WriteLine("Name of Lion: {0} , Weight:{1}", name, weight);
        }
    }
}

