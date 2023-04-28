using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResouce
{
    class Employee
    {
        public string name;

        public Employee(string name)
        {
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Hello, my name is:" + name);
        }
    }
}
