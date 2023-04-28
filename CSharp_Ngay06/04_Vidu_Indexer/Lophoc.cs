using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu_Indexer
{
    internal class Lophoc
    {
        public String[] sinhvien;
        public String[] giaovien;
        public Lophoc(int n)
        {
            sinhvien = new string[n];
            giaovien = new string[n];
        }
        //tạo indexer cho mảng sinhvien
        public string this[int i]
        {
            get { return sinhvien[i]; }
            set { sinhvien[i] = value; }
        }
    }
}
