using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtility;
namespace Baitap2
{
    public class VehiclesManager
    {
        public List<Vehicles> list;
        public VehiclesManager()
        {
            list = new List<Vehicles>();
        }
        public void input()
        {
            int type;
            String sNext;
            Vehicles vehilce;
            while(true)
            {
                Console.Write("Type of Vehicle? (1- Car, 2 - Truck):");
                Tools.InputNumber(out type);
                if (type == 1)
                    vehilce = new Car();
                else if (type == 2)
                    vehilce = new Truck();
                else
                    continue; //nhập lại
                vehilce.input();//nhập thông tin phương tiện
                list.Add(vehilce);//thêm vào danh sách
                Console.WriteLine("Continue to input? (C/K):");
                sNext = Console.ReadLine();
                if (sNext.ToUpper() == "K") //nếu bằng K hoặc k thì thoát
                    break;
            }    
        }
        public void display()
        {
            Console.WriteLine("List of Vehicles");
            foreach (Vehicles vehilce in list)
            {
                vehilce.display();
            }    
        }
        public void sortbyprice()
        {
            for(int i=0; i < list.Count-1; i++)
            {
                for(int j = i+1; j < list.Count; j++)
                {
                    if(list[i].Price < list[j].Price)//sắp xếp giảm dần
                    {
                        Vehicles temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }    
                }    
            }    
        }
    }
}
