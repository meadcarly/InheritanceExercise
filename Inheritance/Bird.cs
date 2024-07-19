using System;

namespace Inheritance;
// Create a class Bird
// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class
public class Bird : Animal
{
    public string Wings { get; set; }
    public string FavoriteSeed { get; set; }

    public string Migration(string migrationPattern)
    {
        return $"migrate {migrationPattern}";
    }

    public string FlightPattern(string patternOfFlight)
    {
        return $"{Name}s tend to fly in {patternOfFlight}";
    }
}