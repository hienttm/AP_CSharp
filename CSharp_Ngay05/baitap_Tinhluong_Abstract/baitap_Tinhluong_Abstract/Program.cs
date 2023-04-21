using System;

namespace baitap_Tinhluong_Abstract;
class Program
{
    static void Main(string[] args)
    {
        Nhanvienkinhdoanh nv1 = new Nhanvienkinhdoanh();
        nv1.Nhap();
        nv1.Hienthi();
        Console.WriteLine("Lương nhân viên 1 là:" + nv1.Tinhluong());
        NhanvienKythuat nv2 = new NhanvienKythuat();
        nv2.Nhap();
        nv2.Hienthi();
        Console.ReadKey();
        Console.WriteLine("Lương nhân viên 2 là:" + nv2.Tinhluong());
    }
}

