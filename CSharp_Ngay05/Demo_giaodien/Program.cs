using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_giaodien
{
    internal class Program
    {
        static void Work(iHinh hinh)
        {
            hinh.hienthi();
            Console.WriteLine("Diện tích: " + hinh.dientich());
            Console.WriteLine("Chu vi: " + hinh.chuvi());
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //iHinh hinh = new iHinh();
            HinhCN hcn = new HinhCN(20, 10);
            Work(hcn);
        }
    }
}
