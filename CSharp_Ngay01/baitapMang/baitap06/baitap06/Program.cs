namespace baitap06;
class Program
{
    static void Main(string[] args)
    {
        int n;
        do
        {
            Console.WriteLine("nhập số phẩn tử của mảng:(1-100) ");
            n = int.Parse(Console.ReadLine());

        } while (n<1 || n > 100);
        
        double[] arr = new double[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("nhập phần tử thứ " + (i + 1) + " :");
            arr[i] = Convert.ToDouble(Console.ReadLine());

        }
        Console.WriteLine("hiển thị mảng: ");
        foreach (double d in arr)
        {
            Console.Write(d + "   ");
        }
        Console.WriteLine();
        //tìm số nhỏ nhất trong mảng:
        double min = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.WriteLine("số nhỏ nhất trong mảng là: " + min);
        Console.ReadKey();
    }
}

