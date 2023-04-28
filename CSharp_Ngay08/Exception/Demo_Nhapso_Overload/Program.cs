using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
namespace Demo_Nhapso_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n1;
            Console.Write("Nhập số nguyên:");
            Tools.InputNumber(out n1);//gọi hàm InputNumber(int)
            Console.WriteLine("n1 = " + n1);
            float n2;
            Console.Write("Nhập số thực:");
            Tools.InputNumber(out n2); //gọi hàm InputNumber(float)
            Console.WriteLine("n2 = " + n2);
            double n3;
            Console.Write("Nhập số thực:");//gọi hàm InputNumber(double)
            Tools.InputNumber(out n3);
            Console.WriteLine("n3 = " + n3);
        }
    }
}
