using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Section 2 Assignment 1: Friendly Conversation with C# */
namespace Section2Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "";
            
            

            Console.WriteLine("C#: What is your name?");
            name=Console.ReadLine();
            Console.WriteLine("C#: Nice to meet you {0}. My name is C#, How old are you?",name);
            int.TryParse(Console.ReadLine(), out int age);
            if (age == 0)
                Console.WriteLine("Incorrect input");
            else
                 Console.WriteLine("{0} good, as for me I was born on 2002. Which makes me {1} years old." , age,DateTime.Now.Year-2002);
                
            
        }
    }
}
