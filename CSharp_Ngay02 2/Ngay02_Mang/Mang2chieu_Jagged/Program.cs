using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang2chieu_Jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mảng 2 chiều kiểu Jagged là dạng có số cột trên mỗi dòng khác nhau
            int[][] mangJagged = new int[2][];
            mangJagged[0] = new int[] { 1, 2, 4 };
            mangJagged[1] = new int[] { 1, 2, 4, 5, 6 };
            Console.WriteLine("mang co " + mangJagged.Length + " dong");
            Console.WriteLine("Dong 0 co " + mangJagged[0].Length + " cot");
            Console.WriteLine("Dong 1 co " + mangJagged[1].Length + " cot");
            //i lặp từng dòng 0,1
            for (int i=0; i <mangJagged.Length; i++)
            {
                //j lặp từng cột của dòng i
                for(int j=0; j <mangJagged[i].Length; j++)
                {
                    Console.Write(mangJagged[i][j] + "\t");                  
                }    
                Console.WriteLine();
            }    
        }
    }
}
