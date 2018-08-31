using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        public void Zad1(int a, int b)
        {
            int counter = 0;
            for(int i = a ; i <= b ; i++)
            {
                if( i % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("діляться на 3 без остачі  {0}", counter);
        }

        public void Zad2(string symbols)
        {
            Console.WriteLine(symbols);
            for (int i = 0; i < symbols.Length ; i = i + 2)
            {
                Console.Write("{0}\t", symbols[i]);
            }
            Console.WriteLine();
        }

        public void Zad3(string nameOfTheDrink)
        {
            var map = new Dictionary<string, double>();
            map.Add("coffee", 14.0);
            map.Add("tea", 10.50);
            map.Add("juice", 8.0);
            map.Add("water", 5.0);
            double price;
            if (map.TryGetValue(nameOfTheDrink, out price))
            {
                Console.Write("Price for {0} = {1}\n", nameOfTheDrink, price) ;
            }else 
                Console.Write("No such product\n");
        }

        public void Zad4()
        {
            string input ;
            int number, sum = 0, counter = 0;
     
            Console.WriteLine("input data");
            while (true)
            {
                input = Console.ReadLine();
                Int32.TryParse(input, out number);
                if (number < 0)
                    break;
                sum += number;
                counter++;
            }
            Console.WriteLine("Avarege = 0");
        }

        public void Zad5(int year)
        {
            if (year % 4 == 0)
            {         
                if (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0))
                {
                    Console.WriteLine("Year {0} je wysokosnum", year);
                }
            }
            else Console.WriteLine("Year {0} ne je wysokosnum", year);
        }

        public void Zad6(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine("Suma cyfr = {0}", sum);
        }

        public void Zad7(int number)
        {
            int symbol = 0;
            while (number != 0)
            {
                symbol = number % 10;
                number /= 10;
                if(symbol % 2 != 0)
                {
                    Console.WriteLine("je neparne");
                    return;
                }
            }
            Console.WriteLine("je parne");
        }

        public void Zad8(string str)
        {
            Console.WriteLine("a = " + str.Count(f => f == 'a')  + " o = " + str.Count(f => f == 'o') +
                 " i = " + str.Count(f => f == 'i') + " e = "+ str.Count(f => f == 'e'));
        }

        public void Zad9(int month)
        {
            if (month <= 12 && month > 0)
            {
                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    Console.WriteLine("days = " + 30);
                }
                else if (month == 2)
                {
                    Console.WriteLine("days = " + 29);
                }
                else
                    Console.WriteLine("days = " + 31);
            }else Console.WriteLine("no such month");
        }

        public void Zad10()
        {
            int[] array = new int[10];
            int sum = 0;
           for(int i = 0 ; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (i < 5)
                    sum += array[i];
            }
            if (sum > 0)
                Console.WriteLine("1 part " + sum);
            else
            {
                sum = 0;
                for (int i = 5; i < 10; i++)
                {
                        sum += array[i];
                }
                Console.WriteLine("2 part " + sum);
            }
        }

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

            foreach(Person pr in persons)
            {
                Console.WriteLine("Name - {0} age - {1}", pr.Name , pr.Age());
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
            for(int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length - 1; j++)
                {
                    if (persons[i] == persons[j])
                        Console.WriteLine(persons[i] + "  " + i +"  = "+ "  " + j + "  " + persons[j]);
                }
            }

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.Zad1(2, 9);
            //program.Zad2("Framework");
            //program.Zad3("tea");
            //program.Zad4();
            //program.Zad5(1996);
            //program.Zad6(154);
            //program.Zad7(246);
            //program.Zad8("ieaa");
            //program.Zad9(10);
            //program.Zad10();
            //program.Zad11();
            program.Zad12();
            Console.ReadKey();
        }
    }
}
