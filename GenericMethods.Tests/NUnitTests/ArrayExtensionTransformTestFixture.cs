using DoubleTransformer;
using GenericMethods.Interfaces;
using NUnit.Framework;

namespace GenericMethods.Tests.NUnitTests;

[TestFixture(
    new[] { 122.625, -255.255, 255.255, 4294967295.012, -451387.2345, 0.2345E-12 },
    new[]
    {
        "0100000001011110101010000000000000000000000000000000000000000000", "1100000001101111111010000010100011110101110000101000111101011100", "0100000001101111111010000010100011110101110000101000111101011100", "0100000111101111111111111111111111111111111000000110001001001110", "1100000100011011100011001110110011110000001000001100010010011100", "0011110101010000100000000110000001011111000011101110100001011011",
    },
    TypeArgs = [typeof(double), typeof(string)])]
public class ArrayExtensionTransformTestFixture<TSource, TResult>(TSource[] source, TResult[] expected)
{
    private readonly ITransformer<TSource, TResult> transformer = TransformerCreator(typeof(TSource), typeof(TResult));

    [Test]
    public void TransformerTest()
    {
        var actual = source.Transform(this.transformer).ToArray();
        Assert.That(actual, Is.EqualTo(expected));
    }

    private static ITransformer<TSource, TResult> TransformerCreator(Type typeSource, Type typeResult)
    {
        if (typeSource == typeof(double) && typeResult == typeof(string))
        {
            return (ITransformer<TSource, TResult>)new GetIeee754Format();
        }

        return null!;
    }
}
