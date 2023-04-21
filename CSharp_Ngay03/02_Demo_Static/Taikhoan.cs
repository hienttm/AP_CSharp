using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Static
{
    internal class Taikhoan
    {
        //Số tài khoản, số dư và lãi suất
        //lãi suất là 1 biến dùng chung cho toàn bộ các đối tượng nên khai báo là static
        public static double laisuat;
        
        //số tài khoản và số dư là riêng biệt của từng đối tượng nên không phải là static
        //mỗi đối tượng của lớp có ô nhớ riêng cho các thành phần không phải static này
        public string sotk;
        public int sodu;
        //khai báo phương thức khởi tạo tĩnh (static constructor)
        //dùng để khởi tạo các biến thành phần static
        static Taikhoan()
        {
            laisuat = 0.1;
        }
        //khai báo các phương thức khởi tạo (constructor) khác
        public Taikhoan()
        {
            sotk = "";
            sodu = 0;
        }
        public Taikhoan(string sotk, int sodu)
        {
            this.sotk = sotk;
            this.sodu = sodu;
        }
        public void hienthi()
        {
            //phương thức không static (instance method)
            //thì truy cập được các thành riêng (instance variable)
            Console.WriteLine("Số TK: " + sotk + ", Số dư:" + sodu);
            //và cả thành phần static
            Console.WriteLine("Lãi suất: " + laisuat);
        }
        public static void hienthistatic()
        {
            //phương thức static thì truy cập các thành phần static không cần
            //chỉ định lại Tenlop.Tenthanhphan_static
            Console.WriteLine("Lãi suất: " + laisuat);
            //không được truy cập được vào các thành phần riêng của các đối tượng
            //Console.WriteLine("Số TK: " + sotk + ", Số dư:" + sodu);
        }
    }
}
