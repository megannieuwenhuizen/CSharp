using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<=10;i++)
            {
                Console.WriteLine("The value of variable i is "+i);
                if (i == 5)
                    break;
            }

        }
    }
}
