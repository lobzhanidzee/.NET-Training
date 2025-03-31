namespace TypeConversions.TypesForConversions;

public class Square : Shape, IColorable
{
    private Color color;

    public Square(string name, double side)
        : base(name) => this.Side = side <= 0 ? throw new ArgumentOutOfRangeException(nameof(side)) : side;

    public double Side { get; }

    public Color Color => this.color;

    public override void Draw() => Console.WriteLine($"{this.color} square is drawn.");

    public void Colorize(Color color) => this.color = color;
}
