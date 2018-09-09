using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._7_Abstract_class_Polymorphism
{
    class Staff : Person
    {
        public int salary { get; set; }
        public Staff(string name, int salary) : base(name)
        { this.salary = salary; }
        override public string Name { get { return base.Name + "Staff"; } }
        override public void Print()
        {
            Console.Write("\tPerson {0} has salary: ${1}", Name, this.salary);
        }

    }
}
