using NUnit.Framework;
using TypeConversions.TypesForConversions;
using static TypeConversions.ImplicitReferenceConversions;

namespace TypeConversions.Tests;

public class ImplicitReferenceConversionsTests
{
    public static IEnumerable<TestCaseData> ShapeTestCases
    {
        get
        {
            yield return new TestCaseData(new Circle("Circle A", 1.1));
            yield return new TestCaseData(new Circle("Circle B", 2.4));
            yield return new TestCaseData(new Circle("Circle C", 3.5));
            yield return new TestCaseData(new Circle("Circle D", 3.5));
            yield return new TestCaseData(new Square("Square ", 4.2));
            yield return new TestCaseData(new Square("Square Y", 1.4));
            yield return new TestCaseData(new Square("Square Z", 5.5));
        }
    }

    public static IEnumerable<TestCaseData> CircleTestCases
    {
        get
        {
            yield return new TestCaseData(new Circle("Circle A", 1.1));
            yield return new TestCaseData(new Circle("Circle B", 2.4));
            yield return new TestCaseData(new Circle("Circle C", 3.5));
            yield return new TestCaseData(new Circle("Circle D", 3.5));
        }
    }

    public static IEnumerable<TestCaseData> SquareTestCases
    {
        get
        {
            yield return new TestCaseData(new Square("Square A", 1.11));
            yield return new TestCaseData(new Square("Square B", 2.44));
            yield return new TestCaseData(new Square("Square C", 3.15));
            yield return new TestCaseData(new Square("Square D", 0.5));
        }
    }

    [TestCaseSource(nameof(ShapeTestCases))]
    [Category("Explicit Reference Conversions")]
    public void ConvertToObject_FromShape_ReturnObject(Shape shape)
    {
        object @object = ConvertToObject(shape);
        Assert.That(@object is Shape);
        Assert.That(((Shape)@object).Name == shape.Name);
    }

    [TestCaseSource(nameof(CircleTestCases))]
    [Category("Explicit Reference Conversions")]
    public void ConvertToObject_FromCircle_ReturnObject(Circle circle)
    {
        object @object = ConvertToObject(circle);
        Assert.That(@object is Circle);
        Assert.That(((Circle)@object).Name == circle.Name);
        Assert.That(Math.Abs(((Circle)@object).Radius - circle.Radius) < double.Epsilon);
    }

    [TestCaseSource(nameof(SquareTestCases))]
    [Category("Explicit Reference Conversions")]
    public void ConvertToObject_FromSquare_ReturnObject(Square square)
    {
        object @object = ConvertToObject(square);
        Assert.That(@object is Square);
        Assert.That(((Square)@object).Name == square.Name);
        Assert.That(Math.Abs(((Square)@object).Side - square.Side) < double.Epsilon);
    }

    [TestCaseSource(nameof(CircleTestCases))]
    [Category("Circle to Shape Implicit Conversions")]
    public void ConvertToShape_FromCircle_ReturnShape(Circle circle)
    {
        Shape shape = ConvertToShape(circle);
        Assert.That(shape is Circle);
        Assert.That(((Circle)shape).Name == circle.Name);
        Assert.That(Math.Abs(((Circle)shape).Radius - circle.Radius) < double.Epsilon);
    }

    [TestCaseSource(nameof(SquareTestCases))]
    [Category("Explicit Reference Conversions")]
    public void ConvertToShape_FromSquare_ReturnShape(Square square)
    {
        Shape shape = ConvertToShape(square);
        Assert.That(shape is Square);
        Assert.That(((Square)shape).Name == square.Name);
        Assert.That(Math.Abs(((Square)shape).Side - square.Side) < double.Epsilon);
    }

    [TestCaseSource(nameof(SquareTestCases))]
    [Category("Explicit Reference Conversions")]
    public void ConvertToIColorable_ConvertFromSquareToConvertToIColorable(Square square)
    {
        square.Colorize(Color.Yellow);
        IColorable colorable = ConvertToIColorable(square);
        Assert.That(colorable.Color == square.Color);
        Assert.That(colorable is Square);
        Assert.That(((Square)colorable).Name == square.Name);
        Assert.That(Math.Abs(((Square)colorable).Side - square.Side) < double.Epsilon);
        Assert.That(((Square)colorable).Name == square.Name);
    }
}
