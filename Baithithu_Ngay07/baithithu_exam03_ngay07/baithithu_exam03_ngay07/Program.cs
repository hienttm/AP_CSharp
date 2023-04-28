namespace baithithu_exam03_ngay07;
class Program
{
    public static int inputInt()
    {
        int n;
        while (true)
        {
            try
            {
                n = int.Parse(Console.ReadLine());
                return n;
            }
            catch (Exception)
            {
                Console.WriteLine("Mời nhập số nguyên");
            }
        }
    }
    public static int Menu()
    {
        int chon;
        Console.WriteLine("-----Menu-----");
        Console.WriteLine("Vui lòng chọn 1 mục (1-4):");
        Console.WriteLine("1.Add Products records");
        Console.WriteLine("2.Display Products records ");
        Console.WriteLine("3.Delete product by Id");
        Console.WriteLine("4.Exit");
        
        chon = inputInt();
        return chon;
    }
    static void Main(string[] args)
    {
        ProductList list = new ProductList();
        int chon;
        do
        {
            chon = Menu();
            switch (chon)
            {
                case 1:
                    list.Input();
                    break;
                case 2:
                    list.Display();
                    break;
                case 3:
                    list.Delete();
                    break;
                case 4:
                    Console.WriteLine("Kết thúc chương trình!");
                    break;
                default:
                    Console.WriteLine("Vui lòng chọn từ (1-4) ");
                    break;
            }
        } while (chon != 4);
    }
}

