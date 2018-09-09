using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._6_Exception_Files
{
    class ExceptionExample
    {
        public static double Div(double number1, double numer2)
        {
            try
            {
                return number1 / numer2;
            }
            catch(DivideByZeroException )
            {
                Console.WriteLine("DivideByZeroException");
            }

            return Double.NaN;
        }

    }
}
