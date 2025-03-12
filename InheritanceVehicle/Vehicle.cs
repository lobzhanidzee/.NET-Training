namespace InheritanceVehicle;

public class Vehicle
{
    private readonly int maxSpeed;
    private string? name;

    public Vehicle(string name, int maxSpeed)
    {
        this.name = name;
        this.maxSpeed = maxSpeed;
    }

    public Vehicle(int maxSpeed, string name)
    {
        this.name = name;
        this.maxSpeed = maxSpeed;
    }

    public int MaxSpeed { get => this.maxSpeed; }

    protected string Name
    {
        get => this.name!; set { this.name = value; }
    }
}
