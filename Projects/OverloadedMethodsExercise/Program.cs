using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x, y, z;
            int total1 = 0;
            double total2 = 0;

            a = 10; b = 12; c = 14;
            x = 5; y = 6; z = 7;

            total1 = Sum(a, b);
            Console.WriteLine($"The sum of {a} and {b} is {total1}.");

            total1 = Sum(a, b, c);
            Console.WriteLine($"The sum of {a}, {b},{c} is {total1}");

            total2 = Sum(x, y);
            Console.WriteLine($"The sum of {x} and {y} is {total2}.");

            total2 = Sum(x, y, z);
            Console.WriteLine($"The sum of {x}, {y},{z} is {total2}");
        }
        static int Sum(int a,int b)
            {
            return a + b;
            }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static double Sum(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}
