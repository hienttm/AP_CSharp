using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//khai báo sử dụng namespace HumanResource
using HumanResource;
namespace Bai08
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            //sử dụng đường dẫn đầy đủ namespace.class thì không cần using
            HumanResource.Employee e1 = new HumanResource.Employee("Thanh");
            e1.display();
            //sử dụng trực tiếp tên class thì phải using namespace chứa class đó
            Employee e2 = new Employee("Trang");
            e2.display();
        }
    }
}
namespace HumanResource
{
    public class Employee
    {
        string name;        
        public Employee(string name)
        {
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Nhân viên:" + name);
        }
    }
}
