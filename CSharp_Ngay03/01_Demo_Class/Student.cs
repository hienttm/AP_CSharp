using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Class
{
    public class Student
    {
        //khai báo các trường (field)
        private int id;
        private string name;
        public void setId(int id) { 
            this.id = id; 
        }
        public int getId() { 
            return this.id; 
        }
        //khai báo các thuộc tính thay cho get,set
        //(để các đối tượng truy cập vào các trường)
        public int Id { 
            get { 
                return this.id; 
            } 
            set { 
                    if(value>0)
                        this.id = value; 
            }
        }
        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }
        public string Name
        {
            /*get { return this.name; }
            set { this.name = value; }*/
            get => this.name;
            set => this.name = value;
        }
        //khai báo hàm tạo (constructor) dùng để khởi tạo đối tượng sau lệnh new
        //là nơi cài đặt các công việc cần thực hiện khi đối tượng được tạo mới
        public Student()//khai báo hàm tạo không tham số
        {
            id = 0;
            name = "";
        }
        //nạp chồng (overload) thêm 1 hàm tạo 2 tham số id,name
        public Student(int id, string name)
        {
            this.id = id; //sử dụng this.tenTruong để phân biệt với biến trùng tên
            this.name = name;
        }
        //khai báo phương thức (hàm thể hiện hành động của đối tượng)
        public void Display()
        {
            Console.WriteLine("Id:" + id + ", Name:" + name);
        }
        public void SetInfo(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        //xây dựng hàm hủy (Destructor) là hàm tự động gọi khi hủy đối tượng
        //là nơi cài đặt các công việc cần thực hiện khi đối tượng được giải phóng
        ~Student()
        {
            Console.WriteLine("Đối tượng đã được hủy :" + this.name);
        }
    }
}
