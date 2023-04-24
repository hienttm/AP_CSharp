namespace baithithu_exam02_ngay07;
class Program
{
    static void Main(string[] args)
    {
        Lion lion1 = new Lion();
        lion1.SetMe();
        lion1.Show();

        Tiger tg1 = new Tiger();
        tg1.SetMe();
        tg1.Show();

        Console.ReadKey();
    }
}

