using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_TimMax
{
    internal class Program
    {
        static int Max()
        {
            int max = int.MinValue;
            while(true)
            {
                int n;
                Console.WriteLine("Nhap so nguyen khac 0:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
                    break;
                max = (max < n)? n : max;
            }    
            return max;
        }
        static void Main(string[] args)
        {
            int max = Max();
            Console.OutputEncoding = Encoding.UTF8;
            if (max == int.MinValue)
                Console.WriteLine("Chưa nhập giá trị cần tính");
            else
                Console.WriteLine("Max = " + max);
            Console.ReadKey();
        }
    }
}
