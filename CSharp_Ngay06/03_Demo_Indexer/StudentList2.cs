using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexer
{
    internal class StudentList2
    {
        //khai báo field dạng mảng
        private Student[] list = new Student[10];
        public StudentList2()
        {
            for (int i = 0; i < list.Length; i++)
                list[i] = new Student();
        }
        //khai báo indexer (bộ chỉ mục) để truy cập vào trường dạng mảng
        //để cho phép truy cập và trường list trực tiếp bằng [i] sau tên đối tượng của lớp này
        public Student this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }
    }
}
