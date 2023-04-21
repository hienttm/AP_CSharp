using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
    public class Hinhchunhat:iHinh
    {
        public double dai;
        public double rong;
        public Hinhchunhat()
        {
            dai = rong = 0;
        }
        public Hinhchunhat(double d, double r)
        {
            dai = d;
            rong = r;
        }
        public void hienthi()
        {
            Console.WriteLine("Hình chữ nhật, dài: " + dai + ", rộng: " + rong);
        }
        public double chuvi()
        {
            return (dai + rong)*2;
        }
        public double dientich()
        {
            return dai * rong;
        }
    }
}
