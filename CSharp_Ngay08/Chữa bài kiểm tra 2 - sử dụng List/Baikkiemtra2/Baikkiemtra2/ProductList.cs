using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baikkiemtra2
{
    internal class ProductList
    {
        private List<Product> list;
        public ProductList()
        {
            list = new List<Product>();
        }
        public List<Product> List { get { return list; } }
        public void InputProducts()
        {
            Console.WriteLine("Input Products:");
            string Continue="Y";
            do
            {
                Product product = new Product();
                product.Input();
                list.Add(product);
                Console.WriteLine("Continue? (Y/N):");
                Continue = Console.ReadLine();
            } while (Continue == "Y" || Continue == "y");
        }
        public void DisplayProducts()
        {
            Console.WriteLine("Product ID   Product Name   Price");
            foreach (Product product in list)
                product.Display();
        }
        private int IndexOf(string id)
        {
            for(int i=0; i<list.Count; i++)
            {
                if(List[i].Id == id)//nếu thấy id sản phẩm thì trả về vị trí
                {
                    return i;
                }    
            }    
            return -1;//nếu không tìm thấy id của sản phẩm
        }
        public void DeleteById()
        {
            string id;
            Console.Write("id of Product:");
            id = Console.ReadLine();
            int index = IndexOf(id);//tìm vị trí của Productu có id này
            if (index <0)
                Console.WriteLine("Not found!");
            else
            {
                list.RemoveAt(index);
                Console.WriteLine("Product id={0} deleted!", id);
            }    
                
            
        }
    }
}
