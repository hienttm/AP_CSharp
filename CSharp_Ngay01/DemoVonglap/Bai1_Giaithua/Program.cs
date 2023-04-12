using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Giaithua
{
    internal class Program
    {
        static long TinhGiaithua(int n)
        {
            long giaithua;
            giaithua = 1;
            for(int i = 1; i <= n; i++)
            {
                giaithua *= i;
            }    
            return giaithua;
        }
        static void Main(string[] args)
        {
            int n;
            long ketqua;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Mời nhập số cần tính giai thừa:");
            n = Convert.ToInt32(Console.ReadLine());
            ketqua = TinhGiaithua(n);
            /*
            Nếu không khai báo hàm TinhGiaithua(n) là static 
            thì phải tạo đối tượng mới truy cập được hàm này
            
            ketqua = new Program().TinhGiaithua(n);
            
            Program pg = new Program();
            ketqua = pg.TinhGiaithua(n);
            */
            Console.WriteLine("Giai thừa = " + ketqua);
            Console.ReadKey();
        }
    }
}
