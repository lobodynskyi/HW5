using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._7_Abstract_class_Polymorphism
{
    class Teacher : Staff
    {
        public string subject { get; set; }
        public Teacher(string name, int salary, string subject) : base(name, salary)
        {
            this.subject = subject;
        }
        public override void Print()
        {
            Console.Write("\tCleaner {0} has salary: ${1} and subject {2}", Name, this.salary, subject);
        }
    }
}
