using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Reptile
    // Set this class to inherit from your Animal Class
    public class Reptile : Animal
    {
        public Reptile()
        {
        }
        // give this class 4 members that are specific to Reptile
        public bool HasScales { get; set; }
        public bool IsSlimey { get; set; }
        public bool CanShedSkin { get; set; }
        public string TypeOfFood { get; set; }

    }
}
