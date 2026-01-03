using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public bool HasTrailer { get; set; } = false;
    public int NumberOfMirrors { get; set; } = 5;
    public int NumberOfWheels { get; set; } = 4;
    public bool HasRadio { get; set; } = true;
    public string Color { get; set; } = "yellow";
    public int Miles { get; set; } = 1000;
    public string Logo {  get; set; }
    public string Name { get; set; }
    public void DisplayDetails()
    {
        Console.WriteLine($"Truck has trailer: {HasTrailer}");
        Console.WriteLine($"Truck has mirrors: {NumberOfMirrors}");
        Console.WriteLine($"Truck has wheels: {NumberOfWheels}");
        Console.WriteLine($"Truck has radio: {HasRadio}");
        Console.WriteLine($"Truck has color: {Color}");
        Console.WriteLine($"Truck has {Miles} miles");
        
    }
    }

    
