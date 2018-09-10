using HW5.HW4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._5_Interfaces_Collections
{
    class HW55
    {
        public void Zad13()
        {
            List<IFlyable> flyables = new List<IFlyable>();
            Plane plane1 = new Plane("AZE", 123);
            Plane plane2 = new Plane("POI", 345);
            Bird bird1 = new Bird("Ow", true);
            Bird bird2 = new Bird("Pigon", true);
            flyables.Add(plane1);
            flyables.Add(plane2);
            flyables.Add(bird1);
            flyables.Add(bird2);
            foreach (IFlyable fl in flyables)
            {
                fl.Fly();
            }

        }

        public void Zad14()
        {
            List<IDeveloper> developers = new List<IDeveloper>();
            Builder builder1 = new Builder();
            Programmer programmer1 = new Programmer();
            Programmer programmer2 = new Programmer();
            Builder builder2 = new Builder();

            developers.Add(builder1);
            developers.Add(programmer1);
            developers.Add(programmer2);
            developers.Add(builder2);

            foreach(IDeveloper d in developers)
            {
                d.Create();
                d.Destroy();
            }
        }
        public void Zad15()
        {
            Dictionary<uint, string> dictionary = new Dictionary<uint, string>();
            dictionary.Add(1,"one");
            dictionary.Add(2,"two");
            dictionary.Add(3,"three");
            dictionary.Add(4,"four");
            dictionary.Add(5,"five");
            dictionary.Add(6,"six");
            dictionary.Add(7,"seven");

            uint id = 3;
            string answer;
            if (dictionary.TryGetValue(id, out answer))
            {
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("No such data");
            }
        }

        public void IntroductionHW5()
        {
            //MyColl myColl = new MyColl();
            Zad13();
            Zad14();
            Zad15();
        }
        public HW55()
        {
            IntroductionHW5();
        }
    }
}
