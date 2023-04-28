using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CustomException
{
    //tự định nghĩa lớp Excepition riêng
    public class InvalidPriceException: Exception
    {
        public InvalidPriceException(string message)
            :base(message)
        {

        }
    }
}
