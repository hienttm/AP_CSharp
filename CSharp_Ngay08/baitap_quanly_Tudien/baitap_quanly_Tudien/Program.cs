namespace baitap_quanly_Tudien;
class Program
{
    public static int Menu()
    {
        int chon;
        Console.WriteLine("------Menu----");
        Console.WriteLine("1.Thêm từ mới");
        Console.WriteLine("2. Hiển thị toàn bộ");
        Console.WriteLine("3. Tra từ");
        Console.WriteLine("4. Sửa từ");
        Console.WriteLine("5. Xóa từ");
        Console.WriteLine("6. Thoát");
        chon = int.Parse(Console.ReadLine());
        return chon;
    }
    static void Main(string[] args)
    {
        int chon;
        Tudien didictionary = new Tudien();

        do
        {
            chon = Menu();
            switch (chon)
            {
                case 1:
                    didictionary.inputlist();
                    break;
                case 2:
                    didictionary.displaylist();
                    break;

            }
        }while(chon!=6);
        

    }
}

