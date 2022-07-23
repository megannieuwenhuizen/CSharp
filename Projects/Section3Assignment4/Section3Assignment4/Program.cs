using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an upside down triangle created with a nested loop:");
            //Create an upside down triangle with nested loops
            for (int i = 1; i <= 15; i++)
            {
                for (int j = 15; j >= i;j--)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
}
