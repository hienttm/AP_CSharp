using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class Dog : Animal //lớp Dog kế thừa lớp cha Animal
    {
        //lệnh new dùng để tạo thêm phương thức mới cho phương thức
        //cùng tên (và tham số, kiểu trả về) mà lớp con kế thừa
        public new void SayHello1()
        {
            Console.WriteLine("Hello1 Dog");
        }
        //lệnh override để ghi đè phương thức
        //cùng tên (và tham số, kiểu trả về) mà lớp con kế thừa
        //điều kiện là ở lớp cha phải có lệnh virtual trước  SayHello2()
        public override void SayHello2()
        {
            Console.WriteLine("Hello2 Dog");
        }
    }
}
