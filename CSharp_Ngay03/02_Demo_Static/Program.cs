using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //ở một lớp khác muốn truy cập vào thành phần static thì 
            //sử dụng cú pháp: Tenlop.TenThanhphan_static (không cần tạo đối tượng)
            Taikhoan.laisuat = 0.2;
            Taikhoan.hienthistatic();
            //các thành phần không phải static thì phải tạo đối tượng
            //và truy cập qua biến tham chiếu tới đối tượng
            Taikhoan tkA = new Taikhoan("TK-A", 1000000);
            Taikhoan tkB = new Taikhoan("TK-B", 2000000);
            tkA.hienthi();
            Console.WriteLine("Tiền lãi của tài khoản " + tkA.sotk +":");
            Console.WriteLine(tkA.sodu * Taikhoan.laisuat);
            tkB.hienthi();
            Console.WriteLine("Tiền lãi của tài khoản " + tkB.sotk + ":");
            Console.WriteLine(tkB.sodu * Taikhoan.laisuat);
        }
    }
}
