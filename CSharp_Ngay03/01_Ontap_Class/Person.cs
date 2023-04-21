using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap_Class
{
    public class Person
    {
        //khai báo các fields: biến lưu thông tin của Person
        private string hoten;
        private bool gioitinh;
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
            get { 
                return gioitinh==true?"Nam":"Nữ"; 
                }
            set { 
                gioitinh = (value=="Nam") ? true : false; 
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
    }
}
