

namespace Project04_Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cú pháp khai báo mảng:kieudl[] tenbienmang = new kieudl[sophantu];
            double[] arr = new double[3];//khai báo mảng 3 số thực double
            //nhập mảng từ bàn phím
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Phan tu thu " + (i + 1) + ":");
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            //hiển thị từng phần tử của mảng
            Console.WriteLine("Cac phan tu cua mang la:");
            foreach (double d in arr)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}
