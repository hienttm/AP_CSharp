using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Overloading
{
    internal class Program
    {
        //Overloading: là kỹ thuật cho phép xây dựng các hàm cùng tên
        //nhưng khác số lượng hoặc kiểu dữ liệu của các tham số
        public static int Tong(int a, int b)
        {
            Console.WriteLine("Tổng 2 số nguyên");
            return a + b;
        }
        public static double Tong(double a, double b)
        {
            Console.WriteLine("Tổng 2 số thực");
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //khi goi hàm mà đã Overloading thì hệ thống
            //sẽ dựa trên kiểu dữ liệu số lượng tham số để gọi hàm tương ứng
            int t1 = Tong(10, 20);
            Console.WriteLine("t1 = " + t1);
            double t2 = Tong(20.0, 30.0);
            Console.WriteLine("t2 = " + t2);
        }
    }
}
