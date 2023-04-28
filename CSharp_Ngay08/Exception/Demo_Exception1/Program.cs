using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exception1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            try
            {
                Console.WriteLine("Nhập số nguyên:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("a = " + a);
            }
            catch(System.FormatException e)
            {
                Console.WriteLine("Lỗi:" + e.Message);
            }
            //lỗi vượt quá chỉ số mảng
            int[] arr = new int[] { 10,20,30};
            try
            {
                Console.WriteLine("phần tử thứ 4:" + arr[3]);
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine("Lỗi truy cập mảng");
            }
            Console.WriteLine("KẾT THÚC");
        }
    }
}
