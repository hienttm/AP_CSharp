

namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            Console.WriteLine("Hello CSharp!");
            Console.WriteLine("Lập trình Ngôn ngữ C#");
            
            string hoten;
            Console.WriteLine("Mời nhập họ tên:");
            hoten = Console.ReadLine();
            Console.WriteLine("Xin chào: " + hoten);
            Console.WriteLine("Xin chào: {0}", hoten);
            int tuoi;
            Console.Write("Nhập tuổi:");
            tuoi = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Bạn {0} năm {1} tuổi", hoten, tuoi);
        }
    }
}
