using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._7_Abstract_class_Polymorphism
{
    class Cleaner : Staff
    {
        string level;

        public Cleaner(string name, int salary, string level) : base(name, salary)
        {
            this.level = level;
        }
        public override void Print()
        {
            Console.Write("\tCleaner {0} has salary: ${1} and level {2}", Name, this.salary, level);
        }
    }
}
