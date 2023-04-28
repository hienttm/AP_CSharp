using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu_Custom_Exception
{
    internal class MyException : Exception
    {
        public string mymessage;
        public MyException(string message) : base(message)
        {
            mymessage = message;
        }

    }
}
