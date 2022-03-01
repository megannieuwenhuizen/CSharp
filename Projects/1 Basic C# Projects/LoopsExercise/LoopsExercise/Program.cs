using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Even Numbers
            Console.WriteLine("Even numbers exercise:");
            for (int i=2; i<=100;i=i+2)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //Triangle
            Console.WriteLine("Build a triangle exercise:");
            for (int j=0; j<=10; j++)
            {
                for (int k=1; k<=j+1;k++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();


            }
        }
    }
}
