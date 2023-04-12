namespace baitap02;
class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("nhập số phần tử của mảng: (1-100)");
        n = Convert.ToInt16(Console.ReadLine());
        double[] arr = new double[n];
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Nhập phần tử thứ " + (i + 1) + " :");
            arr[i] = Convert.ToDouble(Console.ReadLine());

        }
        Console.WriteLine("Mảng trước khi đảo là:");
        foreach(double d in arr)
        {
            Console.Write(d + "   ");
        }
        
        // đảo phần tử:
        
        
        for (int i = 0; i < n/2; i++)
        {
            int j = n - i-1;

            double temp;
            temp= arr[i];

            arr[i] = arr[j];
            arr[j] = temp;
        }
        Console.WriteLine("Mảng sau khi đảo là:");
        foreach (double d in arr)
        {
            Console.Write(d + "   ");
        }
        Console.ReadKey();
    }
}

