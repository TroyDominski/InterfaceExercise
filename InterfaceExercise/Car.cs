using System;

namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public bool HasTrunk { get; set; } = true;
    public bool FrontWheelDrive { get; set; } = true;
    public int NumberOfWheels { get; set; } = 4;
    public bool HasRadio { get; set; } = true;
    public string Color { get; set; }  = "Red";
    public int Miles { get; set; } = 56000;
    public string Logo { get; set; }
    public string Name { get; set; }
    public void DisplayDetails()
    {
        Console.WriteLine($"This car has {NumberOfWheels} wheels");
        Console.WriteLine($"This car is {Color}.");
        Console.WriteLine($"Does this car have a trunk? {HasTrunk}");
        Console.WriteLine($"Does this car have a radio? {HasRadio}");
        Console.WriteLine($"Does this car have a wheel drive? {FrontWheelDrive}");
        Console.WriteLine($"This car has {Miles} miles");}
        
    }

     
    
