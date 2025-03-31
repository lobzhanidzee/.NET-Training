using NUnit.Framework;
using TypeConversions.TypesForConversions;
using static TypeConversions.UnboxingConversions;

namespace TypeConversions.Tests;

public class UnboxingConversionsTests
{
    public static IEnumerable<TestCaseData> ObjectToPointTestCases
    {
        get
        {
            yield return new TestCaseData(
                new Point { X = 1, Y = 4 },
                new Func<object, Point?>(CastExpressionFromObjectToPoint));
            yield return new TestCaseData(
                new Point { X = -11, Y = 4 },
                new Func<object, Point?>(AsOperatorFromObjectToPoint));
            yield return new TestCaseData(
                new Point { X = 0, Y = 12 },
                new Func<object, Point?>(PatternMatchingFromObjectToPoint));
        }
    }

    public static IEnumerable<TestCaseData> ValueTypeToPointTestCases
    {
        get
        {
            yield return new TestCaseData(
                new Point { X = 1, Y = 4 },
                new Func<ValueType, Point?>(CastExpressionFromValueTypeToPoint));
            yield return new TestCaseData(
                new Point { X = -11, Y = 4 },
                new Func<ValueType, Point?>(AsOperatorFromValueTypeToPoint));
            yield return new TestCaseData(
                new Point { X = 0, Y = 12 },
                new Func<ValueType, Point?>(PatternMatchingFromValueTypeToPoint));
        }
    }

    public static IEnumerable<TestCaseData> ColorableToPointTestCases
    {
        get
        {
            yield return new TestCaseData(
                new Point { X = 1, Y = 4 },
                new Func<IColorable, Point?>(CastExpressionFromIColorableToPoint));
            yield return new TestCaseData(
                new Point { X = -11, Y = 4 },
                new Func<IColorable, Point?>(AsOperatorFromIColorableToPoint));
            yield return new TestCaseData(
                new Point { X = 0, Y = 12 },
                new Func<IColorable, Point?>(PatternMatchingFromIColorableToPoint));
        }
    }

    public static IEnumerable<TestCaseData> ObjectToColorTestCases
    {
        get
        {
            yield return new TestCaseData(
                Color.Blue,
                new Func<object, Color?>(CastExpressionFromObjectToColor));
            yield return new TestCaseData(
                Color.Red,
                new Func<object, Color?>(AsOperatorFromObjectToColor));
            yield return new TestCaseData(
                Color.Green,
                new Func<object, Color?>(PatternMatchingFromObjectToColor));
        }
    }

    public static IEnumerable<TestCaseData> ValueTypeToColorTestCases
    {
        get
        {
            yield return new TestCaseData(
                Color.Blue,
                new Func<ValueType, Color?>(CastExpressionFromValueTypeToColor));
            yield return new TestCaseData(
                Color.Red,
                new Func<ValueType, Color?>(AsOperatorFromValueTypeToColor));
            yield return new TestCaseData(
                Color.Green,
                new Func<ValueType, Color?>(PatternMatchingFromValueTypeToColor));
        }
    }

    public static IEnumerable<TestCaseData> EnumToColorTestCases
    {
        get
        {
            yield return new TestCaseData(Color.Blue, new Func<Enum, Color?>(CastExpressionFromEnumToColor));
            yield return new TestCaseData(Color.Red, new Func<Enum, Color?>(AsOperatorFromEnumToColor));
            yield return new TestCaseData(Color.Green, new Func<Enum, Color?>(PatternMatchingFromEnumToColor));
        }
    }

    public static IEnumerable<TestCaseData> ObjectToInt32TestCases
    {
        get
        {
            yield return new TestCaseData(-100, new Func<object, int?>(CastExpressionFromObjectToInt32));
            yield return new TestCaseData(123, new Func<object, int?>(AsOperatorFromObjectToInt32));
            yield return new TestCaseData(int.MaxValue, new Func<object, int?>(PatternMatchingFromObjectToInt32));
        }
    }

    public static IEnumerable<TestCaseData> ValueTypeToInt32TestCases
    {
        get
        {
            yield return new TestCaseData(
                -100,
                new Func<ValueType, int?>(CastExpressionFromValueTypeToInt32));
            yield return new TestCaseData(
                123,
                new Func<ValueType, int?>(AsOperatorFromValueTypeToInt32));
            yield return new TestCaseData(
                int.MaxValue,
                new Func<ValueType, int?>(PatternMatchingFromValueTypeToInt32));
        }
    }

