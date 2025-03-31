namespace TypeConversions.TypesForConversions;

public abstract class Shape
{
    protected Shape(string name) => this.Name = name;

    public string Name { get; }

    public abstract void Draw();
}
