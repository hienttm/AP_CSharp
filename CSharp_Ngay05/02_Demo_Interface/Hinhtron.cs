using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
    public class Hinhtron:iHinh
    {
        public double bankinh;
        public Hinhtron()
        {
            bankinh = 0;
        }
        public Hinhtron(double r)
        {
            bankinh=r; 
        }
        public void hienthi()
        {
            Console.WriteLine("Hình tròn, bán kính: " + bankinh);
        }
        public double chuvi()
        {
            return 2*Math.PI*bankinh;
        }
        public double dientich()
        {
            return Math.PI * Math.Pow(bankinh,2);
        }
    }
}
