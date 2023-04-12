using System;

namespace Bai1
{
  internal class Program
  {

    static double GiaiThua(int n)
    {
      double result = 1;
      for (int i = 1; i <= n; i++)
      {
        result *= i;
      }
      return result;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Nhap n: ");
      int n = int.Parse(Console.ReadLine());
      Console.WriteLine("Giai thua cua {0} la: {1}", n, GiaiThua(n));
    }
  }
}
