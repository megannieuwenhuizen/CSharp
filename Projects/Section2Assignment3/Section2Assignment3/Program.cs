using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2Assignment3
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            DateTime todaydate = DateTime.Today;
            String day = todaydate.ToString();
            switch(day)
            {
                case "Saturday":
                    Console.WriteLine("Yellow");break;
                case "Sunday":
                    Console.WriteLine("Green"); break;
                case "Monday":
                    Console.WriteLine("Blue"); break;
                case "Tuesday":
                    Console.WriteLine("Grey"); break;
                case "Wednesday":
                     Console.WriteLine("Red"); break;
                case "Thursday":
                    Console.WriteLine("Orange"); break;
                default:
                    Console.WriteLine("White"); break;

            }
        }
    }
}
