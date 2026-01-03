namespace InterfaceExercise;

public interface IVehicle
{
    public int NumberOfWheels{ get; set; }
    public bool HasRadio{ get; set; }
    public string Color{ get; set; }
    public int Miles{ get; set; }
   
    public void DisplayDetails();
}