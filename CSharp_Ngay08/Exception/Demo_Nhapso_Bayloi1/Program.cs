using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Nhapso_Bayloi1
{
    internal class Program
    {
        static int InputIntNumber()
        {
            int n;
            nhapso: //khai báo 1 nhãn (label)
            try{
                Console.Write("Nhập số nguyên:");
                n = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Phải nhập số nguyên");
                goto nhapso;//nhảy tới dòng có nhãn "nhapso:"
            }
            return n;
        }
        static double InputDoulbeNumber()
        {
            double n;
            nhapso: //khai báo 1 nhãn (label)
            try {
                Console.Write("Nhập số thực:");
                n = double.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Phải nhập số thực");
                goto nhapso;//nhảy tới dòng có nhãn "nhapso:"
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            a = InputIntNumber();
            Console.WriteLine("a = " + a);
            double b;
            b = InputDoulbeNumber();
            Console.WriteLine("b = " + b);
        }
    }
}
