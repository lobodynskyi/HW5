using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._7_Abstract_class_Polymorphism
{

    class HW7
    {

        public HW7()
        {
            IntroductionHW7();
        }

        public void Task1()
        {
            ICollection<Person> people = new List<Person>();
            people.Add(new Person("Nazar"));
            people.Add(new Staff("Andry", 2));
            people.Add(new Teacher("Oksana", 3, "NAI"));
            people.Add(new Cleaner("Ira", 4, "Low"));
            foreach (var a in people)
            {
                a.Print();
                Console.WriteLine();
            }
            foreach (var a in people)
            {
                if (a.Name == "Nazar")
                    a.Print();
            }
        }

        public void Task2()
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square("Square1", 2));
            shapes.Add(new Square("Square2", 4));
            shapes.Add(new Square("Square3", 5));
            shapes.Add(new Square("Square4", 7));
            shapes.Add(new Square("Square5", 6));
            shapes.Add(new Circle("Circle1", 2));
            shapes.Add(new Circle("Circle2", 4));
            shapes.Add(new Circle("Circle3", 5));
            shapes.Add(new Circle("Circle4", 7));
            shapes.Add(new Circle("Circle5", 6));
            double max = -1;
            Shape shape = null ;
            foreach(var e in shapes)
            {
                Console.WriteLine(e.Name + "\t" + e.Perimeter() + "\t" + e.Area());
                if(max < e.Area())
                {
                    max = e.Area();
                    shape = e;
                }
            }
            Console.WriteLine("Max shape = " + shape.Name + "\t" + shape.Area());
            shapes.Sort();
            Console.WriteLine("\t\tSorted by area");
            foreach (var e in shapes)
            {
                Console.WriteLine(e.Name + "\t" + e.Area());
            }
        }


        public void IntroductionHW7()
        {
            Task1();
            //Task2();   

        }

    }
}
