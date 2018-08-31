using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Person
    {
        private string name;
        private DateTime birthYear;
        public DateTime BirthYear
        {
            get
            {
                return birthYear;
            }
        }
        public string Name    
        {
            get
            {
                return name;
            }
        }

        public Person()
        {
            name = "Max";
            birthYear = new DateTime(1995 , 1, 1);
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }


        public int Age()
        {
            //Console.WriteLine(DateTime.Now.Year + " - " + birthYear.Year);
            return DateTime.Now.Year - birthYear.Year;
        }

        public void Input()
        {
            Console.WriteLine("name");
            name = Console.ReadLine();
            Console.WriteLine("year");
            birthYear = new DateTime(int.Parse(Console.ReadLine()));
        }

        public void ChangeName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return String.Concat(name, birthYear); 
        }
        
        public void Outout()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person first, Person second)
        {
            if (first.name == second.name)
                return true;
            return false;
        }


        public static bool operator !=(Person first, Person second)
        {
            if (first.name == second.name)
                return false;
            return true;
        }
    }
}
