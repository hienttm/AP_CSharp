namespace baithithu_exam02_ngay07;
class Program
{
    static void Main(string[] args)
    {
        Lion lion2 = new Lion();
        lion2.SetMe("hien", 32);
        lion2.Show();

        Tiger tiger1 = new Tiger();
        tiger1.SetMe("tiger 11", 87);
        Console.ReadKey();
    }
}

