using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtility;
using Baitap2;
namespace Baitap_Interface2_Car
{
    internal class Program
    {
        static int Menu()
        {
            int choice;
            Console.WriteLine("----- MENU ------");
            Console.WriteLine("1.Input \n2.Display \n3.Sort by price");
            Console.WriteLine("4.Search by Model \n5.Exit");
            Console.Write("Input your choice (1-5):");
            Tools.InputNumber(out choice);
            return choice;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            VehiclesManager vMan = new VehiclesManager();
            int choice;
            do
            {
                Console.Clear();//xóa màn hình trước khi hiện menu
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Input Vehicles");
                        vMan.input();
                        break;
                    case 2:
                        Console.WriteLine("Display Vehicles");
                        vMan.display();
                        break;
                    case 3:
                        Console.WriteLine("Sort by Price");
                        Console.WriteLine("Before sorting");
                        vMan.display();
                        vMan.sortbyprice();
                        Console.WriteLine("After sorting");
                        vMan.display();
                        break;
                    case 4:
                        Console.WriteLine("Search by model");
                        break;
                    case 5:
                        Console.WriteLine("Good bye! See you again!");
                        break;
                    default:
                        Console.WriteLine("your choice is invalid!");
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();//dừng màn hình để xem kết quả, nhập 1 phím để tiếp tục
            } while (choice != 5);//chọn = 5 thì thoát khỏi vòng lặp
            Console.WriteLine("Finish....!");
        }
    }
}
