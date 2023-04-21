using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traodoi
{
    internal class Program
    {
        static void traodoi1(int x1, int y1)
        {
            int temp;
            temp = x1;
            x1 = y1;
            y1 = temp;
        }
        static void traodoi2(ref int x2,ref int y2)
        {
            int temp;
            temp = x2;
            x2 = y2;
            y2 = temp;
        }
        static void Main(string[] args)
        {
            int a1 = 10;
            int b1 = 20;
            Console.WriteLine("Truoc traodoi1, a1 = {0}, b1 = {1}", a1, b1);
            traodoi1(a1, b1);
            Console.WriteLine("Sau traodoi1, a1 = {0}, b1 = {1}", a1, b1);
            //x1 là bản sao độc lập của a1,y2 là bản sao độc lập của b1
            //sự thay đổi x1,y1 trong hàm traodoi1 không ảnh hưởng tới a1,b1

            int a2 = 10;
            int b2 = 20;
            Console.WriteLine("Truoc traodoi2, a2 = {0}, b2 = {1}", a2, b2);
            traodoi2(ref a2,ref b2);
            Console.WriteLine("Sau traodoi2, a2 = {0}, b2 = {1}", a2, b2);
            //x2 tham chiếu tới a2, y2 tham chiếu tới b2
            //sự thay đổi x2,y2 trong hàm traodoi2() sẽ thay đổi a2,b2
        }
    }
}
