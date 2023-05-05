namespace baithithu_Ngay10;
class Program
{
    static void Main(string[] args)
    {
        double totalBookTax=0;
        double totalPhoneTax = 0;
        Product[] list = new Product[5];
        list[0] = new Book("B01", "Hello ", 100000);
        list[1] = new Book("B02", "Titanic", 555000);
        list[2] = new Book("B03", "Harry Porter", 1100000);
        list[3] = new Phone("P01", "Iphone 11", 18000000);
        list[4] = new Phone("P02", "Iphone 13", 25000000);

        foreach(Product product in list)
        {
            if(product is Book)
            {
                totalBookTax += product.computeTax();
            }else if(product is Phone)
            {
                totalPhoneTax += product.computeTax();
            }
        }
        Console.WriteLine("Total tax of Book:" + totalBookTax);
        Console.WriteLine("Total tax of Phone:" + totalPhoneTax);
        Console.ReadKey();
    }
}

