using System;

namespace Bai2
{
  internal class Program
  {
    static int Max()
    {
      int max = int.MinValue; //max gán bằng số nguyên nhỏ nhất
            
      while (true)
      {
        Console.WriteLine("nhap n (khac 0):");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n == 0)
            break;
        max = (n > max) ? n : max;        
      }
      return max;
    }
    static void Main(string[] args)
    {
         Console.WriteLine("So lon nhat trong cac so da nhap la: {0}", Max());
    }
  }
}
