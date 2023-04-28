using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baikkiemtra2
{
    internal class Program
    {
        public static int Menu()
        {
            int choice;
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("1. Add  product records");
            Console.WriteLine("2. Display  product records");
            Console.WriteLine("3. Delete  product by Id");
            Console.WriteLine("4. Exit");
            do { 
                Console.Write("Input your choice:");
                choice = int.Parse(Console.ReadLine());
            }while(choice<1 ||choice>4);//nếu <1 hoặc >4 thì nhập lại
            return choice;
        }
        static void Main(string[] args)
        {
            int choice;
            ProductList Products = new ProductList();
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Products.InputProducts();
                        break;
                    case 2:
                        Products.DisplayProducts();
                        break;
                    case 3:
                        Console.WriteLine("Delete Prduct by id");
                        Products.DeleteById();
                        break;
                    case 4:
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        Console.WriteLine("Input 1-4!");
                        break;
                }
                Console.WriteLine("Press any key to continues");
                Console.ReadKey();
            } while (choice != 4);//nếu choice==4 thì thoát
        }
    }
}
