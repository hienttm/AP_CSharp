using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_Thamchieu_PTB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //để hiển thị Unicode (tiếng việt có dấu) ở màn hình kết quả
            Console.OutputEncoding = Encoding.UTF8;
            double a, b, c, n1=0, n2=0;
            int ketqua;
            Console.WriteLine("Nhập các hệ số A, B, C:");
            MyFunc.Nhap3so(out a, out b, out c);
            ketqua = MyFunc.GiaiPTB2(a, b, c, ref n1, ref n2);
            if (ketqua == 0)
                Console.WriteLine("Phương trình vô nghiệm");
            else if (ketqua == 1)
                Console.WriteLine("Phương trình có nghiệm kép: x1=x2= " + n1);
            else
                Console.WriteLine("Phương trình có 2 nghiệm: x1 = {0}, x2 = {1}", n1, n2);
        }
    }
}
