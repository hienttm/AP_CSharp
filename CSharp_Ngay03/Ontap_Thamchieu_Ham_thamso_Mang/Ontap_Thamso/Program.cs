using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap_Thamso
{
    internal class Program
    {
        //cấu trúc của phương thức (hàm) tĩnh
        //static <kiểu trả về> Tên_Hàm (<các tham số>) { thân hàm }

        //xây dựng hàm tính tổng:
        //input: 2 số thực a,b
        //output: tổng của a+b là một số thực
        
        //a và b là tham số đầu vào (Formal parameter - tham số hình thức) của hàm
        //do hàm không cần thay đổi tham tham số thực (actual parameter) truyền cho hàm
        //nên tham số a,b được khai báo dạng tham trị
        static double TinhTong(double a, double b)//a,b: Formal parameter
        {
            return a + b;
        }
        //viết hàm Nhap() cho phép nhập 2 số double từ bàn phím
        //và trả về 2 giá trị đó lưu vào biến được khai báo ở nơi gọi hàm này (main)
        //do hàm phải trả về >1 giá trị nên phải sử dụng kỹ thuật tham chiếu
        static void Nhap(out double a,out double b)
        {
            Console.Write("Nhap so thu nhat:");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai:");
            b = Double.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            double x = 10;
            double y = 20;
            //khi gọi hàm phải truyền các giá trị từ biến, hằng, hoặc biểu thức
            //các giá trị, biến truyền vào gọi là Actual Parameter
            double tong1 = TinhTong(10.5, 5.5);//10.5, 5.5:các tham số thực
            double tong2 = TinhTong(x, 5.5);//x, 5.5: các tham số thực
            double tong3 = TinhTong(x, y);//x,y: các tham số thực
            //gọi hàm Nhap() để nhập x,y từ bàn phím
            Console.WriteLine("Nhap 2 so thuc:");
            Nhap(out x, out y);//truyền tham chiếu x cho a và y cho b 
            double tong4 = TinhTong(x, y);
            Console.WriteLine("Tong cua {0} + {1} = {2}", x, y, tong4);
        }
    }
}
