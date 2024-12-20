using AntiCheater;
using NUnit.Framework;

namespace GenericSequenceGenerator.Tests;

[TestFixture]
public class FibonacciSequenceGeneratorTests() : AntiCheatingTest(CheatingDetectionParams.All)
{
    [TestCase(20, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181 })]
    public void GetNext_Should_Advance_Generator_In_Fibonacci_Sequence(int count, int[] expected)
    {
        var previous = 0;
        var current = 1;

        var fibonacciGenerator = new FibonacciSequenceGenerator(previous, current);
        var list = new List<int>(count)
        {
            fibonacciGenerator.Previous,
            fibonacciGenerator.Current
        };

        for (int i = 1; i <= count - 2; i++)
        {
            list.Add(fibonacciGenerator.Next);
        }

        Assert.That(expected, Is.EqualTo(list.ToArray()));
        Assert.That(fibonacciGenerator.Count == count);
    }
}
