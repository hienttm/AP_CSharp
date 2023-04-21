using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu_Mang_1_chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a; //khai báo biến a là biến kiểu mảng số int
            a = new int[5];//cấp phát mảng 5 số int gán cho biến mảng a
            //khai báo biến mảng b kiểu double và cấp phát mảng 10 số thực gán cho biến mảng b
            double[] b = new double[10];
            //vừa cấp phát vừa khởi tạo các giá trị cho mảng
            int[] c = { 10, 20, 30, 40, 50 };
            //duyệt mảng sử dụng vị trí index
            Console.WriteLine("Cac phan tu cua mang:");
            for(int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
            //duyệt toàn bộ mảng sử dụng foreach
            //foreach (var item in collection)
            Console.WriteLine("Cac phan tu cua mang - forach:");
            foreach (var x in c)
            {
                Console.WriteLine(x);
            }
        }
    }
}
