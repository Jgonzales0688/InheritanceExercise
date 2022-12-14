using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {// TODO Be sure to follow best practice when creating your classes
            /*Create an object of your Bird class
                 *  give values to your members using the object of your Bird class
                 *  
                 * Creatively display the class member values 
                 */
            Bird parrot = new Bird();

            parrot.FeatherColor = "multi color";
            parrot.IsBirdSmall = true;
            parrot.CanBirdFly = true;
            parrot.WildBirdorPet = "pet";
            parrot.AnimalTemperment = "funny";
            parrot.AnimalNoise = "talk";
            parrot.HairType = "feathers";

            Console.WriteLine($"I went to the pet store and saw a Parrot with {parrot.FeatherColor} {parrot.HairType}. ");
            Console.WriteLine($"The parrot was a {parrot.WildBirdorPet} that could {parrot.AnimalNoise} and was very {parrot.AnimalTemperment}.");
            Console.WriteLine($"Now that I have seen one in person I know it is {parrot.IsBirdSmall} they can be small and it is also {parrot.CanBirdFly} they can fly.");



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile frog = new Reptile();
            
            frog.CanShedSkin= true;
            frog.TypeOfFood = "insects";
            frog.NumberOfLegs = 4;
            frog.AnimalNoise = "croaking";

            Console.WriteLine($"While at the pet store I also saw a frog. On its informaiton sheet it said it is {frog.CanShedSkin}\n" +
                $"they shed their skin. It also stated that all frogs have {frog.NumberOfLegs} legs, all make some form of {frog.AnimalNoise}\n" +
                $"sound and eat {frog.TypeOfFood}.");

        }
            
            
        

            
            
            




            
        }
    }

