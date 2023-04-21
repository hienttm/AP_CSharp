using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student s1; //khai báo biến s1 kiểu class Student (dạng tham chiếu), mặc định là NULL
            s1 = new Student(1, "Student A");//tạo đối tượng Student mới gán cho s1
            Student s2 = new Student();//vừa khai báo biến s2, vừa khởi tạo đối tượng
            //gán trường id, name thông qua thuộc tính (property) Id,Name
            //s2.id = 2;
            s2.setId(2);//có thể thay bằng lệnh dưới truy cập qua property Id
            s2.Id = 2;
            s2.setName("Student B");
            s2.Name = "Student B";
            int id1 = s2.Id;
            int id2 = s2.getId();
            s1.Display();
            s2.Display();
            //thay đổi các trường (field) của s1 thông qua Properti Id,Name
            //s1.Id = 3;
            //s1.Name = "Student A2";
            s1.Display();
            //thay đổi các field  của s2 thông qua phương thức
            s2.SetInfo(2, "Student B2");
            s2.Display();
        }
    }
}
