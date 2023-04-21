using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Mang_Thamchieu
{
    internal class Student
    {
        //khai báo các Fields
        private int id;
        private string name;    
        //khai báo constructor
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
        //khai báo các Properties
        public int Id { 
            get { return id; } 
            set { id = value; } 
        }
        public string Name { 
            get => name;  
            set => name = value; 
        }
        
        public void input()
        {
            Console.Write("Id =");
            this.id = int.Parse(Console.ReadLine());
            Console.Write("Name = ");
            this.name = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("id : {0}, name : {1}", this.id, this.name);
        }
           
    }
}
