using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            //Console.WriteLine("Welcome back " + name);
            //Console.WriteLine("Welcome back {0}", name);
            Console.WriteLine($"Welcome back again {name}");
        }
    }
}
