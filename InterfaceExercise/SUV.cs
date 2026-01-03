using System;

namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public int NumberOfSeats { get; set; } = 7;
    public bool HasBed { get; set; } = false;
    public int NumberOfWheels { get; set; } = 4;
    public bool HasRadio { get; set; } = true;
    public string Color { get; set; } = "black";
    public int Miles { get; set; } = 100000;
    public string Logo { get; set; }
    public string Name { get; set; }
    public void DisplayDetails()
    {
        Console.WriteLine($"This SUV has {NumberOfSeats} seats.");
        Console.WriteLine($"Has Bed: {HasBed}");
        Console.WriteLine($"Has Radio: {HasRadio}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Miles: {Miles}");
        Console.WriteLine($"SUV has {NumberOfWheels} wheels");
    }

   
}