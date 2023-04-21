using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Kethua
{
    //lớp Student kế thừa lớp Person => thừa hưởng:
    //+ các thuộc tính: name, age
    //+ các phương thức: display(),input()
    public class Student : Person
    {
        //khai báo thêm thành phần mới : điểm
        private double mark;
        //xây dựng hàm tạo và gọi hàm tạo lớp cha thì sử dụng :base(tham số)
        public Student() : base() //gọi hàm tạo Person()
        {
            mark = 0;
        }
        public Student(string name, int age, double mark)
            :base(name, age) //gọi và truyền tham số cho hàm tạo Person(string name, int age)
        {
            this.mark = mark;   
        }
        //ghi đè (override) là cho phép tạo 1 hàm ở lớp con cùng tên và ham số
        //như hàm đã được kế thừa từ lớp cha 
        //sử dụng new để tạo phương thức mới trùng tên
        public new void display()
        {
            Console.WriteLine("display in Student");
            base.display();//gọi display() của Person
            Console.WriteLine("Mark: " + mark);
        }
        //sử dụng lệnh override để tạo phương thức trùng tên
        //ở lớp cơ sở phải sử dụng lệnh virtual cho phương thức input
        public override void input()
        {
            Console.WriteLine("input in Student");
            base.input();
            Console.Write("Mark: ");
            mark = double.Parse(Console.ReadLine());
        }
    }
}
