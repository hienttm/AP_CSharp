using System;
namespace baitap_quanly_Tudien
{
	public class Tudien
	{
		Dictionary<string,string> tudien = new Dictionary<string,string>();
		
		public Tudien()
		{
		}
		public void inputlist()
		{
			while (true)
			{
				string tienganh, tiengviet;
				Console.WriteLine("Nhập từ Tiếng Anh:");
				tienganh = Console.ReadLine();
                if (tudien.ContainsKey(tienganh))
                {
                    Console.WriteLine("Từ này đã tồn tại trong từ điển, vui lòng nhập !");
                }
				else
				{
					Console.WriteLine("Nhập tử tiếng Việt:");
					tiengviet = Console.ReadLine();
					tudien.Add(tienganh,tiengviet);
					Console.WriteLine("Thêm thành công");
                    Console.WriteLine("Tiếp tục nhập? (c/k)");
                    string temp = Console.ReadLine();
                    if (temp == "k")
                    {
                        break;
                    }
                }

            }

		}
		public void displaylist()
		{
			if (tudien.Count == 0)
			{
				Console.WriteLine("Từ điển rỗng!");
			}
			else
			{
				foreach(var key in tudien.Keys)
				{
					Console.WriteLine(key + " : " + tudien[key]);
				}
			}
		}

	}
}