    public static IEnumerable<TestCaseData> FormattableToInt32TestCases
    {
        get
        {
            yield return new TestCaseData(
                -100,
                new Func<IFormattable, int?>(CastExpressionFromIFormattableToInt32));
            yield return new TestCaseData(
                123,
                new Func<IFormattable, int?>(AsOperatorFromIFormattableToInt32));
            yield return new TestCaseData(
                int.MaxValue,
                new Func<IFormattable, int?>(PatternMatchingFromIFormattableToInt32));
        }
    }

    [TestCaseSource(nameof(ObjectToPointTestCases))]
    [Category("Unboxing Conversions")]
    public void Convert_FromObject_ReturnPoint(object obj, Func<object, Point?> converter)
    {
        Point point = (Point)converter(obj)!;
        (point.X, point.Y) = (point.X + 1, point.Y + 1);
        Assert.That(point.GetType() == obj.GetType());
        Assert.That(!point.Equals(obj));
    }

    [TestCaseSource(nameof(ValueTypeToPointTestCases))]
    [Category("Unboxing Conversions")]
    public void Convert_FromValueType_ReturnPoint(ValueType valueType, Func<ValueType, Point?> converter)
    {
        Point point = (Point)converter(valueType)!;
        (point.X, point.Y) = (point.X + 1, point.Y + 1);
        Assert.That(point.GetType() == valueType.GetType());
        Assert.That(!point.Equals(valueType));
    }

    [TestCaseSource(nameof(ColorableToPointTestCases))]
    [Category("Unboxing Conversions")]
    public void Convert_FromIColorable_ReturnPoint(IColorable colorable, Func<IColorable, Point?> converter)
    {
        Point point = (Point)converter(colorable)!;
        (point.X, point.Y) = (point.X + 1, point.Y + 1);
        Assert.That(point.GetType() == colorable.GetType());
        Assert.That(!point.Equals(colorable));
    }

    [TestCaseSource(nameof(ObjectToColorTestCases))]
    [Category("Unboxing Conversions")]
    public void Convert_FromObject_ReturnColor(object obj, Func<object, Color?> converter)
    {
        Color color = (Color)converter(obj)!;
        color = Color.Purple;
        Assert.That(color.GetType() == obj.GetType());
        Assert.That(!color.Equals(obj));
    }

    [TestCaseSource(nameof(ValueTypeToColorTestCases))]
    [Category("Unboxing Conversions")]
    public void Convert_FromValueType_ReturnColor(ValueType valueType, Func<ValueType, Color?> converter)
    {
        Color color = (Color)converter(valueType)!;
        color = Color.Purple;
        Assert.That(color.GetType() == valueType.GetType());
        Assert.That(!color.Equals(valueType));
    }

    [TestCaseSource(nameof(EnumToColorTestCases))]
    [Category("Unboxing Conversions")]
    public void Convert_FromEnum_ReturnColor(Enum @enum, Func<Enum, Color?> converter)
    {
        Color color = (Color)converter(@enum)!;
        color = Color.Purple;
        Assert.That(color.GetType() == @enum.GetType());
        Assert.That(!color.Equals(@enum));
    }

    [TestCaseSource(nameof(ObjectToInt32TestCases))]
    [Category("Unboxing Conversions")]
    public void Convert_FromObject_ReturnInt32(object obj, Func<object, int?> converter)
    {
        int value = (int)converter(obj)!;
        value = int.MinValue;
        Assert.That(value.GetType() == obj.GetType());
        Assert.That(!value.Equals(obj));
    }

    [TestCaseSource(nameof(ValueTypeToInt32TestCases))]
    [Category("Unboxing Conversions")]
    public void Convert_FromObject_ReturnInt32(ValueType valueType, Func<ValueType, int?> converter)
    {
        int value = (int)converter(valueType)!;
        value = int.MinValue;
        Assert.That(value.GetType() == valueType.GetType());
        Assert.That(!value.Equals(valueType));
    }

    [TestCaseSource(nameof(FormattableToInt32TestCases))]
    [Category("Unboxing Conversions")]
    public void Convert_FromIFormattable_ReturnInt32(IFormattable formattable, Func<IFormattable, int?> converter)
    {
        int value = (int)converter(formattable)!;
        value = int.MinValue;
        Assert.That(value.GetType() == formattable.GetType());
        Assert.That(!value.Equals(formattable));
    }
}
