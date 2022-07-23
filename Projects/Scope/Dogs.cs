using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    internal class Dogs
    {
        string dogBreed;
        string dogName;
        string dogColor;
        string trainerName;

        public void TrainDog()
        {
            
            trainerName = "Daniel";
        }

        public void FeedDog()
        {
            string foodName;
        }
    }
}
