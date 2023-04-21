using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_Doituong
{
    public class Person
    {
        //khai báo các fields: biến lưu thông tin của Person
        private string hoten;
        public bool gioitinh;
        //khai báo các properties (cung cấp get/set cho các field
        public string Hoten
        {
            get => hoten;
            set => hoten = value;
            /*
            get { return hoten; }
            set { hoten = value; }
            */
        }
        public String Gioitinh    
        {
            //get: từ true/false trả về chuỗi Nam/Nữ
            get { 
                return gioitinh==true?"Nam":"Nữ"; 
                }
            //set từ Chuỗi nam/nu gán giá trị true/false cho gioitinh
            set { 
                gioitinh = value.ToLower()=="nam" ? true : false; 
                }
        }
        //xây dựng hàm tạo (constructor)
        public Person()
        {
            hoten = "";
            gioitinh = true;
        }
        public Person(string hoten, bool gioitinh)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
        }
        //xây dựng phương thức 
        public void Nhap()
        {
            Console.WriteLine("Họ tên:");
            hoten = Console.ReadLine();
            string gioitinh;//cho phép nhâp: Nam/Nữ
            Console.WriteLine("Giới tính:");
            gioitinh = Console.ReadLine();//nhập: Nam/Nu
            this.Gioitinh = gioitinh;//gọi property Gioitinh để gán true/false cho this.gioitinh
        }
        public void Hienthi()
        {
            Console.WriteLine("Họ tên: {0}, Giới tính: {1}",
                                this.hoten, this.Gioitinh);
        }
        
    }
}
