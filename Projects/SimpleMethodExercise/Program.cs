using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Ring Ring***\n***Ring Ring***");
            GetName();
            
            Console.WriteLine("Do you need Batmans help? (Y/N)");
            string help =Console.ReadLine();
            if (help.StartsWith("Y") || help.StartsWith("y"))
            { 
                BatSignal(); 
            }
            else
            {
                GoAway();
            }
                
        }

        static void GetName()
        {
            Console.WriteLine("Who is this?!");
            string name = string.Empty;
            name=Console.ReadLine();
            SayHi(name);
        }

        static void SayHi(String name)
        {
            Console.WriteLine($"Hello {name}, my name is Alfred.",name );
        }
        static void BatSignal()
        {
            Console.WriteLine("     x         x\n" +
                              "    xxx  x x  xxx\n" +
                              "   xxxxx xxx xxxxx\n" +
                              "  xxx xxxxxxxxx xxx\n" +
                              " xxxx   xxxxxx   xxxx\n" +
                              "  xx     xxxx     xx\n" +
                              "   x      xx       x\n");
            Console.WriteLine("Bat Signal Deployed! I am on my way.");               

        }
        static String GoAway()
        {
            return "Then go away and leave me to my bat business!!\n ****RETREATS BACK INTO BAT CAVE!****";
        }
    }
}
