using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine("Number x is: " + x);
            x = 7;
            Console.WriteLine("Number x is: " + x);

            double num_double = 0.0d;
            float num_float = 0.0f;
            decimal num_decimal = 0.0m;

            num_double = 9.8;
            num_float = 5.5f;
            num_decimal = 100.250m;

            Console.WriteLine("Double Number: " + num_double + "\nFloat Number:" + num_float + "\nDecimal Number" + num_decimal);

            char letter_a = 'A';
            string firstName = "Jon";
            string lastName = "Smith";

            string house, cat, dog;
            house = "Low Street";
            cat = "Tom";
            dog = "Womble";
            Console.WriteLine("Character A: " + letter_a);
            Console.WriteLine("Your name is: " + firstName +" " + lastName);
            Console.WriteLine("You live on " + house + "You have a cat called " + cat + " And a dog called " + dog);

            bool isWorking, taskCompleted;
            isWorking = false;
            taskCompleted = false;

            Console.WriteLine("The person " + firstName + " " + lastName + "\nJob Status: " + isWorking + "\n Has completed task: " + taskCompleted);

            int sum = 0;
            int num1 = 5;
            int num2 = 8;
            sum= num1 + num2;
            Console.WriteLine("The sum of your two numbers is: " + sum);
        }
    }
}
