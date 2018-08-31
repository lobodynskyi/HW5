using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Car
    {
        public string name { get; set; }
        public string color { get; set; }
        public double price { get; set; }
        const string CompanyName = "CompanyIE";

        public Car()
        {
            name = "Mazda";
            color = "White";
            price = 150000;
        }

        public Car(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public void Input()
        {
            string name = Console.ReadLine();
            string color = Console.ReadLine();
            double price = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("car {0}\t color {1}\t price {2}", name, color, price);
        }
        public void ChangePrice(double x)
        {
            price = price * (100 - x);
        }

        public override string ToString()
        {
            return String.Concat(name, color, price, CompanyName);
        }

        public static bool operator ==(Car first, Car second)
        {
            if (first.name == second.name || first.price == second.price)
                return true;
            return false;
        }

        public static bool operator !=(Car first, Car second)
        {
            if (first.name == second.name || first.price == second.price)
                return false;
            return true;
        }

    }
}
