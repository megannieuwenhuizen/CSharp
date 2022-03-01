using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //For Loop
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("For Loop:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("The value of variable i is " + i + " in the for loop.");
                if (i == 5)
                    break;
            }

            //While Loop
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("While Loop:");
            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine("This is line number " + x + "in the while loop.");
                x++;
                if (x == 6)
                    break;
            }

            //Do While Loop
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Do While Loop:");
            int z = 1;
            do
            {
                Console.WriteLine("This is line number " + z + "in the do while loop.");
                z++;
                if (z == 9)
                    break;
            } while (z <= 10);

            //Nested Loop
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Nested Loops:");

            for (int s = 1; s <= 4; s++)
            {
                for (int p = 1; p<=5; p++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------");
        }
    }
}
