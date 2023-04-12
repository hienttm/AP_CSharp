using System;

namespace Bai3
{
  internal class Program
  {
    static int UocChungLonNhat(int a, int b)
    {
      int uoc = 1;
      int min = a < b ? a : b;
      for (int i = 1; i <= min; i++)
      {
        if (a % i == 0 && b % i == 0)
        {
          uoc = i;
        }
      }
      return uoc;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Nhap a: ");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap b: ");
      int b = int.Parse(Console.ReadLine());
      Console.WriteLine("Uoc chung lon nhat cua {0} va {1} la: {2}", a, b, UocChungLonNhat(a, b));
    }
  }
}
