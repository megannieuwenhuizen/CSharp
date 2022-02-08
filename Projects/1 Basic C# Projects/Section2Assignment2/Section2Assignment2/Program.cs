using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Section 2 Assignment 2: Time machine
 Develop an app which takes a date (birthday eg) and it should tell you what day of the week it was*/
namespace Section2Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime timemachine=new DateTime();
            Console.WriteLine("Enter the day: " );
            int.TryParse(Console.ReadLine(), out int day);
            Console.WriteLine("Enter the month: ");
            int.TryParse(Console.ReadLine(), out int month);
            Console.WriteLine("Enter the year: ");
            int.TryParse(Console.ReadLine(), out int year);
            timemachine.AddDays(day);
            timemachine.AddMonths(month);
            timemachine.AddYears(year);
            Console.WriteLine("This day should be a " + timemachine.DayOfWeek);


        }
    }
}
