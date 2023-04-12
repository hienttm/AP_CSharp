namespace baitap04;
class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("nhập số phẩn tử của mảng: ");
        n = Convert.ToUInt16(Console.ReadLine());
        double[] arr = new double[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("nhập phần tử thứ " + (i + 1) + " :");
            arr[i] = Convert.ToDouble(Console.ReadLine());

        }
        Console.WriteLine("hiển thị mảng: ");
        foreach(double d in arr)
        {
            Console.Write(d + "   ");
        }
        Console.WriteLine();
        //đếm các số âm:
        int dem = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                dem++;
                Console.WriteLine("phần thứ {0} có giá trị là {1} là số âm", (i+1), arr[i]);
            }
        }
        if (dem == 0)
        {
            Console.WriteLine("Mảng không có số âm nào");
        }
        else
            Console.WriteLine("Mảng có tất cả {0} số âm", dem);
        Console.ReadKey();
    }
}

