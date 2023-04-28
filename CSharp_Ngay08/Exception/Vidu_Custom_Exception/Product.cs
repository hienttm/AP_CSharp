using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu_Custom_Exception
{
    internal class Product
    {
        private int price;
        public int Price { 
                get { return price; } 
                set {
                    if(value<0)
                    {
                    throw new MyException("Lỗi giá <0");
                    }    
                    else
                        price = value; 
                } 
        }   
    }
}
