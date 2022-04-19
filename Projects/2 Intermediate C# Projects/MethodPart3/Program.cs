using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPart3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstEmployee, secondEmployee;

            /*1*/firstEmployee = "Shan Will";
            /*2*/secondEmployee = "Megs Dillon";

            /*3*/Console.WriteLine($"Inside Main Method \n------------------------\n{firstEmployee}\n{secondEmployee}\n\n");
            /*ORRRRRRRR ignore line 1,2,3 
             * passing by reference
             ChangeNames(out string firstEmployee, out string secondEmployee) ;
             */


            ChangeNames(ref firstEmployee,ref secondEmployee);
            Console.WriteLine($"Inside Main Method \n------------------------\n{firstEmployee}\n{secondEmployee}\n\n");
        }
        static void ChangeNames(ref string firstEmp,ref string secEmp)
        {
            //passing by value
            firstEmp = "Fagan Dillon";
            secEmp = "Kisten Gonsalves";
            Console.WriteLine($"Outside Main Method \n------------------------\n{firstEmp}\n{secEmp}\n\n");
        }
    }
   
}
