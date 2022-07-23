using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usernum = 0;
            Console.WriteLine("Please enter a number");
            usernum = Convert.ToInt32(Console.ReadLine());
            String result = "";

            if(usernum%2==0)
            {
                result = "Even";
            }
            else
            {
                result = "Odd";
            }

            switch(result)
            {
                case "Even":
                    Console.WriteLine("The number you have entered is even: " + usernum);break;
                default:
                    Console.WriteLine("The number you have entered is odd: " + usernum);break;

            }
        }
    }
}
