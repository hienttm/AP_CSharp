using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexer
{
    internal class Student
    {
        public int id;
        public string name;
        public Student()
        {
            id = 0;
            name = "";
        }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void assgin(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Id: {0}, Name: {1}", id, name);
        }
    }
}
