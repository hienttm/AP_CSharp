using System;

namespace baitap_Tinhluong_Abstract;
class Program
{
    static void Main(string[] args)
    {
        //Nhanvienkinhdoanh nv1 = new Nhanvienkinhdoanh();
        //nv1.Nhap();
        //nv1.Hienthi();
        //Console.WriteLine("Lương nhân viên 1 là:" + nv1.Tinhluong());
        //NhanvienKythuat nv2 = new NhanvienKythuat();
        //nv2.Nhap();
        //nv2.Hienthi();
        //Console.WriteLine("Lương nhân viên 2 là:" + nv2.Tinhluong());
        //Console.ReadKey();

        Nhanvien[] list = new Nhanvien[10];
        //nhập mảng
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Mời nhập nhân viên thứ " + (i + 1));
            int check;
            do
            {
                Console.WriteLine("Nếu là nhân viên kinh doanh mời nhập 1, nhân viên kỹ thuật mời nhập 2");
                check = int.Parse(Console.ReadLine());
            } while (check != 1 && check != 2);
            if (check == 1)
            {
                list[i] = new Nhanvienkinhdoanh();

            }
            else
            {
                list[i] = new NhanvienKythuat();
            }
            list[i].Nhap();
            
        }
        for(int i = 0; i < 10; i++)
        {
            list[i].Hienthi();
            double luong = list[i].Tinhluong();
            Console.WriteLine("Lương của nhân viên trên là: " + luong);
        }
        Console.ReadKey();
    }
}

