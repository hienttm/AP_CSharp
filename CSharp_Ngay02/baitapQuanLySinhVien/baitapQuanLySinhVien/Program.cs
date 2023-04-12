using System;

namespace baitapQuanLySinhVien;
class Program
{
    public static int inputInt()
    {
        int n;
        while (true)
        {
            try
            {
                n = int.Parse(Console.ReadLine());
                return n;
            }
            catch (Exception)
            {
                Console.WriteLine("Mời nhập số nguyên");
            }
        }
    }
    public static int menu()
    {
        int chon;

        Console.WriteLine("\n------MENU------");
        Console.WriteLine("Vui lòng chọn 1 mục:");
        Console.WriteLine("1.Add new StudentList");
        Console.WriteLine("2.Display contacts");
        Console.WriteLine("3.Sort by mark");
        Console.WriteLine("4.Find a contact by name ");
        Console.WriteLine("5.Exit");
        chon = inputInt();
        return chon;
    }
    static void Main(string[] args)
    {
        int chon;
        StudentList stlist = new StudentList();
        do
        {
            chon = menu();
            switch (chon)
            {
                case 1:
                    Console.WriteLine("Add new StudentList");
                    stlist.Input();
                    break;
                case 2:
                    Console.WriteLine("Display contacts");
                    stlist.Display();
                    break;
                case 3:
                    Console.WriteLine("3.Sort by mark:");
                    stlist.SortByMark();
                    Console.WriteLine("Danh sách sinh viên sau khi sắp xếp là:")
                    stlist.Display();
                    break;
                case 4:
                    Console.WriteLine("4.Find a contact by name ");
                    Console.WriteLine("Nhập tên cần tìm:");
                    String key = Console.ReadLine();
                    int k = stlist.Search(key);
                    if (k == -1)
                    {
                        Console.WriteLine("Không có sinh viên cần tìm.");
                    }
                    Console.WriteLine("Thông tin sinh viên cần tìm là: ");
                    stlist.list[k].display();
                    break;
                case 5:
                    Console.WriteLine("Kết thúc chương trình! ");
                    break;
                
            }
        } while (chon != 5);
    }
}

