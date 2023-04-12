namespace project07;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Student student1 = new Student();
        student1.input();
        student1.display();
        Console.ReadKey();
    }
}

