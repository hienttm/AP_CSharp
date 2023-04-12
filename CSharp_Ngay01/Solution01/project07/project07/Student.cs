using System;
namespace project07
{
	public class Student
	{
		string name;
		int age;
		public Student()
		{
			name = "";
			age = 0;
		}
		public Student(string name, int age)
		{
			this.name = name;
			this.age = age;
		}
		public void input()
		{
			Console.WriteLine("Input students info");
			Console.Write("Name:");
			name = Convert.ToString(Console.ReadLine());
			Console.Write("Age:");
			age = Convert.ToInt16(Console.ReadLine());

		}
		public void display()
		{
			Console.WriteLine("name: " + name + ", age:" + age);
		}
	}
}

