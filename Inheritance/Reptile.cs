using System;

namespace Inheritance;
// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class
public class Reptile : Animal
{
    public int TailNumber { get; set; }
    public string Length { get; set; }

    public int Swim(int swimSpeed)
    {
        return swimSpeed;
    }

    public string Movement(string movementType)
    {
        return $"{movementType}";
    }
}