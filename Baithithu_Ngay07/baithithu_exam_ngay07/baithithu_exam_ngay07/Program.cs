namespace baithithu_exam_ngay07;
class Program
{
    static void Main(string[] args)
    {
        Cylinder hinh1 = new Cylinder();
        hinh1.Nhap();
        hinh1.Hienthi();
        hinh1.Process();
        hinh1.Result();
        
        Cylinder hinh2 = new Cylinder();
        hinh2.Radius = 43;
        hinh2.Height = 76;
        hinh2.Process();
        hinh2.Result();
        Console.ReadKey();
    }
}

