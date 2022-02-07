using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmaticOperationsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int minus = 0;
            int plus = 0;
            int multiply = 0;
            double divide = 0.0d;
            int remainder = 0;

            Console.WriteLine("Please enter your first number: ");
            string value1 = Console.ReadLine();
            Console.WriteLine("Please enter your second number: ");
            string value2 = Console.ReadLine();

            x = Convert.ToInt32(value1);
            y = Convert.ToInt32(value2);

            minus = x - y;
            plus = x + y;
            multiply = x * y;
            divide = x / y;
            remainder = x % y;

            Console.WriteLine("Subtraction: " + x + " - " + y +" = "+ minus);
            Console.WriteLine("Add: " + x + " + " + y + " = " + plus);
            Console.WriteLine("Multiplication: " + x + " * " + y + " = "+ multiply);
            Console.WriteLine("Division: " + x + " / " + y + " = " + + divide);
            Console.WriteLine("Remainder: " +x + " % " + y + " = " + remainder);
        }
    }
}
