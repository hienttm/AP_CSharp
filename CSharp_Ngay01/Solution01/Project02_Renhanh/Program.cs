using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_Renhanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.OutputEncoding = Encoding.UTF8; 
            Console.Write("Nhập số nguyên:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 1)
                Console.WriteLine("Số " + n + " là số lẻ");
            else
                Console.WriteLine("Số {0} là số chẵn", n);
            Console.ReadKey();//dừng màn hình đợi nhấn phím bất kỳ
        }
    }
}
