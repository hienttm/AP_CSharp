using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project05_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("A", 20, 9.5);
            Student student2 = new Student();
            student1.Display();
            Console.WriteLine("Input studen2:");
            student2.Input();
            student2.Display();
            Console.ReadKey();

        }
    }
}
