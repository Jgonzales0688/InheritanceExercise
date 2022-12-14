using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Bird
    // Set this class to inherit from your Animal Class
    public class Bird : Animal
    {
        public Bird()
        {
        }
        // give this class 4 members that are specific to Bird
        public string FeatherColor { get; set; }
        public bool IsBirdSmall { get; set; }
        public bool CanBirdFly { get; set; }
        public string WildBirdorPet { get; set; }
    }
}
