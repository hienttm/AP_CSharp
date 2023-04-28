using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResouce;
namespace Bai07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //sử dụng các class trong namespace đặt cùng tệp mã .cs 
            //cũng phải using trước, hoặc sử dụng đường dẫn đầy đủ
            TestNamespace.Testclass class1 = new TestNamespace.Testclass();
            class1.display();
            //khi sử dụng lớp ở Namespace khác mà chưa using
            //thì phải chỉ rõ đường dẫn tenNamspace.tenClass
            HumanResouce.Employee e1 = new HumanResouce.Employee("Vân");
            e1.display();
            //muốn sử dụng trực tiếp class từ Namespace khác
            //thì phải sử dụng using tenNamespace; ở trên
            Employee e2 = new Employee("Tuấn");
            e2.display();
        }
    }
    
}
namespace TestNamespace
{
    class Testclass
    {
        public void display()
        {
            Console.WriteLine("Ví dụ sử dụng namespace");
        }
    }
}
