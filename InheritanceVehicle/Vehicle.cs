namespace InheritanceVehicle;

public class Vehicle
{
    private string? name;
    private readonly int maxSpeed;

    public Vehicle()
    {
    }

    public int MaxSpeed { get; }

    protected string Name { get; set; }
}
