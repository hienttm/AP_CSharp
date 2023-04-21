using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang2chieu_Regtangular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khai bao mang hinh chu nhat 2 chieu
            int[,] mang2chieu = new int[2, 3];

            mang2chieu[0, 0] = 1;
            mang2chieu[0, 1] = 1;
            mang2chieu[0, 2] = 1;
            mang2chieu[1, 0] = 1;
            mang2chieu[1, 1] = 1;
            mang2chieu[1, 2] = 1;
            string[,] str = { { "a1", "a2" }, { "a3", "a4" } };
            string[,,] str3chieu = new string[3, 2, 2] { { { "a1", "a2" }, { "a1", "a2" } }, { { "a1", "a2" }, { "a1", "a2" } }, { { "a1", "a2" }, { "a1", "a2" } } };
            str3chieu[1, 1, 1] = "a";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine("str3chieu[{0},{1},{2}]={3}", i, j, k, str3chieu[i, j, k]);
                    }
                }
            }
            Console.Read();
        }
    }
}
