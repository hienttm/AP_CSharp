using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            //lớp Dog sử dụng phương thước đã thay mới (new) và ghi đè (override)
            dog.SayHello1();
            dog.SayHello2();

            Console.WriteLine();

            //sử dụng biến animal (kiểu lớp cha Animal)
            //nhưng tham chiếu đến đối tượng tạo từ lớp con Dog
            //thì new và override hoạt động khác nhau
            //Dog dog2 = new Animal();
            Animal animal;
            animal = new Dog();
            animal.SayHello1();//"Hello1 Animal" vì  SayHello1() sử dung new chỉ dùng trong đối tượng Dog
            animal.SayHello2();//"Hello2 Dog": vì SayHello2() ghi đè lên phương thức tương ứng của lớp cha
        }

    }
}
