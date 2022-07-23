using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            //second way of initializing
            int[] numbers2 = new int[5] { 1, 10, 50, 100, 200 };
            string[] weekDays = new string[7] { "Sun", "Mon", "Tues", "Wed", "Thur", "Fri", "Sat" };
            //not recommended
            string[] weekDays2 =  { "Sun", "Mon", "Tues", "Wed", "Thur", "Fri", "Sat" };
            //first way of initializing
            numbers[0] = 1;
            numbers[1] = 10;
            numbers[2] = 50;
            numbers[3] = 100;
            numbers[4] = 200;

            Console.WriteLine(numbers[0]);


            for (int i = 0; i <= numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }

            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);
            }

            foreach (var name in weekDays2)
            {
                Console.WriteLine(name);
            }
        }
    }
}
