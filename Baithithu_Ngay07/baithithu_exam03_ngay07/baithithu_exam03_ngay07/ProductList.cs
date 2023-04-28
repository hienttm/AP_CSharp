using System;
using System.Collections;

namespace baithithu_exam03_ngay07
{
	public class ProductList
	{
		List<Product> productList = new List<Product>();
		public ProductList()
		{
		}
		public void Input()
		{
			String res;
			while (true)
			{
				Product newProduct = new Product();
				newProduct.input();
				foreach(Product p in productList)
				{
					if (p.ProductId.CompareTo(newProduct.ProductId) == 0)
					{
						Console.WriteLine("ProductID này đã tồn tại, vui lòng nhập lại");
						break;
					}
                }
                productList.Add(newProduct);
				Console.WriteLine("Input thành công"); 
                Console.WriteLine("Tiếp tục?(c/k)");
                res = Console.ReadLine();
                if (res.CompareTo("k") == 0)
                {
                    break;
                }


            }
		}
		public void Display()
		{
			if (productList.Count == 0)
			{
				Console.WriteLine("List is Empty");

			}
			else
			{
				Console.WriteLine("ProductID         Product Name        Price");
				foreach(Product p in productList)
				{
					Console.WriteLine("{0}              {1}               ${2}",p.ProductId, p.Name, p.Price);
				}
			}
		}
		public void Delete()
		{
			string id;
			int dem = 0;
			Console.WriteLine("Nhập ProductID cần xoá:");
			id = Console.ReadLine();
            for (int i = 0; i < productList.Count; i++)
			{
                Product d = productList[i];
                if (d.ProductId.CompareTo(id) == 0)
				{
					dem++;
					productList.Remove(d);
				}
			}

			if (dem == 0)
			{
				Console.WriteLine("Không có productId này trong danh sách, vui lòng nhập lại");
			}
			else
			{
				Console.WriteLine("Xoá thành công");
			}
		}


	}
}

