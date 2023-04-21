using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_Mang_Class
{
    internal class DanhsachSinhvien
    {
        private Sinhvien[] ds = new Sinhvien[30];
        private int max;
        public int Max { get { return max; } set { max = value; } }
        //xây dựng hàm tạo
        public DanhsachSinhvien()
        {
            max = 0;
            //vòng lặp khởi tạo 30 sinh viên
            for(int i = 0; i < ds.Length; i++)
            {
                ds[i] = new Sinhvien();
            }
        }
        //tạo indexer đẻ truy cập vào mảng ds qua toán tử  []
        public Sinhvien this[int i]
        {
            get { return ds[i]; }   
            set { ds[i] = value; }
        }
        //phương thức nhập danh sách vào mảng ds
        public void Nhap()
        {
            do
            {
                Console.Write("Nhập số sinh viên (1-30):");
                max = int.Parse(Console.ReadLine());
            } while (max <= 0 || max > 30);
            Console.WriteLine("Nhập " + max + " sinh viên:");
            for(int i=0; i<max; i++)
            {
                Console.WriteLine("Sinh vien {0}", i + 1);
                ds[i].Nhap();//nhập thông tin sinh viên thứ i
            }
        }
        //phương thức hiển thị sinh viên
        public void Hienthi()
        {
            Console.WriteLine("Danh sách  " + max + " sinh viên:");
            for (int i = 0; i < max; i++)
            {
                ds[i].Hienthi();//hiển thị thông tin của sinh viên thứ i
            }
        }
        //phương thức sắp xếp danh sách theo điểm giảm dần
        public void SapxepDiemGiamdan()
        {
            Sinhvien temp;
            for(int i=0; i<max-1;i++)//i duyệt từ 0 -> n-1
            {
                for (int j = i + 1; j < max; j++)//j các phân tử sau i
                {
                    if (ds[i].Diem < ds[j].Diem)//nếu điểm trước < điểm sau thì đổi
                    {
                        temp = ds[i];
                        ds[i] = ds[j];
                        ds[j] = temp;
                    }    
                }    
            }    
        }
        //phương thức hiển thị sinh viên có họ tên chứa từ khóa
        public int Timkiem(string tukhoa)
        {
            int dem = 0;
            for(int i = 0; i < max; i++)
            {
                if(ds[i].Hoten.IndexOf(tukhoa) >=0)//nếu họ tên chứa từ khóa
                {
                    dem++;
                    ds[i].Hienthi();
                }    
            }
            return dem;
        }
    }
}
