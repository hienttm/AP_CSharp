﻿using System;
namespace baitapQuanLySinhVien
{
	public class StudentList
	{
		public Student[] list =new Student[10];
		public int n;
		
		public StudentList()
		{

		}
		public void Input()
		{
			do
			{
				Console.WriteLine("Nhập số lượng sinh viên (1-10):");
				n = int.Parse(Console.ReadLine());
			} while (n < 1 || n > 10);
			
			for (int i = 0; i < n; i++)
			{
				//Student newstudent = new Student();
				//newstudent.input();
				//list[i] = newstudent;
				Console.WriteLine("Nhập sinh viên thứ {0}:", (i + 1));
				list[i]=new Student();
				list[i].input();

			}
		}
		public void Display()
		{
			if (n <= 0)
			{
				Console.WriteLine("Chưa nhập sinh viên nào");
			}
			for(int i = 0; i < n; i++)
			{
				Console.WriteLine("thông tin Sinh viên thứ {0} là: ", (i + 1));
				list[i].display();
			}
		}
		public void SortByMark()
		{
			Student temp = new Student();
			for (int i = 0; i <n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					if (list[i].mark < list[j].mark)
					{
						temp = list[i];
						list[i] = list[j];
						list[j] = temp;

					}
				}
			}
		}
        public int Search(string key)
		{
			//Console.WriteLine("Vui lòng nhập họ tên sinh viên cần tìm:");
			//key = Console.ReadLine();
			for(int i = 0; i < n; i++)
			{
				if (list[i].name.CompareTo(key)==0)
				{
					return i;
				}
			}
			return -1;

		}
    }
}

