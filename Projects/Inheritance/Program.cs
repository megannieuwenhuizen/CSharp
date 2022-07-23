using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal=new Animal();
            Dogs dog=new Dogs();

        }
    }
    class Animal
    {
        public string animalName;
        public DateTime animalBirthDate;

        public void FeedAnimal()
        {

        }
    }
    class Dogs
    {
        public string dogBreed;
        public string dogIntelligence;
        public bool isEasyToTrain;

    }
    class Birds
    {
        public string birdColour;
        public string birdCountry;
    }
}
