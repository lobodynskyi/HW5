using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._4_Class_Object
{
    class HW4
    {
        public void Zad11()
        {
            Car car1 = new Car();
            Car car2 = new Car("BMW", "Black", 120000);
            Car car3 = new Car("Mercedes", "Orange", 120000);
            Console.WriteLine("cars : \n{0}\n{1}\n{2}", car1, car2, car3);
            car1.ChangePrice(10);
            car1.color = "Grey";
            car2.ChangePrice(10);
            car3.ChangePrice(10);
            Console.WriteLine("cars : \n{0}\n{1}\n{2}", car1, car2, car3);
            Console.WriteLine("car1 == car2 -> {0}\ncar1 != car2 -> {1}", car1 == car2, car1 != car2);
        }
        public void Zad12()
        {
            Person[] persons = {new Person(),
             new Person("Ana",new DateTime(2008 ,1, 1)),
             new Person("Andriy", new DateTime(1992, 1, 1)),
             new Person("Oleg", new DateTime(2007, 1, 1)),
             new Person("Ira", new DateTime(1997, 1, 1)),
             new Person("Vasyl", new DateTime(1994, 1, 1))};

            foreach (Person pr in persons)
            {
                Console.WriteLine("Name - {0} age - {1}", pr.Name, pr.Age());
            }
            foreach (Person pr in persons)
            {
                if (pr.Age() < 16)
                    pr.ChangeName("Very Young");
            }
            foreach (Person pr in persons)
            {
                Console.WriteLine(pr.ToString());
            }
            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length - 1; j++)
                {
                    if (persons[i] == persons[j])
                        Console.WriteLine(persons[i] + "  " + i + "  = " + "  " + j + "  " + persons[j]);
                }
            }

        }
        public void IntroductionHW4()
        {
            Zad11();
            Zad12();
        }
    }
}
