using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03_Vonglap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi du von lap for");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("i = " + i);
            }
            Console.WriteLine("Vi du break");
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine("i = " + i);
            }
            Console.WriteLine("Vi du continue");
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine("i = " + i);
            }
            Console.ReadKey();
        }
    }
}
