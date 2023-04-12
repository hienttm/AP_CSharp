using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project05_OOP
{
    internal class Student
    {
        public string Name;
        public int Age;
        public double Mark;
        public Student()
        {
            Name = "";
            Age = 0;
        }
        public Student(String Name, int Age, double Mark)
        {
            this.Name= Name;
            this.Age = Age;
            this.Mark = Mark;
        }
        public void Input()
        {
            Console.WriteLine("Name:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Age:");
            //this.Age = Convert.ToInt32(Console.ReadLine());
            this.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Mark:");
            //this.Mark= Convert.ToDouble(Console.ReadLine());
            this.Mark = double.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("{0}, {1}, {2}", Name, Age, Mark);
        }
    }
}
