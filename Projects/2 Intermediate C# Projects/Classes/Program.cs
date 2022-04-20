using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person perOne = new Person();
            perOne.FirstName = "Megan";
            perOne.LastName = "Dillon";
            perOne.Country = "South Africa";

            Person perTwo = new Person();
            perTwo.FirstName = "Fagan";
            perTwo.LastName = "Dillon";
            perTwo.Country = "South Africa";

            Console.WriteLine(perOne.FirstName);
            Console.WriteLine(perTwo.FirstName); 
        }
        
    }
    class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;

        public Person()
        {
            firstName = "Unkown";// when new instance of class initialized eg perThree, if no value assigned it will assign the firstname value to Unkown
        }
        public string FirstName
        {
            get {  return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime BirthDate { get; set; }
        public String Country { get; set; }
    }
}
