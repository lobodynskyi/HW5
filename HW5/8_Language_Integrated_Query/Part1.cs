using HW5._7_Abstract_class_Polymorphism;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._8_Language_Integrated_Query
{
    class Part1
    {
        List<Shape> shapes = new List<Shape>();
        public void FillList()
        {
            shapes.Add(new Square("Square1", 1));
            shapes.Add(new Square("Square2", 4));
            shapes.Add(new Square("Square3", 5));
            shapes.Add(new Square("Square4", 7));
            shapes.Add(new Square("Square5", 6));
            shapes.Add(new Circle("Circle1", 2));
            shapes.Add(new Circle("Circle2", 1));
            shapes.Add(new Circle("Circle3", 5));
            shapes.Add(new Circle("Circle4", 7));
            shapes.Add(new Circle("Circle5", 6));
        }
        public void Present()
        {
            var zad1 = shapes.Where(t => t.Area() > 10 && t.Area() < 100).ToList();
            var zad2 = shapes.Where(t => t.Name.Contains("a") == true).ToList();
            var zad3 = shapes.Where(x => x.Perimeter() < 5);
            shapes.RemoveAll(x => zad3.Contains(x));
            foreach (var e in shapes)
            {
                     Console.WriteLine(e.Name + " " + e.Perimeter());
            }
                   
            
            
        }

        public Part1()
        {

            FillList();
            Present();
        }
    }
}
