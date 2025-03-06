namespace InheritanceVehicle;

public class Vehicle
{
    private string? name;
    private readonly int maxSpeed;

    public Vehicle()
    {
    }

    public int MaxSpeed { get => this.maxSpeed; }

    protected string Name { get => this.name; set { this.name = value; } }
}
