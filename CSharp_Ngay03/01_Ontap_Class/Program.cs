using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Person person1 = new Person("Nguyễn Văn A", true);
            Console.WriteLine("Họ tên:" + person1.Hoten);
            Console.WriteLine("Giới tính: " + person1.Gioitinh);
            Person person2 = new Person();
            person2.Hoten = "Trần Thị B";
            //person2.gioitinh = false;
            person2.Gioitinh = "Nam";
            Console.WriteLine("Họ tên:" + person2.Hoten);
            Console.WriteLine("Giới tính 1: " + person2.gioitinh);
            Console.WriteLine("Giới tính 2: " + person2.Gioitinh);
        }
    }
}
