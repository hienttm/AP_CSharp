using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    internal class Tools
    {
        //hàm nhập số nguyên
        public static void InputNumber(out int n)
        {
            nhaplai:
            try
            {
                //Console.Write("Nhập số nguyên:");
                n = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("Phải nhập số nguyên");
                goto nhaplai;
            }
        }
        //hàm nhập số thực float
        public static void InputNumber(out float n)
        {
            nhaplai:
            try
            {
                //Console.Write("Nhập số float:");
                n = float.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Phải nhập số float");
                goto nhaplai;
            }
        }
        //hàm nhập số thực double
        public static void InputNumber(out double n)
        {
        nhaplai:
            try
            {
                //Console.Write("Nhập số double:");
                n = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Phải nhập số double");
                goto nhaplai;
            }
        }
    }
}
