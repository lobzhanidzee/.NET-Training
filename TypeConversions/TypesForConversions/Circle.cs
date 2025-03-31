namespace TypeConversions.TypesForConversions;

public class Circle : Shape
{
    public Circle(string name, double radius)
        : base(name) => this.Radius = radius <= 0 ? throw new ArgumentOutOfRangeException(nameof(radius)) : radius;

    public double Radius { get; }

    public override void Draw() => Console.WriteLine($"\"{this.Name}\" circle is drawn. ");
}
