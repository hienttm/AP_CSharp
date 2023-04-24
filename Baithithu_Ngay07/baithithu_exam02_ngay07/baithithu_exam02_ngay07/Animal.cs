using System;
using System.Xml.Linq;

namespace baithithu_exam02_ngay07
{
	public class Animal
	{
		public string name;
		public double weight;

        public Animal()
		{
			name = "";
			weight = 0;

        }
		public Animal(string name,double weight)
		{
			this.name = name;
			this.weight = weight;
		}
		
		public string Name
		{
			set { this.name = value; }
			get { return this.name; }
		}
		public double Weight
		{
			set { this.weight = value; }
			get { return weight; }
        }
		/*
		public virtual void SetMe()
		{
			Console.WriteLine("Input name of Animal: ");
			name = Console.ReadLine();
			Console.WriteLine("Input weight of Animal: ");
			weight = double.Parse(Console.ReadLine());
		}
		*/
        public virtual void SetMe(string name, double weight)
		{
			this.name = name;
			this.weight = weight;
		}
        public virtual void Show()
        {
            Console.WriteLine("Name of Animal: {0} , Weight:{1}", name, weight);
        }
    }
}

