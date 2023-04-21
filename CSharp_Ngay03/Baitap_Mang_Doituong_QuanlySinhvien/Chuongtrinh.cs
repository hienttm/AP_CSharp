using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_Mang_Class
{
    internal class Chuongtrinh
    {
        //xây dựng phương thức tĩnh (static) hiển thị menu và nhập số chọn
        public static int Menu()
        {
            int chon;
            Console.WriteLine("Menu \n1. Nhập danh sách \n2. Hiển thị danh sách");
            Console.WriteLine("3.Sắp xếp điểm giảm dần \n4.Tìm theo từ khóa");
            Console.WriteLine("5.Thoát");
            Console.WriteLine("Mời lựa chọn  (1-5):");
            chon = int.Parse(Console.ReadLine());
            return chon;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            DanhsachSinhvien dssv = new DanhsachSinhvien();
            int chon;
            do
            {
                //hiển thị menu
                chon = Menu();
                //xử lý menu
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Nhập danh sách:");
                        dssv.Nhap();
                        break;
                    case 2:
                        Console.WriteLine("Hiển thị danh sách:");
                        dssv.Hienthi();
                        break;
                    case 3:
                        Console.WriteLine("Sắp xếp điểm giảm dần:");
                        dssv.SapxepDiemGiamdan();
                        dssv.Hienthi();
                        break;
                    case 4:
                        int n;
                        string tukhoa;
                        Console.Write("Nhập từ khóa:");
                        tukhoa = Console.ReadLine();
                        n = dssv.Timkiem(tukhoa);
                        if (n == 0)
                            Console.WriteLine("Không tìm thấy sinh có họ tên chứa từ:" + tukhoa);
                        break;
                    case 5:
                        Console.WriteLine("Kết thúc chương trình \nChào tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Bạn nhập sai lựa chọn, mới nhập lại!");
                        break;
                }
            } while (chon != 5);
        }
    }
}
