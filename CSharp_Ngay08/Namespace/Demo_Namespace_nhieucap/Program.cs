using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronic.Sony;
using ss = Electronic.Samsung; //tạo bí danh ngắn gọn cho namespace
namespace Demo_Namespace_nhieucap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sử dụng trực tiếp tên lớp vì đã using namespace chứa nó
            XpediaZ sonyPhone = new XpediaZ();
            //sử dụng bí danh của namespace đã khai báo sau using
            ss.GalaxyS21 samsungPhone = new ss.GalaxyS21();
            //sử dụng đường dẫn đầy đủ
            Electronic.Tivi tivi = new Electronic.Tivi();

        }
    }
}
