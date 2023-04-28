using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("danh sách StudentList1 không sử dụng indexer");
            StudentList1 list1 = new StudentList1();
            //list1[0].assgin(1, "A");  chưa khai báo Indexer cho lớp này
            //list1.list[0].assgin(1, "A");
            //list1.list[1].assgin(2, "B");
            list1.get(0).assgin(1, "A");
            list1.get(1).assgin(2, "B");
            //hiển thị
            //list1.list[0].display();
            //list1.list[1].display();
            list1.get(0).display();
            list1.get(1).display();

            Console.WriteLine("danh sách StudentList2 sử dụng indexer");
            StudentList2 list2 = new StudentList2();
            list2[0].assgin(3, "C"); //list2.list[0].assgin(3, "C");
            list2[1].assgin(4, "D");
            //hiển thị
            list2[0].display();
            list2[1].display();

        }
    }
}
