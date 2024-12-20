using AntiCheater;
using NUnit.Framework;

namespace GenericSequenceGenerator.Tests;

[TestFixture]
public class IntegerSequenceGeneratorTests() : AntiCheatingTest(CheatingDetectionParams.All)
{
    [TestCase(10, new[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 })]
    public void GetNext_Should_Advance_Generator_In_Second_Sequence(int count, int[] expected)
    {
        var previous = 1;
        var current = 2;

        var secondSequenceGenerator = new IntegerSequenceGenerator(previous, current);
        var list = new List<int>(count)
        {
            secondSequenceGenerator.Previous,
            secondSequenceGenerator.Current
        };

        for (int i = 1; i <= count - 2; i++)
        {
            list.Add(secondSequenceGenerator.Next);
        }

        Assert.That(expected, Is.EqualTo(list.ToArray()));
        Assert.That(secondSequenceGenerator.Count == count);
    }
}

