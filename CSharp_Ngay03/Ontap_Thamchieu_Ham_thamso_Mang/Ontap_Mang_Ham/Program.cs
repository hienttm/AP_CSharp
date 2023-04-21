using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap_Mang_Ham
{
    internal class Program
    {
        //viết chương trình nhập và hiển thị mảng sử dụng hàm:
        //Nhapmang(), Hienthimang(), Main(): sẽ gọi 2 hàm này
        
        //Hàm Nhapmang(): đầu vào tham chiếu tới mảng lưu các phần tử, trả về số phần tử
        static int Nhapmang(int[] a) 
        {
            int n;
            do
            {
                Console.Write("Nhap so phan tu (0-50):");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > 50);
            Console.WriteLine("Nhap cac phan tu:");
            for(int i=0; i<n; i++)
            {
                Console.Write("phan tu thu {0}: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            return n;
        }
        //Ham Hienthimang() đầu vào là biến mảng và số phần tử thực tế
        static void Hienthimang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
                
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[50];//khai báo mảng 50 phần tử
            int n; //số phần tử thực tế nhập
            Console.WriteLine("Nhap mang:");
            n = Nhapmang(arr);//mặc định biến mảng đã là tham chiếu
            Console.WriteLine("Hien thi mang:");
            Hienthimang(arr, n);
            Console.WriteLine();
        }
    }
}
