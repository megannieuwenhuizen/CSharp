using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String reply = "";
            Random dice = new Random();
            int diceNumber = 0;
            Console.WriteLine("Roll Dice(yes/no)");
            reply = Console.ReadLine().ToLower();

            while (reply == "yes")
            {
                
                if (reply != "yes")
                    break;
                else
                {
                    diceNumber = dice.Next(1, 7);
                    Console.WriteLine("New dice number is: " + diceNumber);
                    Console.WriteLine("Roll Dice(yes/no)");
                    reply = Console.ReadLine().ToLower();
                }


            }
        }
    }
}
