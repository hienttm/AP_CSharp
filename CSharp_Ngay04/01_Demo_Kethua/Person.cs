using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Kethua
{
    public class Person
    {
        protected string name;
        protected int age;
        //nạp chồng (overload) 2 constuctor
        public Person()
        {
            name = "";
            age = 0;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //phương thức display() để hiển thị thông tin Person
        public void display()
        {
            Console.WriteLine("display in Person");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
        //phương thức input() để nhập thông tin Person
        public virtual void input()
        {
            Console.WriteLine("input in Person");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());
        }
    }
}
