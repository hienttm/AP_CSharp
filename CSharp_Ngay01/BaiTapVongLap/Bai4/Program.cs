using System;

namespace Bai4
{
  internal class Program
  {
    static int UocChungLonNhat(int a, int b, int c)
    {
      int uoc = 1;
      int min = a < b ? a : b;
      min = min < c ? min : c;
      for (int i = 1; i <= min; i++)
      {
        if (a % i == 0 && b % i == 0 && c % i == 0)
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
      Console.WriteLine("Nhap c: ");
      int c = int.Parse(Console.ReadLine());
      Console.WriteLine("Uoc chung lon nhat cua {0}, {1} va {2} la: {3}", a, b, c, UocChungLonNhat(a, b, c));
    }
  }
}
