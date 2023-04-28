
using Microsoft.VisualBasic;

namespace baitap_demsolanxuathien_Ngay08;
class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        Dictionary<string, int> words = new Dictionary<string, int>();

        Console.WriteLine("Nhập chuỗi (ENTER để kết thúc):");
        while (true)
        {
            
            string str = Console.ReadLine();
            if (str == "")
                break;
            else
            {
               list.Add(str);
                
            }
                
        }
        //hiển thị ds chuỗi đã nhập
        foreach (string d in list)
        {
            Console.WriteLine(d);
        }
        //tách từ
        int dem = 0;
        foreach(string d in list)
        {
            string[] arr = d.Split(' ');
            
            foreach (string word in arr)
            {
                if (word != "")
                {
                    dem++;
                }
                
                if (words.ContainsKey(word) ) //nếu từ này đã xuất hiện trong từ điển 
                {
                    int n = words[word];  //lần đã xuất hiện trc đó
                    n++;
                    words[word] = n;     //gán gtri mới +1
                }
                else
                {
                    if(word !="")
                    {
                        words.Add(word, 1);
                    }
                    
                }
            }
        }
        
        // duyệt mảng từ điển words
        
        foreach(var key in words.Keys)
        {
            Console.WriteLine(key + " : " + words[key]);
           
        }
        Console.WriteLine("Tổng số từ: "+dem);
        Console.ReadKey();
    }
}

