namespace baithithu_Ngay10;
class Program
{
    static void Main(string[] args)
    {
        double tongthue=0;

        Product[] list = new Product[5];
        list[0] = new Book("B01", "Hello ", 100000);
        list[1] = new Book("B02", "Titanic", 555000);
        list[2] = new Book("B03", "Harry Porter", 1100000);
        list[3] = new Phone("P01", "Iphone 11", 18000000);
        list[4] = new Phone("P02", "Iphone 13", 25000000);

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("ProductId: {0}, Name: {1}, Price: {2}", list[i].productId, list[i].name, list[i].price);
            tongthue += list[i].computeTax();
        }
        Console.WriteLine("total tax of Book and Phone:" + tongthue);
        Console.ReadKey();
    }
}

