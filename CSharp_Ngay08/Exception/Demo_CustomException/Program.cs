using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Product p1 = new Product();
                p1.Price = 10;
                Console.WriteLine("Price of p1:" + p1.Price);
                Product p2 = new Product();
                p2.Price = -1;
                Console.WriteLine("Price of p2:" + p2.Price);
            }
            catch (InvalidPriceException ex) {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Kết thúc!");
        }
    }
}
