using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.HW2
{
    class HW2
    {
        public void Zad1(int a, int b)
        {
            int counter = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("діляться на 3 без остачі  {0}", counter);
        }

        public void Zad2(string symbols)
        {
            Console.WriteLine(symbols);
            for (int i = 0; i < symbols.Length; i = i + 2)
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
                Console.Write("Price for {0} = {1}\n", nameOfTheDrink, price);
            }
            else
                Console.Write("No such product\n");
        }

        public void Zad4()
        {
            string input;
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
                if (symbol % 2 != 0)
                {
                    Console.WriteLine("je neparne");
                    return;
                }
            }
            Console.WriteLine("je parne");
        }

        public void Zad8(string str)
        {
            Console.WriteLine("a = " + str.Count(f => f == 'a') + " o = " + str.Count(f => f == 'o') +
                 " i = " + str.Count(f => f == 'i') + " e = " + str.Count(f => f == 'e'));
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
            }
            else Console.WriteLine("no such month");
        }

        public void Zad10()
        {
            int[] array = new int[10];
            int sum = 0;
            for (int i = 0; i < 10; i++)
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
        public void IntroductionHW2()
        {
            Zad1(2, 9);
            Zad2("Framework");
            Zad3("tea");
            Zad4();
            Zad5(1996);
            Zad6(154);
            Zad7(246);
            Zad8("ieaa");
            Zad9(10);
            Zad10();
        }
    }
}
