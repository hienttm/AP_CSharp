namespace baitap03;
class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("nhập số phần tử của mảng:(1-100) ");
        n = Convert.ToUInt16(Console.ReadLine());
        int[] arr = new int[n];
        for (int i=0; i < arr.Length; i++)
        {
            Console.WriteLine("nhập phần tử thứ " + (i + 1) + ":");
            arr[i] = Convert.ToInt32(Console.ReadLine());

        }
        // in mang
        Console.WriteLine("Hiển thị mảng: ");
        foreach(int d in arr)
        {
            Console.Write(d + "   ");
        }
        int tong = 0;
        for (int i=0;i<arr.Length; i++)
        {
            if (arr[i] % 2 == 1)
            {
                tong += arr[i];
            }
        }
        if (tong == 0)
        {
            Console.WriteLine("mảng không có số lẻ");
        }
        else
            Console.WriteLine("tổng các số lẻ trong mảng là: " + tong);
        Console.ReadKey();
    }
}

