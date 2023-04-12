namespace baitap05;
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
        foreach (double d in arr)
        {
            Console.Write(d + "   ");
        }
        Console.WriteLine();
        //tìm số lớn nhất
        double max = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("số lớn nhất trong các số đã nhập là: " + max);
        Console.ReadKey();
    }
}

