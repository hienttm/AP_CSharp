using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_giaodien
{
    internal class HinhCN:iHinh
    {
        private double dai;
        private double rong;

        public HinhCN(double dai, double rong)
        {
            this.Dai = dai;
            this.Rong = rong;
        }

        public double Dai { get => dai; set => dai = value; }
        public double Rong { get => rong; set => rong = value; }
        public void hienthi()
        {
            Console.WriteLine("Hình chữ nhật:");
            Console.WriteLine("Dài:" + dai + ", Rộng: " + rong);
        }
        public double chuvi()
        {
            return (dai + rong) * 2;
        }
        public double dientich()
        {
            return dai * rong;
        }
    }
}
