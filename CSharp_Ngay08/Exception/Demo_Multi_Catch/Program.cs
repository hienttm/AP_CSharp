using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Multi_Catch
{
    internal class Program
    {
        //chương trình nhập 2 số nguyên in ra thương
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b, thuong;
            try
            {
                Console.WriteLine("a = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("b = ");
                b = int.Parse(Console.ReadLine());
                thuong = a / b;
                Console.WriteLine("Thương = " + thuong);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Lỗi nhập số:" + ex.Message);
            }
            catch(System.DivideByZeroException ex) 
            { 
                Console.WriteLine("Lỗi chia 0:" + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Có lỗi ngoại lệ:" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Tiếp tục....");
            }
        }
    }
}
