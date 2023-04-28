using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu_Exception_Nhapso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n1;
            Console.WriteLine("Nhập số nguyên n1:");
            Utility.Tools.InputNumber(out n1);
            Console.WriteLine("n1 = " + n1);
            float n2;
            Console.WriteLine("Nhập số float n2:");
            Utility.Tools.InputNumber(out n2);
            Console.WriteLine("n2 = " + n2);
            double n3;
            Console.WriteLine("Nhập số double n3:");
            Utility.Tools.InputNumber(out n3);
            Console.WriteLine("n3 = " + n3);
        }
    }
}
