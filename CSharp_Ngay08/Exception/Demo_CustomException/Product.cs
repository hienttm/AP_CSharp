using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CustomException
{
    internal class Product
    {
        private int price;
        public int Price
        {
            get { return price; }   
            set {
                if (value < 0)//nếu giá gán vào <0 thì đẩy ra lỗi ngoại lệ
                    throw new InvalidPriceException("Lỗi giá <0");
                else
                    price = value; 
            }    
        }
    }
}
