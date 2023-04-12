using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_Doituong
{
    internal class Program
    {
        static Person[] list = new Person[3];
        static int Timkiem(string key)
        {
            for (int i = 0; i < list.Length; i++)
            {
                //if(list[i].Hoten.Equals(key))
                if (list[i].Hoten.CompareTo(key) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Person person = new Person();
            //Console.WriteLine("Nhập Person:");
            //person.Nhap();
            //person.Hienthi();
            //khai báo và sử dụng mảng kiểu truyền thống
            int[] iarr = new int[10];//khi khởi tạo mảng là sử dụng được ngay
            
            //khai báo và khởi tạo mảng đối tượng
            //Person[] list = new Person[3];
            //khai báo và khởi tạo mảng 3 Person, nhưng mỗi phần tử là NULL

            //trước khi làm việc với mỗi phần tử của mảng đối tượng thì 
            //phải khởi tạo từng đối tượng Person cho mỗi phần tử của mảng
            //list[0] = new Person();//nếu không khởi tạo thì list[0] == NULL
            //Console.WriteLine("Nhập phần tử Person 0:");
            //list[0].Nhap();
            //list[0].Hienthi();
            Console.WriteLine("nhập mảng đối tượng bằng vòng lặp");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("Nhập phần tử Person {0}:",i+1);
                list[i] = new Person();
                list[i].Nhap();
            }
            Console.WriteLine("Hiển thị mảng");
            foreach(Person p in list)
            {
                p.Hienthi();
            }
            Console.Write("Nhap ten can tim:");
            string key = Console.ReadLine();
            int vitri = Timkiem(key);
            
            if (vitri >= 0)
                Console.WriteLine("Tìm thấy:" + list[vitri].Hoten);
            else
                Console.WriteLine("Không tìm thấy");
        }
    }
}
