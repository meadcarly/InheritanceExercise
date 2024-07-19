using System;

namespace Inheritance;

public class Animal
{
    public string Name { get; set; }
    public int Legs { get; set; }

    public string NoiseMade(string noise)
    {
        return $"{noise}";
    }

    public string Activity(string activity)
    {
        return $" The {Name} often {activity}";
    }
}