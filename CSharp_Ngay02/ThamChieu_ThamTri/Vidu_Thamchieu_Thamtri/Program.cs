using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu_Thamchieu_Thamtri
{
    internal class Program
    {
        //sử dụng truyền đối số qua tham trị
        static void thamtri_tang(int x1)
        {
            x1++;//tăng tham số x1 lên 1 đơn vị
            Console.WriteLine("thamtri_tang: x1=" + x1);
        }
        //sử dụng truyền đối số qua tham chiếu
        static void thamchieu_tang(ref int x2)
        {
            x2++;//tăng tham số x2 lên 1 đơn vị
            Console.WriteLine("thamchieu_tang: x2=" + x2);
        }
        static void Main(string[] args)
        {
            int a = 10;
            thamtri_tang(a);//sao chép giá trị a cho tham số x1: ô nhớ của x1 độc lập với ô nhớ a 
            //sau khi kết thúc hàm thamtri_tang, giá a không thay đổi
            Console.WriteLine("a sau khi tang (tham tri):" + a);
            int b = 10;
            thamchieu_tang(ref b);//cho tham số x2 tham chiếu đến ô nhớ b: x2 và b cùng 1 ô nhớ
            //sau khi kết thúc thamchieu_tang, giá trị x2 thay đổi chính là b
            Console.WriteLine("b sau khi tang (tham chieu):" + b);
        }
    }
}
