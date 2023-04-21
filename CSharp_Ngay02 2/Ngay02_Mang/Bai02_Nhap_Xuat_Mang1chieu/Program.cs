using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_Nhap_Xuat_Mang1chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[50];//khai báo mảng với 50 phần tử
            int n;
            do{
                Console.Write("Nhap so phan tu 1-50:");
                n = int.Parse(Console.ReadLine());
            } while (n<=0 || n > 50);
            Console.WriteLine("Nhap cac phan tu cua mang");
            for(int i = 0; i < n; i++) { //nhập n phần tử 0 đến n-1
                Console.Write("Phan tu thu {0} =", i+1);
                arr[i] = double.Parse(Console.ReadLine());
            }  
            Console.WriteLine("Cac phan tu cua mang la:");
            //foreach(double x in arr) //duyệt tất cả 50 phần tử
            for (int i = 0; i < n; i++){
                //Console.Write(x + "\t");
                Console.Write(arr[i] + "\t");
            }    
        }
    }
}
