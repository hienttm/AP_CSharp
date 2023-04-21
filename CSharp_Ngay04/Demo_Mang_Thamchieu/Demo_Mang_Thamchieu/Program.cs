using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Mang_Thamchieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kiểu dữ liệu nguyên thủy được truy luôn
            int x;
            x = 10;
            //kiểu class và interface là kiểu dữ liệu tham chiếu
            Student a; // biến a = null
            //phải khởi tạo đối tượng Student gán cho biến a
            a = new Student();
            Console.WriteLine("Nhập sinh viên a:");
            a.input();//nhập sinh viên

            Student b = a; //biến b cùng tham chiếu tới đối tượng của biến a
            b.Name = "B"; //b thay đổi thuộc tính của đối tượng thì a cũng thay đổi
            Console.WriteLine("Thông tin a:");
            a.display();

            //Mảng đối tượng
            Student[] arr = new Student[2];//tạo mảng 2 phần tử kiểu Student
            //chưa được khởi tạo thì 2 phần tử của mảng  =  null
            //(chưa tham chiếu đến đối tượng nào)
            //phải khởi tạo đối tượng Student gán cho từng phần tử tham chiếu tới
            arr[0] = new Student();
            arr[0].Id = 2;
            arr[0].Name = "B";
            Console.WriteLine("Thông tin arr[0]:");
            arr[0].display();

            Console.ReadKey();
        }
    }
}
