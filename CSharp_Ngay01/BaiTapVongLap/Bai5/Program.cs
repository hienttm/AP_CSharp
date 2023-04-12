using System;

namespace Bai5
{
  internal class Program
  {
    static bool KiemTraSoNguyenTo(int n)
    {
      bool result=true; //giả sử số n ban đầu là không nguyên tố
       
      for (int i = 2; i < (int)Math.Sqrt(n); i++)
      {
        if (n % i == 0)//nếu tìm thấy 1 ước > 2 thì n không phải là số nguyên tố
        {
            result = false;
            break;
        }
      }
      return result;
    }
    static bool KiemTraSoNguyenTo2(int n)
    {
       for (int i = 2; i < (int)Math.Sqrt(n); i++)//vòng lặp tìm ước trong khoảng 2  đến căn bậc 2 của n
        {
            if (n % i == 0)//nếu tìm thấy 1 ước > 2 thì n không phải là số nguyên tố
            {
                    return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Nhap n: ");
      int n = int.Parse(Console.ReadLine());
      if (KiemTraSoNguyenTo(n))
      {
        Console.WriteLine("{0} la so nguyen to", n);
      }
      else
      {
        Console.WriteLine("{0} khong phai la so nguyen to", n);
      }

    }
  }
}
