namespace baitap07;
class Program
{
    static void Main(string[] args)
    {
        int n;
        do
        {
            
            Console.WriteLine("nhập số phần tử của mảng:");
            n = Convert.ToUInt16(Console.ReadLine());

        } while (n < 1 || n > 100);
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("nhập phẩn tử thứ " + (i + 1) + " :");
            arr[i] = Convert.ToInt32(Console.ReadLine());

        }
        // hiển thị mảng:
        Console.WriteLine(" hiển thị mảng: ");
        foreach(int d in arr)
        {
            Console.Write(d + "   ");

        }
        Console.WriteLine();
        // tim số chính phương
        int dem = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j<= arr[i]; j++)
            {
                
                if (j*j == arr[i])
                {
                    
                    dem++;
                    Console.WriteLine("phần tử thứ {0} có giá trị là {1} là số chính phương", i + 1, arr[i]);
                }
            }
        }
        if (dem == 0)
        {
            Console.WriteLine("mảng trên không có số chính phương");
        }
        else
            Console.WriteLine("Mảng trên có tất cả {0} số chính phương", dem);
        Console.ReadKey();

    }
}

