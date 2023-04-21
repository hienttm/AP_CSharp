using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_va_Out
{
    internal class Program
    {
        //để xây dựng hàm có tham số dạng tham chiếu
        //có thể sử dụng từ khóa out tương tự ref
        //khác nhau:
        //khi sử dụng ref thì các biến phải được khởi tạo trước khi gọi hàm
        //khi sử dụng out thì biến không cần khởi tạo,
        //nhưng trong hàm phải khởi tạo giá trị cho tham số
        static void tang(ref int x)
        {
            x = x + 1;
            //do trong hàm không khởi tạo biến x, nên phải dùng ref thay cho out
        }
        static void nhap(out int y)
        {
            Console.WriteLine("Nhap so nguyen:");
            y = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int a=10;
            tang(ref a);
            Console.WriteLine("a sau khi tang:" + a);
            int b;
            //do b chưa được khởi tạo nên phải dùng out thay cho ref
            nhap(out b);//hàm nhập số nguyên vào ô nhớ b
            Console.WriteLine("b = " + b);
        }
    }
}
