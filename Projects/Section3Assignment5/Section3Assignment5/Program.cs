using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generate a random month and display the months name as well as the amount of days in the month
            Random monthRandom = new Random();
            int year = 2022;
            int monthOfYear = monthRandom.Next(1,13);
            DateTime month = new DateTime().AddMonths(monthOfYear);
            int daysMonth = DateTime.DaysInMonth(year, monthOfYear);

            Console.WriteLine(month.ToString("MMMM") + " - " + daysMonth + " days");
        }
    }
}
