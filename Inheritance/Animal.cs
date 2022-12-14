using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{// Create a class Animal
    public class Animal
    {
        public Animal()
        {
        }
        // give this class 4 members that all Animals have in common
        public string AnimalNoise{ get; set; } 
        
        public string HairType { get; set; } 
     
        public int NumberOfLegs { get; set; }
        
        public string AnimalTemperment { get; set; }
    }
}
