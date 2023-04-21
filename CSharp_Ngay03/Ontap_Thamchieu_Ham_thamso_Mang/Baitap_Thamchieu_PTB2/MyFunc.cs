using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_Thamchieu_PTB2
{
    internal class MyFunc
    {
        //Hàm nhập 3 số
        public static void Nhap3so(out double a, out double b, out double c)
        {
            Console.Write("Nhập số a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số c: ");
            c = Convert.ToDouble(Console.ReadLine());
        }
        //Hàm giải pt bậc 2:
        //đầu vào là A,B,C dạng tham trị
        //đầu ra: x1, x2 dạng tham chiếu và return số nghiệm (0,1,2)
        public static int GiaiPTB2(double A, double B, double C, ref double x1, ref double x2)
        {
            double delta = B * B - 4 * A * C;
            if (delta < 0)
                return 0;
            else if (delta == 0)
            {
                x1 = x2 = -B / (2 * A);
                return 1;
            }
            else
            {
                x1 = (-B - Math.Sqrt(delta)) / (2 * A);
                x2 = (-B + Math.Sqrt(delta)) / (2 * A);
                return 2;
            }
        }
    }
}
