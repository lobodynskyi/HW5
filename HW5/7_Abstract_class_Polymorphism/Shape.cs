using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HW5._7_Abstract_class_Polymorphism
{
    abstract class Shape : IComparable<Shape>
    {
        private string name;  

        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;   
            }
        }
        protected Shape(string name)
        {
            this.name = name;
        }
        abstract public double Area();
        abstract public double Perimeter();

        public int CompareTo(Shape other)
        {
            if (this.Area() > other.Area())
                return 1;
            if (this.Area() < other.Area())
                return -1;
            else
                return 0;
        }
    }
}
