using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._2_Value_types
{
    class HW2
    {
        enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted };
        public struct Dog
        {
            public string Name;
            public string Mark;
            public int Age;
            public override string ToString()
            {
                return String.Format("Name:{0}, Mark:{1}, Age:{2}", Name, Mark, Age);
            }
        };

        public void IntroductionHW2()
        {
            // Define integer variables a and b.Read values a and b from Console and calculate: a + b, a - b, a* b, a/ b.Output obtained results.
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a = {0}\tb = {1}", a, b);
            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            if (a == 0)
                Console.WriteLine("a / b =  incorrect");
            else
                Console.WriteLine("a / b = {0}", a / b);

            // Output question “How are you ?“. Define string variable answer.Read the value answer and output: “You are(answer)".
            Console.WriteLine("How are you ?");
            string txt = Console.ReadLine();
            Console.WriteLine("You are(answer){0}", txt);
            // Read 3 variables of char type. Write message: “You enter(first char), (second char), (3 char)”
            char z, x, c;
            z = Console.ReadKey().KeyChar;
            x = Console.ReadKey().KeyChar;
            c = Console.ReadKey().KeyChar;
            Console.WriteLine("You enter{0}, {1}, {2}", z, x, c);
            // Enter 2 integer numbers. Check if they are both positive – use bool expretion
            Console.WriteLine("a = {0}" , a > 0 ? "positive" : "negateive");
            Console.WriteLine("b = {0}", b > 0 ? "positive" : "negateive");

            //Ввести дійсне число number і отримати 2 перші цифри після коми цього числа. Вивести суму цих цифр. Напр.: 3.456->4 + 5 = 9
            
          
            float val;
            if (float.TryParse(Console.ReadLine(), out val))
            {
                string[] tmp = val.ToString().Split(',');

                if (tmp.Length > 1)
                {
                    if (tmp[1].Length > 1)
                    {
                        Console.WriteLine(tmp[1][0] + " - " + tmp[1][1]);
                        Console.WriteLine("sum = {0}", Int32.Parse(tmp[1][0].ToString()) + Int32.Parse(tmp[1][1].ToString()));
                    }
                }
            }
            else Console.WriteLine("Wrong input data");



            TestCaseStatus test1Status = TestCaseStatus.Fail;
            Console.WriteLine("{0} = taste1Status ", test1Status);

            Dog myDog;
            myDog.Age = 3;
            myDog.Mark = "Bulgog";
            myDog.Name = "Admiral";
            Console.WriteLine(myDog);

            Console.ReadKey();
        }
    }
}

