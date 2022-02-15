using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = "   lord of the rings   ";
            String tvShow = "CSI: New York";
            //Indexes
            Console.WriteLine(movieName[0]);

            //Trim
            Console.WriteLine(movieName.Trim());

            //Upper
            Console.WriteLine(movieName.ToUpper().Trim());

            //Lower
            Console.WriteLine(movieName.ToLower().Trim());

            //Length
            Console.WriteLine(movieName.Length);

            //Replace
            Console.WriteLine(movieName.Replace('l', 'L'));

            //Index of
            Console.WriteLine(tvShow.IndexOf('o'));

            //Last Index of
            Console.WriteLine(tvShow.LastIndexOf('o'));

            //Substring
            Console.WriteLine(tvShow.Substring(4));

            //Remove
            Console.WriteLine(tvShow.Remove(4));

            //insert
            Console.WriteLine(tvShow.Insert());
        }
    }
}
