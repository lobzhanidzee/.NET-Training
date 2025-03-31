namespace TypeConversions.TypesForConversions;

public struct Point : IColorable
{
    public double X { get; set; }

    public double Y { get; set; }

    public Color Color { get; private set; }

    public void Colorize(Color color) => this.Color = color;
}
