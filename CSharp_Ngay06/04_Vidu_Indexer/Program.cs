using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lophoc list = new Lophoc(3);
            //không sử dung indexer
            list.sinhvien[0] = "Nam";
            list[0] = "Nam";//tương đương lệnh trên nhờ Indexer cho mảng sinhvien
            //sử dung indexer để truy cập mảng sinhvien
            list[1] = "Long";
            //list.sinhvien[1]="Long;
            list[2] = "Trang";
            
        }
    }
}
