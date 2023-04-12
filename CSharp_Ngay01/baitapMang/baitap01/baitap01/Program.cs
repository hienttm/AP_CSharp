namespace baitap01;
class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Nhập số phẩn tử n của mảng (1-100):");
        n = Convert.ToInt16(Console.ReadLine());
        int[] arr = new int[n];
        int k = arr.Length;
        Console.WriteLine("mang co {0} phan tu", k);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Nhập phần tử thứ " + (i + 1) + " :");
            arr[i] = Convert.ToInt16(Console.ReadLine());
        }
        Console.WriteLine("Mảng trước khi sắp xếp là:");
        foreach (int d in arr)
        {
            Console.Write(d +"    ");
        }
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n ; j++)
            {
                if (arr[j] > arr[i])
                {
                    int temp;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        Console.WriteLine("Mảng trước khi sắp xếp là:");
        foreach (int d in arr)
        {
            Console.Write(d+"    ");
        }
        Console.ReadKey();
    }

}