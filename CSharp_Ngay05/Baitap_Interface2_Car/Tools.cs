using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtility
{
    public class Tools
    {
        //nạp chồng (overload) 3 hàm cùng tên InputNumber
        public static void InputNumber(out int n)
        {
            nhapso:
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Lỗi nhập số nguyên");
                goto nhapso;
            }
        }
        public static void InputNumber(out float n)
        {
        nhapso:
            try
            {
                n = float.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Lỗi nhập số thực float");
                goto nhapso;
            }
        }
        public static void InputNumber(out double n)
        {
        nhapso:
            try
            {
                n = double.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Lỗi nhập số thực double");
                goto nhapso;
            }
        }
    }
}
