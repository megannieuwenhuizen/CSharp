using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            Person per = new Person();
            per.SayHi();
        }
        static void SayHi()
        {
            Console.WriteLine("Hi, from the static method");
        }
    }

    class Person
    {
        public void SayHi()
        { 
            Console.WriteLine("Hi from the non-static method!"); 
        }
    }
}
