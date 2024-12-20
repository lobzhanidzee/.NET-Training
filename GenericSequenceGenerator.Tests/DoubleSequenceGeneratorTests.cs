using AntiCheater;
using NUnit.Framework;

namespace GenericSequenceGenerator.Tests;

[TestFixture]
public class DoubleSequenceGeneratorTests() : AntiCheatingTest(CheatingDetectionParams.All)
{
    [TestCase(10, new double[] { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 })]
    public void GetNext_Should_Advance_Generator_In_Third_Sequence(int count, double[] expected)
    {
        var previous = 1.0;
        var current = 2.0;

        var thirdSequenceGenerator = new DoubleSequenceGenerator(previous, current);
        var list = new List<double>(count)
        {
            thirdSequenceGenerator.Previous,
            thirdSequenceGenerator.Current
        };

        for (int i = 1; i <= count - 2; i++)
        {
            list.Add(thirdSequenceGenerator.Next);
        }

        Assert.That(expected, Is.EqualTo(list.ToArray()).Within(0.000001));
        Assert.That(thirdSequenceGenerator.Count == count);
    }
}
