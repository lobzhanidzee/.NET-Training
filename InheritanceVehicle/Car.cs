namespace InheritanceVehicle;

public class Car : Vehicle
{
    public Car(string name, int maxSpeed)
        : base(name, maxSpeed)
    {
    }

    public void SetCarName(string name)
    {
        this.Name = name;
    }

    public string GetCarName() => this.Name;
}
