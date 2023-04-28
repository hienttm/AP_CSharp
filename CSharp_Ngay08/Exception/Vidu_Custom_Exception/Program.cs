using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu_Custom_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try {
                Product p1 = new Product();
                p1.Price = 10;
                Console.WriteLine("p1 :" + p1.Price);

                Product p2 = new Product();
                p2.Price = -10;
                Console.WriteLine("p2 :" + p2.Price);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi:" + ex.Message);
            }
        }
    }
}
