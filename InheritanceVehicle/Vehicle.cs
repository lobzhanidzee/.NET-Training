namespace InheritanceVehicle;

public class Vehicle
{
    private string? name;
    private readonly int maxSpeed;

    public Vehicle(string name, int maxSpeed)
    {
        this.Name = name;
        this.maxSpeed = maxSpeed;
    }

    public int MaxSpeed { get => this.maxSpeed; }

    protected string Name { get => this.name; set { this.name = value; } }
}
