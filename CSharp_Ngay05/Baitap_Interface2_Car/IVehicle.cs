using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtility;
namespace Baitap2
{
    public interface IVehicle
    {
        void input();
        void display();
    }
    public class Vehicles : IVehicle
    {
        private String maker;
        private String model;
        private double price;
        //CONSTRUCTOR
        public Vehicles()
        {
            maker = "";
            model = "";
            price = 0;
        }
        public Vehicles(String maker, String model, double price)
        {
            this.maker = maker;
            this.model = model;
            this.price = price;
        }
        public String Maker
        {
            get { return maker; }   
            set { maker = value; }
        }
        public String Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        //Override các phương thức kế thừa từ IVehicle
        public virtual void input()
        {
            Console.Write("Maker: ");
            maker = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Price:");
            Tools.InputNumber(out price);
        }
        public virtual void display()
        {
            Console.Write("Maker : " + maker + "Model: " + model +"Price: " + price);
            Console.Write("Model: " + model);
            Console.WriteLine("Price: " + price);

        }
    }
    public class Car:Vehicles
    {
        private String color;
        public Car():base() 
        {
            color = "";        
        }
        public Car(String maker, String model, double price, String color)
        :base(maker,model,price)    
        {
            this.color = color;
        }
        public String Color
        {
            get { return color; }
            set { color = value; }
        }
        public override void input()
        {
            base.input();
            Console.Write("Color:");
            color = Console.ReadLine();
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("Color: " + color);
            Console.WriteLine("-----------------------------");
        }
    }
    public class Truck:Vehicles
    {
        private int truckload;
        public Truck() : base()
        {
            truckload = 0;
        }
        public Truck(String maker, String model, double price, int truckload)
        : base(maker, model, price)
        {
            this.truckload = truckload;
        }
        public int Truckload
        {
            get { return truckload; }
            set { truckload = value; }
        }
        public override void input()
        {
            base.input();
            Console.Write("Truckload:");
            Tools.InputNumber(out truckload);
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("Truckload: " + truckload);
            Console.WriteLine("-----------------------------");
        }
    }
}
