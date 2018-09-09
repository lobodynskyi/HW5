using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._7_Abstract_class_Polymorphism
{
    class Square : Shape
    {
        public int side { get; set; }

        public Square(string name, int side) : base(name)
        {
            this.side = side;
        }


        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return side * 4;
        }
        
    }
}
