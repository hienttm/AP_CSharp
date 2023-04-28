using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baikkiemtra2
{
    internal class Product
    {
        private string id;
        private string name;
        private int price;
        //constructor
        public Product()
        {
        }
        public Product(string id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        //Properties
        public string Id {
            get { return id; }
            set { this.id = value; }
            }
        public string Name
        {
            get { return name; }
            set
            {
                this.name = value;
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                this.price = value;
            }
        }
        public void Input()
        {
            Console.Write("id:");
            id = Console.ReadLine();
            Console.Write("name:");
            name = Console.ReadLine();
            Console.Write("price");
            price = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            String str = string.Format("{0,-13}{1,-15}{2,-5}", id,name,price);
            Console.WriteLine(str);
        }
    }
}