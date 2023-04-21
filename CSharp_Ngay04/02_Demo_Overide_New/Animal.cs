using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class Animal
    {
        public void SayHello1()
        {
            Console.WriteLine("Hello1 Animal");
        }
        public virtual void SayHello2()
        {
            Console.WriteLine("Hello2 Animal");
        }
    }
}
