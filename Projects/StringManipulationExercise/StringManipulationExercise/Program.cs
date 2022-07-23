using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tvShow = "Game of Throne     ";
            string seasonOne = " - Season 1";
            string newName = "";
            

            // Add " - Season 1" without determining the start index
            newName = tvShow.TrimEnd(' ') + seasonOne;// or can do tvShow.Insert(tvShow.Trim().Length,seasonOne)
            Console.WriteLine(newName);
        }
    }
}
