using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaeTimeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            string formattedDate = "";
            //First format : 30-09-2017 01:15:55
            formattedDate = String.Format("{0:dd-MM-yyy HH:mm:ss}",myDate);
            Console.WriteLine(formattedDate);

            //Second Format : Saturday of month September 2017
            formattedDate = String.Format("{0: dddd 'of month ' MMMM ' year ' yyyy}",myDate);
            Console.WriteLine(formattedDate);
            /*Third Format
             Day Saturday
            Month September
            Year 2017*/
            formattedDate = String.Format("{0: 'Day' dddd \n 'Month' MMMM \n 'Year' yyyy}",myDate);
            Console.WriteLine(formattedDate); 

        }
    }
}
