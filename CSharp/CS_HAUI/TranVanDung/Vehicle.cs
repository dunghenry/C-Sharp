using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
 
    internal class Vehicle : IVehicle

    {
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }

        public Vehicle() { }
        public Vehicle(string id)
        {
            this.id = id;
        }
        public Vehicle(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public virtual void Input()
        {
            Console.Write("Id: ");
            id = Console.ReadLine();
            Console.Write("Maker: ");
            maker = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Price: ");
            price = double.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Maker: " + maker);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Year:" + year);
            Console.WriteLine("Price: " + price);
        }
        public override bool Equals(object obj)
        {
            Vehicle v = (Vehicle)obj;
            return (this.id.Equals(v.id));
        }
        public override string ToString()
        {
            var str = String.Format("{0,-8}{1,-10}{2,-25}{3,10}{4,10}", id, maker, model, year, price);
            return str;
        }
        public int CompareTo(object obj)
        {
            Vehicle v = (Vehicle)obj;
            return (this.price.CompareTo(v.price));
        }
    }
    class CompareYear : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            return (x.year - y.year);
        }
    }
}
