using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Nhapso1
{
    internal class Program
    {
        static int InputNumber()
        {
            int n=0;
            try
            {
                Console.Write("Nhập số nguyên:");
                n = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                //đẩy ra bên ngoài để nơi gọi hàm tiếp tục try..catch
                throw new System.FormatException();
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            try { 
                a = InputNumber();
                Console.WriteLine("a = " + a);
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Lỗi:" + e.Message);
            }
        }
    }
}
