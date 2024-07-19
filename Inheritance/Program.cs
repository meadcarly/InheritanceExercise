using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Done  Create a class Animal
            // Done  give this class 4 members that all Animals have in common


            // Done  Create a class Bird
            // Done  give this class 4 members that are specific to Bird
            // Done  Set this class to inherit from your Animal Class

            // Done  Create a class Reptile
            // Done  give this class 4 members that are specific to Reptile
            // Done  Set this class to inherit from your Animal Class




            /* Done  Create an object of your Bird class
             * Done give values to your members using the object of your Bird class
             *  
             * Done Creatively display the class member values 
             */

            /* Done  Create an object of your Reptile class
             *  Done  give values to your members using the object of your Reptile class
             *  
             * Done  Creatively display the class member values 
             */
            var parrot = new Bird();
            var crocodile = new Reptile();

            parrot.Wings = "colorful";
            parrot.FavoriteSeed = "brazil nuts";
            parrot.Name = "Parrot";
            var noiseParrot = parrot.NoiseMade("ability to mimic many noises");
            var flightPatternParrot = parrot.FlightPattern("local areas all year");
            var migrateParrot = parrot.Migration("only when they run out of resources. They prefer to stay in one area");
            
            Console.WriteLine($"Meet the {parrot.Name}. He is characterized by his {parrot.Wings} wings, and by his {noiseParrot}.\n{flightPatternParrot} and they migrate {migrateParrot}.");

            crocodile.Name = "Crocodile";
            crocodile.TailNumber = 1;
            crocodile.Length = "10-23 feet long";
            var moveType = crocodile.Movement("barrel roll");
            var swimSpeed = crocodile.Swim(18);

            Console.WriteLine($"\nMeet the {crocodile.Name}. He is a fearsome predator characterized by his {crocodile.TailNumber} tail that propels him upwards of {swimSpeed} mph.\nHe can grow anywhere from {crocodile.Length}, and he typically kills his prey with a {moveType} underwater.");

        }
    }
}
