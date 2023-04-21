using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thamchieu_Thamtri_Ontap
{
    internal class Program
    {
        //tham trị: trong hàm thay đổi biến x
        //thì không ảnh hưởng biến a truyền cho nó
        //vì chỉ sao chép giá trị của a cho x
        static void Tang_Thamtri(int x)
        {
            x = x + 1;
        }
        //tham chiếu: trong hàm thay đổi biến x
        //thì chính là thay đổi biến b truyền cho nó
        //vì biến x là tham chiếu tới biến b qua địa chỉ
        static void Tang_Thamchieu(ref int x)
        {
           x = x + 1;//tương đương b = b+1;
        }
        static void Main(string[] args)
        {
            int a,b;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("tham trị");
            a = 10;
            Console.WriteLine("trước gọi hàm a = " + a);
            Tang_Thamtri(a);
            Console.WriteLine("sau gọi hàm a = " + a);
            
            Console.WriteLine("tham chiếu");
            b = 10;
            Console.WriteLine("trước gọi hàm b = " + b);
            //nếu dùng ref thì biến phải được gán giá trị trước khi gọi hàm
            Tang_Thamchieu(ref b);
            Console.WriteLine("sau gọi hàm b = " + b);
            Console.ReadKey();
        }
    }
}
