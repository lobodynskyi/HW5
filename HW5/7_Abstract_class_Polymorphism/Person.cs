using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._7_Abstract_class_Polymorphism
{
    class Person
    {
        private string name;
        public Person(string name)
        { this.name = name; }
        virtual public string Name { get { return name; } }
        virtual public void Print()
        {
            Console.Write("Name: {0}", this.name);
        }

    }
}
