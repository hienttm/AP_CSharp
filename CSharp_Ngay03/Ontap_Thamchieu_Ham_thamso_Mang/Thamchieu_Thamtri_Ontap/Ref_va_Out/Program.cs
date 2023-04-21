using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_va_Out
{
    internal class Program
    {
        //out để khai báo tham số dạng tham chiếu
        //tham số a truyền vào không cần phải khởi tạo
        //bên trong hàm bắt buộc phải gán giá trị cho tham số
        static void NhapSo(out int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Nhap so a = ");
            NhapSo(out a);
            Console.WriteLine("So a = " + a);
        }
    }
}
