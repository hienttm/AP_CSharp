using System;
namespace baitapQuanLySinhVien
{
	public class Student
	{
		public String rollno;
		public String name;
		public float mark; 
		public Student()
		{
			rollno = "";
			name = "";
			mark = 0;
		}
		public Student(String rollno, String name, float mark)
		{
			this.rollno = rollno;
			this.name = name;
			this.mark = mark;
		}
		public void display()
		{
			Console.WriteLine("rollno: {0}, name: {1}, mark: {2}", rollno, name, mark);
		}
		public void input()
		{
			Console.WriteLine("Input rollno:");
			rollno = Console.ReadLine();
			Console.WriteLine("Input name: ");
			name = Console.ReadLine();
			Console.WriteLine("Input mark:");
			mark = float.Parse(Console.ReadLine());

		}


	}
}

